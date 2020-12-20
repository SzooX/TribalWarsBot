using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
//using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using TribalWars.Workers;

namespace TribalWars
{
    public partial class Form1 : Form
    {
        //Timers
        Timer BuildTimer = new Timer();

        //Workers
        public WebBrowser WorkerBrowser1;
        //
        public List<Village> Villages = new List<Village>();
        ContextMenuStrip ctmenu = new ContextMenuStrip(); // context menu for villagelist
        ContextMenuStrip TabContextMenu = new ContextMenuStrip(); // context menu for maintabcontrol . To be added
        //
        ChromiumWebBrowser CefWebBrowser;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Create browser
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            CefWebBrowser = CreateNewChromeBrowser("TribalWars.net", false);
            CefWebBrowser.Parent = WWWtabnew;
        }

        //Chromium events
        private void Contextmenu_NewTabRequest(string url)
        {
            MethodInvoker methodInvokerDelegate = delegate ()
            {
                TabPage newtb = new TabPage()
                {
                    Text = "Loading...",
                    Tag = "Closeable",
                    ImageIndex = 0
                };
                CreateNewChromeBrowser(url).Parent = newtb;
                maintabcontrol.TabPages.Insert(maintabcontrol.TabPages.IndexOf(Villagestab), newtb);
                maintabcontrol.SelectTab(maintabcontrol.TabPages.IndexOf(newtb));

            };
            this.Invoke(methodInvokerDelegate);
        }
        private void BrowserTitleChanged(object sender, TitleChangedEventArgs e)
        {
            ChromiumWebBrowser browser = sender as ChromiumWebBrowser;
            TabPage parenttabpage = browser.Parent as TabPage;
            MethodInvoker inovokerdelegate = delegate ()
            {
                if (e.Title.Length > 15)
                {
                    var newtitle = e.Title.Substring(0, 20);
                    newtitle += "..";
                    parenttabpage.Text = newtitle;
                }
                else parenttabpage.Text = e.Title;

            };
            this.Invoke(inovokerdelegate);
        }

        public ChromiumWebBrowser CreateNewChromeBrowser(string url, bool TitleEvent = true)
        {
            ChromiumWebBrowser newbrowser = new ChromiumWebBrowser(url);
            newbrowser.Dock = DockStyle.Fill;
            //Create implementations
            CefCustomMenuMain contextmenu = new CefCustomMenuMain();
            LifeSpanderMain lifespander = new LifeSpanderMain();
            //Assign implementations
            newbrowser.MenuHandler = contextmenu;
            newbrowser.LifeSpanHandler = lifespander;
            //Assign events
            contextmenu.NewTabRequest += Contextmenu_NewTabRequest;
            if (TitleEvent) newbrowser.TitleChanged += BrowserTitleChanged;
            return newbrowser;
        }
        public Form1()
        {
            // Creating addidiotnal browser
            InitializeComponent();
            //Assignation of some events in code
            #region Events assign
            maintabcontrol.MouseDown += Maintabcontrol_MouseDown;
            #endregion
            WorkerBrowser1 = new WebBrowser()
            {
                Tag = "free",
                Name = "WB1"

            };
            WorkerBrowser1.Size = new Size(0, 0);
            WorkerBrowser1.Visible = true;
            this.Controls.Add(WorkerBrowser1);


            WorkerBrowser1.Navigate("google.pl");
            //
            //Settuping villagelist
            #region villagelist and their context menu
            for (int i = 3; i < 21; i++)
            {
                villageslist.Columns[i].ImageIndex = i - 3;
            }
            ctmenu.ImageList = ContextMenuImgs;
            //villageslist.ContextMenuStrip = ctmenu;
            ToolStripMenuItem item1 = new ToolStripMenuItem();
            item1.Name = "Set active";
            item1.Text = "Set active";
            item1.ImageIndex = 0;
            item1.Click += VillagesContextMenuClick;
            ToolStripMenuItem item2 = new ToolStripMenuItem();
            item2.Name = "Disable";
            item2.Text = "Disable";
            item2.ImageIndex = 1;
            item2.Click += VillagesContextMenuClick;
            ToolStripMenuItem item3 = new ToolStripMenuItem();
            item3.Name = "Configure";
            item3.Text = "Configure";
            item3.ImageIndex = 2;
            item3.Click += VillagesContextMenuClick;
            ToolStripMenuItem item4 = new ToolStripMenuItem();
            item4.Margin = new Padding(0, 10, 0, 0);
            item4.Name = "Remove";
            item4.Text = "Remove";
            item4.ImageIndex = 3;
            item4.Click += VillagesContextMenuClick;
            ctmenu.Items.Add(item1);
            ctmenu.Items.Add(item2);
            ctmenu.Items.Add(item3);
            ctmenu.Items.Add(item4);
            #endregion
            //
            InitializeBrowserEvents(wbextended);

            //Bot timer
            Timer bottime = new Timer();
            bottime.Tick += new EventHandler(UpdateBotTime);
            bottime.Interval = 1;
            bottime.Start();
            //Build timer
            BuildTimer.Tick += new EventHandler(BuildVillages);
        }

        private void Maintabcontrol_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                var tabControl = sender as TabControl;
                var tabs = tabControl.TabPages;
                TabPage pg = tabs.Cast<TabPage>()
                        .Where((t, i) => tabControl.GetTabRect(i).Contains(e.Location))
                        .First();
                if (pg.Tag != null) if (pg.Tag.ToString().ToLower() == "closeable") tabs.Remove(pg);
            }
        }

        private void VillagesContextMenuClick(object sender, EventArgs e)
        {
            //active / deactive 
            ToolStripItem itm = sender as ToolStripItem;
            var match = Villages.Find((v) => v.Name == villageslist.FocusedItem.SubItems[1].Text);
            if (itm.Text == "Set active")
            {
                if (match.BuildQueue != null) { if (match.buildSettings.AnyOption() == true) match.villageSettings.Active = true; 
                else MessageBox.Show("Cannot set active village without queue or buildsettings");
                }
                else MessageBox.Show("Cannot set active village without queue or buildsettings");
            }
            else if(itm.Text == "Disable")
            {
                match.villageSettings.Active = false;
            }
            else if (itm.Text == "Configure")
            {
                VillageForm vf = new VillageForm(this, match);
                vf.Show();
            }
            else if (itm.Text == "Remove")
            {
                Villages.Remove(match);
            }
            UpdateVillageList(Villages);
        }
        private void UpdateBotTime(object sender, EventArgs e)
        {
            bottime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture);
        }
        HtmlElement FindByClass(HtmlDocument doc, string tag, string class_)
        {
            var links = doc.GetElementsByTagName(tag);
            foreach (HtmlElement link in links)
            {
                if (link.GetAttribute("className") == class_)
                {
                    return link;
                }
            }
            return null;
        }
        HtmlElement FindByClass(HtmlElement doc, string tag, string class_)
        {
            var links = doc.GetElementsByTagName(tag);
            foreach (HtmlElement link in links)
            {
                if (link.GetAttribute("className") == class_)
                {
                    return link;
                }
            }
            return null;
        }
        List<HtmlElement> FindManyByClass(HtmlDocument doc, string tag, string class_)
        {
            List<HtmlElement> elements = new List<HtmlElement>();
            var links = doc.GetElementsByTagName(tag);
            foreach (HtmlElement link in links)
            {
                if (link.GetAttribute("className") == class_)
                {
                    elements.Add(link);
                }
            }
            return elements;
        }
        private void InitializeBrowserEvents(ExtendedWebBrowser SourceBrowser)
        {
            //SourceBrowser.NewWindow2 += new EventHandler<NewWindow2EventArgs>(SourceBrowser_NewWindow2);
        }
        //Creating new webrowser window inside app
        void SourceBrowser_NewWindow2(object sender, NewWindow2EventArgs e)
        {

            TabPage NewTabPage = new TabPage()
            {
                Text = "Loading..."
            };

            ExtendedWebBrowser NewTabBrowser = new ExtendedWebBrowser()
            {
                Parent = NewTabPage,
                Dock = DockStyle.Fill,
                Tag = NewTabPage
            };

            e.PPDisp = NewTabBrowser.Application;
            InitializeBrowserEvents(NewTabBrowser);

            maintabcontrol.TabPages.Add(NewTabPage);
            maintabcontrol.SelectedTab = NewTabPage;

        }
        public async void LoginPageLoaded(object sender, LoadingStateChangedEventArgs e)
        {
            CefWebBrowser.LoadingStateChanged -= LoginPageLoaded;
            //TODO Check if user entered all req data
            var script = "(function(){  var field = document.getElementById(\"user\"); if(field){return true}else return field; })();";
            var response = await CefWebBrowser.EvaluateScriptAsync(script);
            if (response.Result != null) if ((bool)response.Result)
                {
                    tryagain:
                    script = $@"(function(){{
                    document.getElementById(""user"").value = ""{loginbox.Text}"";
                    document.getElementById(""password"").value = ""{passwordbox.Text}"";
                    document.getElementsByClassName(""btn-login"")[0].click();
                }})();";
                    response = await CefWebBrowser.EvaluateScriptAsync(script);
                    script = $@" document.getElementsByClassName(""world-select"").length > 0";
                    response = await CefWebBrowser.EvaluateScriptAsync(script);
                    if (response.Result != null) if ((bool)response.Result)
                    {
                            script = $@"(function(){{
                    var worlds = document.getElementsByClassName(""world-select"");
                            for (i = 0; i < worlds.length; i++)
                            {{
                                if (worlds[i].getAttribute(""href"").includes(""{worldbox.Text}""))
                                      {{
                                    window.location.href = worlds[i].getAttribute(""href"");
                                }}
                        }}
                }})();";
                            response = await CefWebBrowser.EvaluateScriptAsync(script);
                }
                else
                {
                            System.Threading.Thread.Sleep(1000);
                            goto tryagain;
                }

            }
            return;
        }
        public void LoginPageLoaded_old(object sender, EventArgs e)
        {
            //TODO Check if user entered all req data
            //Logging
            if (wbextended.Document.GetElementById("user") != null) {
                wbextended.Document.GetElementById("user").SetAttribute("value", loginbox.Text);
                wbextended.Document.GetElementById("password").SetAttribute("value", passwordbox.Text);
                System.Threading.Thread.Sleep(1000);
                FindByClass(wbextended.Document, "a", "btn-login").InvokeMember("click");
            }
            //Choosing world
            List<HtmlElement> activeworlds = FindManyByClass(wbextended.Document, "a", "world-select");
            foreach (var item in activeworlds)
            {
                if (item.GetAttribute("href").Contains(worldbox.Text))
                {
                    item.InvokeMember("click");
                    break;
                }
            }
            wbextended.DocumentCompleted -= LoginPageLoaded_old;
        } //old method, delete when will be unecessary
        private void botstartbtt_Click(object sender, EventArgs e)
        {
            if(CefWebBrowser.Address != panelbox.Text)CefWebBrowser.Load(panelbox.Text);
            else
            {
                LoginPageLoaded(CefWebBrowser, new LoadingStateChangedEventArgs(null, false, false , false));
                return;
            }
            CefWebBrowser.LoadingStateChanged += LoginPageLoaded;
            //wbextended.Navigate(panelbox.Text);
            //wbextended.DocumentCompleted += LoginPageLoaded_old;  OLD
            //Entering world
            try
            {
                //checkforworlds:
                //List<IWebElement> activeworlds = new List<IWebElement>(driver.FindElements(By.ClassName("world_button_active")));
                //if (activeworlds.Count == 0)
                //{
                //    goto checkforworlds;
                //}
                //bool worldlocated = false;
                //foreach (IWebElement element in activeworlds)
                //{
                //    string worldnumber = element.Text;
                //    if (-1 < worldnumber.IndexOf(WorldNumberBox.Text))
                //    {
                //        worldlocated = true;
                //        element.Click();
                //        break;
                //    }
                //}
                //if (!worldlocated)
                //{
                //    //throw error
                //}
                ////Enabling village
                ////TODO Find all villages
                //villagefirst = new Village(driver);
                //villagefirst.UpdateResources();
                //bot = new Bot(villagefirst, driver, this);
                ////Starting timer for update villages
                //aTimer = new System.Timers.Timer();
                //aTimer.Interval = 2000;
                //aTimer.Elapsed += OnTimedEvent;
                //aTimer.AutoReset = true;
                //aTimer.Enabled = true;
            }

            catch (Exception ex)
            {
                throw new Exception("Problem while entering world" + ex);
            }
        }
        
        //Add villages
        private async void addcitybutt_Click(object sender, EventArgs e)
        {
            var script = @"document.getElementById(""villages"") != null";
            var response = await CefWebBrowser.EvaluateScriptAsync(script);
            if(response.Result != null)if ((bool)response.Result)
            {
                return;
                HtmlElement villageshtml = wbextended.Document.GetElementById("villages");
                foreach (HtmlElement item in villageshtml.GetElementsByTagName("tr"))
                {
                    string nejm = FindByClass(item, "span", "quickedit-label").InnerHtml.Replace("\\n", "").Trim(); //village name
                    var matches = Villages.Where(p => p.Name == nejm);
                    if (matches.ToList().Count == 0)
                    {
                        VillageSettings apppSettings = new VillageSettings();
                            apppSettings.Link = FindByClass(item, "span", "quickedit-content").GetElementsByTagName("a")[0].GetAttribute("href").Replace("&screen=main", "");
                            Buildings bld = new Buildings()
                            {
                                Main = int.Parse(FindByClass(item, "td", "upgrade_building b_main").InnerText),
                                Barracks = int.Parse(FindByClass(item, "td", "upgrade_building b_barracks").InnerText),
                                Stable = int.Parse(FindByClass(item, "td", "upgrade_building b_stable").InnerText),
                                Garage = int.Parse(FindByClass(item, "td", "upgrade_building b_garage").InnerText),
                                Church = int.Parse(FindByClass(item, "td", "upgrade_building b_church_f").InnerText), // upgrade_building b_church << you know what to do
                                Watchtower = int.Parse(FindByClass(item, "td", "upgrade_building b_watchtower").InnerText),
                                Snob = int.Parse(FindByClass(item, "td", "upgrade_building b_watchtower").InnerText),
                                Smith = int.Parse(FindByClass(item, "td", "upgrade_building b_smith").InnerText),
                                Place = int.Parse(FindByClass(item, "td", "upgrade_building b_place").InnerText),
                                Statue = int.Parse(FindByClass(item, "td", "upgrade_building b_statue").InnerText),
                                Market = int.Parse(FindByClass(item, "td", "upgrade_building b_market").InnerText),
                                Wood = int.Parse(FindByClass(item, "td", "upgrade_building b_wood").InnerText),
                                Stone = int.Parse(FindByClass(item, "td", "upgrade_building b_stone").InnerText),
                                Iron = int.Parse(FindByClass(item, "td", "upgrade_building b_iron").InnerText),
                                Farm = int.Parse(FindByClass(item, "td", "upgrade_building b_farm").InnerText),
                                Storage = int.Parse(FindByClass(item, "td", "upgrade_building b_storage").InnerText),
                                Hide = int.Parse(FindByClass(item, "td", "upgrade_building b_hide").InnerText),
                                Wall = int.Parse(FindByClass(item, "td", "upgrade_building b_wall").InnerText),
                            };
                            Villages.Add(new Village()
                            {
                                Name = nejm,
                                Points = int.Parse(item.GetElementsByTagName("td")[3].InnerHtml.Replace("<span class=\"grey\">.</span>", "")),
                                buildings = bld,
                                villageSettings = apppSettings,
                                resources = new Resources(),
                                units = new Units(),
                                //App vars
                                //Active = false
                            });
                    }
                    else // so this village arleday existed
                    {
                        int existingvillageidx = Villages.IndexOf(matches.ToArray()[0]);
                        Villages[existingvillageidx].Points = int.Parse(item.GetElementsByTagName("td")[3].InnerHtml.Replace("<span class=\"grey\">.</span>", ""));
                        Villages[existingvillageidx].buildings.Main = int.Parse(FindByClass(item, "td", "upgrade_building b_main").InnerText);
                        Villages[existingvillageidx].buildings.Barracks = int.Parse(FindByClass(item, "td", "upgrade_building b_barracks").InnerText);
                        Villages[existingvillageidx].buildings.Stable = int.Parse(FindByClass(item, "td", "upgrade_building b_stable").InnerText);
                        Villages[existingvillageidx].buildings.Garage = int.Parse(FindByClass(item, "td", "upgrade_building b_garage").InnerText);
                        Villages[existingvillageidx].buildings.Church = int.Parse(FindByClass(item, "td", "upgrade_building b_church_f").InnerText); // upgrade_building b_church << you know what to do
                        Villages[existingvillageidx].buildings.Watchtower = int.Parse(FindByClass(item, "td", "upgrade_building b_watchtower").InnerText);
                        Villages[existingvillageidx].buildings.Snob = int.Parse(FindByClass(item, "td", "upgrade_building b_watchtower").InnerText);
                        Villages[existingvillageidx].buildings.Smith = int.Parse(FindByClass(item, "td", "upgrade_building b_smith").InnerText);
                        Villages[existingvillageidx].buildings.Place = int.Parse(FindByClass(item, "td", "upgrade_building b_place").InnerText);
                        Villages[existingvillageidx].buildings.Statue = int.Parse(FindByClass(item, "td", "upgrade_building b_statue").InnerText);
                        Villages[existingvillageidx].buildings.Market = int.Parse(FindByClass(item, "td", "upgrade_building b_market").InnerText);
                        Villages[existingvillageidx].buildings.Wood = int.Parse(FindByClass(item, "td", "upgrade_building b_wood").InnerText);
                        Villages[existingvillageidx].buildings.Stone = int.Parse(FindByClass(item, "td", "upgrade_building b_stone").InnerText);
                        Villages[existingvillageidx].buildings.Iron = int.Parse(FindByClass(item, "td", "upgrade_building b_iron").InnerText);
                        Villages[existingvillageidx].buildings.Farm = int.Parse(FindByClass(item, "td", "upgrade_building b_farm").InnerText);
                        Villages[existingvillageidx].buildings.Storage = int.Parse(FindByClass(item, "td", "upgrade_building b_storage").InnerText);
                        Villages[existingvillageidx].buildings.Hide = int.Parse(FindByClass(item, "td", "upgrade_building b_hide").InnerText);
                        Villages[existingvillageidx].buildings.Wall = int.Parse(FindByClass(item, "td", "upgrade_building b_wall").InnerText);
                        Villages[existingvillageidx].villageSettings.Link = FindByClass(item, "span", "quickedit-content").GetElementsByTagName("a")[0].GetAttribute("href").Replace("&screen=main", "");
                    }
                }
                UpdateVillageList(Villages);
            }
            else if(CefWebBrowser.Address.Contains("village") && CefWebBrowser.Address.Contains("overview"))
            {
                //MessageBox.Show("You are not on overview screen. Bot will add only one village."); production thing
                GatherVillages();
            }
            else
            {
                MessageBox.Show("Couldnt find any villages. Make sure WWW screen is opened at overview tab, and inside \"buildings\" tab is selected");
            }
        }
        //New village scraping methods
        public async void GatherVillages()
        {
            VillageWorker vw = new VillageWorker();
            List<Village> villgs = await vw.GatherVillageData(new string[] { CefWebBrowser.Address });
            Villages = villgs;
            UpdateVillageList(Villages);
        }
        public async Task<Village> GatherVillageData(string url)
        {

            return null;
        }

        //Update villages detailed stats
        private void Updatecitybutt_Click(object sender, EventArgs e)
        {
            //if (CityReader.IsBusy != true)
            //{
            //    CityReader.RunWorkerAsync();
            //}
        }
        //Update village list at Villages tab.
        public void UpdateVillageList(List<Village> wioski)
        {
            villageslist.Items.Clear();
            for (int i = 0; i < wioski.Count; i++)
            {
                var row = new string[] {
                        i.ToString(),
                        wioski[i].Name,
                        wioski[i].Points.ToString(),
                        wioski[i].buildings.Main.ToString(),
                        wioski[i].buildings.Barracks.ToString(),
                        wioski[i].buildings.Stable.ToString(),
                        wioski[i].buildings.Garage.ToString(),
                        wioski[i].buildings.Church.ToString(),
                        wioski[i].buildings.Watchtower.ToString(),
                        wioski[i].buildings.Snob.ToString(),
                        wioski[i].buildings.Smith.ToString(),
                        wioski[i].buildings.Place.ToString(),
                        wioski[i].buildings.Statue.ToString(),
                        wioski[i].buildings.Market.ToString(),
                        wioski[i].buildings.Wood.ToString(),
                        wioski[i].buildings.Stone.ToString(),
                        wioski[i].buildings.Iron.ToString(),
                        wioski[i].buildings.Farm.ToString(),
                        wioski[i].buildings.Storage.ToString(),
                        wioski[i].buildings.Hide.ToString(),
                        wioski[i].buildings.Wall.ToString()
                    };
                var lvi = new ListViewItem(row);
                villageslist.Items.Add(lvi);
                lvi.UseItemStyleForSubItems = false;
                if(wioski[0].villageSettings.Active)lvi.SubItems[0].BackColor = Color.Green;  
                    else lvi.SubItems[0].BackColor = Color.Yellow;
            }
            villagedatelabel.Text = DateTime.Now.ToString();
        }

        //Appering context menu after right click on an item on villagelist (list view)
        private void villageslist_MouseDown(object sender, MouseEventArgs e)
        {
            bool match = false;

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                foreach (ListViewItem item in villageslist.Items)
                {
                    if (item.Bounds.Contains(new Point(e.X, e.Y)))
                    {
                        //MenuItem[] mi = new MenuItem[] { new MenuItem("Hello"), new MenuItem("World"), new MenuItem(item.Name) };
                        //villageslist.ContextMenu = new ContextMenu(mi);
                        match = true;
                        
                        //dlt
                        villageslist.FocusedItem = item;
                        ctmenu.Show(villageslist, new Point(e.X, e.Y));
                        break;
                    }
                }
            }
        }


        #region Reading villages details worker methods
        //Reading villages worker tasks
        private void WorkerReadDetailCities(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            
            for (int i = 1; i < Villages.Count; i++)
            {
                try
                {
                    // This is how you force your logic to be called on the main
                    // application thread
                    var test = WebBrowserReadyState.Uninitialized;
                    
                    while (true)
                    {
                        WorkerBrowser1.Invoke((Action)(() => { test = WorkerBrowser1.ReadyState; }));
                        if(test == WebBrowserReadyState.Complete)
                        {
                            MessageBox.Show(test.ToString());
                            break;
                        }
                    }
                    worker.ReportProgress(i+1);
                    Villages[i].resources.Wood = int.Parse(WorkerBrowser1.Document.GetElementById("wood").InnerText);
                    Villages[i].resources.Stone = int.Parse(WorkerBrowser1.Document.GetElementById("stone").InnerText);
                    Villages[i].resources.Iron = int.Parse(WorkerBrowser1.Document.GetElementById("iron").InnerText);
                    if (worker.CancellationPending == true) // not implemented
                    {
                        e.Cancel = true;
                        break;
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
              
            }
        }
        // Not implemented progress event
        private void WorkerReadDetailCitiesProgress(object sender, ProgressChangedEventArgs e)
        {
            wbextended.Navigate("plemiona link");
            MessageBox.Show("One city readed");
        }

        //Finished reading cities details
        private void WorkerReadDetailCitiesFinished(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                //to implement
            }
            else if (e.Error != null)
            {
                //to implement
            }
            else
            {
                //to implement
            }
        }



        #endregion

        //???
        private void WWWtabnew_Click(object sender, EventArgs e)
        {

        }

        private void buildtest_Click(object sender, EventArgs e)
        {
            BuildVillages(null,null);
        }
        private async void BuildVillages(object sender, EventArgs e)
        {
            Task.Run(BuildVillages);
        }
        private async Task BuildVillages()
        {
            BuildWorker BW = new BuildWorker();
            List<Village> villgs = await BW.BuildVillages(Villages);
            Villages = villgs;
            UpdateVillageList(Villages); // is good here?
        }
        private void Buildingcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (Buildingcheck.Checked)
            {
                BuildTimer.Interval = int.Parse(Buildintervalbox.Text)*1000;
                BuildTimer.Start();
            }
            else
            {
                BuildTimer.Stop();
            }

        }
    }

}
