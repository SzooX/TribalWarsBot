using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
//using System.Threading;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using TribalWars.Workers;
using Newtonsoft.Json.Linq;

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
        ContextMenuStrip ctmenufarm = new ContextMenuStrip(); // context menu for villagefarmlist
        ContextMenuStrip TabContextMenu = new ContextMenuStrip(); // context menu for maintabcontrol . To be added
        //
        ChromiumWebBrowser CefWebBrowser;
        public List<BuildPreset> BuildPresets = new List<BuildPreset>();
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
            //Settuping farmlist
            #region Farmlist and its context menu
            ctmenufarm.ImageList = ContextMenuImgs;
            //villageslist.ContextMenuStrip = ctmenu;
            item1 = new ToolStripMenuItem();
            item1.Name = "Set active";
            item1.Text = "Set active";
            item1.ImageIndex = 0;
            item1.Click += FarmListContextMenuClick;
            item2 = new ToolStripMenuItem();
            item2.Name = "Disable";
            item2.Text = "Disable";
            item2.ImageIndex = 1;
            item2.Click += FarmListContextMenuClick;
            item3 = new ToolStripMenuItem();
            item3.Name = "Configure";
            item3.Text = "Configure";
            item3.ImageIndex = 2;
            item3.Click += FarmListContextMenuClick;
            item4 = new ToolStripMenuItem();
            item4.Margin = new Padding(0, 10, 0, 0);
            item4.Name = "Remove";
            item4.Text = "Remove";
            item4.ImageIndex = 3;
            item4.Click += FarmListContextMenuClick;
            ctmenufarm.Items.Add(item1);
            ctmenufarm.Items.Add(item2);
            ctmenufarm.Items.Add(item3);
            ctmenufarm.Items.Add(item4);
            #endregion
            //

            //Bot timer
            Timer bottime = new Timer();
            bottime.Tick += new EventHandler(UpdateBotTime);
            bottime.Interval = 1;
            bottime.Start();
            //Build timer
            BuildTimer.Tick += new EventHandler(BuildVillages);
            BuildPresets.Add(DefaultBuildPresets.Eko);
        }

        //maintab click handler
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
        private void UpdateBotTime(object sender, EventArgs e)
        {
            bottime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff", CultureInfo.InvariantCulture);
        }
        //logging
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
        //starting 
        private void botstartbtt_Click(object sender, EventArgs e)
        {
            if(CefWebBrowser.Address != panelbox.Text)CefWebBrowser.Load(panelbox.Text);
            else
            {
                LoginPageLoaded(CefWebBrowser, new LoadingStateChangedEventArgs(null, false, false , false));
                return;
            }
            CefWebBrowser.LoadingStateChanged += LoginPageLoaded;
        }
        
        //Add villages
        private async void addcitybutt_Click(object sender, EventArgs e)
        {
            var script = @"document.getElementById(""production_table"") != null";
            var response = await CefWebBrowser.EvaluateScriptAsync(script);
            if(response.Result != null)if ((bool)response.Result)
            {
                    List<RawVillage> rv = new List<RawVillage>();

                    script = $@"(function(){{
    var response = {{
        Villages: []
    }}
    var v = [];
    var trs = document.getElementById(""production_table"").getElementsByTagName(""tbody"")[0].getElementsByTagName(""tr"");
    for(i = 1; i < trs.length; i++){{
        v[i-1] =
        {{
        Points: trs[i].getElementsByTagName(""td"")[1].innerText,
        Link: trs[i].getElementsByTagName(""td"")[0].getElementsByTagName(""span"")[0].getElementsByTagName(""span"")[0].getElementsByTagName(""a"")[0].getAttribute(""href"")
        }}
    }}
    response.Villages = v;
    return JSON.stringify(response);
}})();";
                    response = await CefWebBrowser.EvaluateScriptAsync(script);
                    JObject res = JsonConvert.DeserializeObject<JObject>(response.Result.ToString());
                    List<JToken> rl = res.Children<JToken>().ToList()[0].Children<JToken>().ToList()[0].Children().ToList();
                    for (int i = 0; i < rl.Count; i++)
                    {
                        string s = JsonConvert.SerializeObject(rl[i]);
                        rv.Add(JsonConvert.DeserializeObject<RawVillage>(s));
                    }
                    List<string> adrs = new List<string>();
                    for (int i = 0; i < rv.Count; i++)
                    {
                        adrs.Add(rv[i].Link);
                    }
                    GatherVillages(adrs.ToArray());
            }
            else if(CefWebBrowser.Address.Contains("village") && CefWebBrowser.Address.Contains("overview"))
            {
                //MessageBox.Show("You are not on overview screen. Bot will add only one village."); production thing
                script = $@"(function(){{
    return document.getElementsByClassName(""nowrap tooltip-delayed"")[0].getAttribute(""href"")
}})();";
                response = await CefWebBrowser.EvaluateScriptAsync(script);
                GatherVillages(new string[] { response.Result.ToString() });
            }
            else
            {
                MessageBox.Show("Couldnt find any villages. Make sure WWW screen is opened at overview tab, and inside \"buildings\" tab is selected");
            }
        }
        //New village scraping methods
        public async void GatherVillages(string[] adresses)
        {
            string mainurl = CefWebBrowser.Address.Substring(0, CefWebBrowser.Address.IndexOf('/', 11));
            VillageWorker vw = new VillageWorker();
            List<Village> villgs = await vw.GatherVillageData( mainurl,adresses);
            Villages = villgs;
            UpdateVillageList(Villages);
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
            //village list building
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
            //village list farm
            VillagesFarmList.Items.Clear();
            for (int i = 0; i < wioski.Count; i++)
            {
                if (wioski[i].farming == null)
                {
                    wioski[i].farming = new Farming();
                    wioski[i].farming.FarmTargets = new List<TargetVillage>();
                    wioski[i].farming.UnitPackages = new List<FarmPackage>();
                }
                int activeones = 0;
                foreach (var item in wioski[i].farming.FarmTargets)
                {
                    if (item.Active) activeones++;
                }
                string UnitPackages = "";
                foreach (var item in wioski[i].farming.UnitPackages)
                {
                    UnitPackages += item.Name + " ";
                }
                var row = new string[] {
                        i.ToString(),
                        wioski[i].Name,
                        wioski[i].farming.FarmTargets.Count.ToString(),
                        activeones.ToString(),
                        UnitPackages
                    };
                var lvi = new ListViewItem(row);
                VillagesFarmList.Items.Add(lvi);
                lvi.UseItemStyleForSubItems = false;
                if (wioski[0].farming.Active) lvi.SubItems[0].BackColor = Color.Green;
                else lvi.SubItems[0].BackColor = Color.Yellow;

            }
            
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
        private void VillagesContextMenuClick(object sender, EventArgs e)
        {
            //active / deactive 
            ToolStripItem itm = sender as ToolStripItem;
            var match = Villages.Find((v) => v.Name == villageslist.FocusedItem.SubItems[1].Text);
            if (itm.Text == "Set active")
            {
                if (match.BuildQueue != null)
                {
                    if (match.buildSettings.AnyOption() == true) match.villageSettings.Active = true;
                    else MessageBox.Show("Cannot set active village without queue or buildsettings");
                }
                else MessageBox.Show("Cannot set active village without queue or buildsettings");
            }
            else if (itm.Text == "Disable")
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
        //Appering context menu after right click on an item on farmlist (list view)
        private void farmlist_MouseDown(object sender, MouseEventArgs e)
        {
            bool match = false;

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                foreach (ListViewItem item in VillagesFarmList.Items)
                {
                    if (item.Bounds.Contains(new Point(e.X, e.Y)))
                    {
                        //MenuItem[] mi = new MenuItem[] { new MenuItem("Hello"), new MenuItem("World"), new MenuItem(item.Name) };
                        //villageslist.ContextMenu = new ContextMenu(mi);
                        match = true;

                        //dlt
                        VillagesFarmList.FocusedItem = item;
                        ctmenufarm.Show(VillagesFarmList, new Point(e.X, e.Y));
                        break;
                    }
                }
            }
        }
        private void FarmListContextMenuClick(object sender, EventArgs e)
        {
            ToolStripItem itm = sender as ToolStripItem;
            Village match = null;
            match = Villages.Find((v) => v.Name == VillagesFarmList.FocusedItem.SubItems[0].Text); 
            if (itm.Text == "Set active")
            {
                
                if (match.farming.FarmTargets.Count > 0 && match.farming.UnitPackages.Count > 0)
                {
                    MessageBox.Show("Cannot set active village without fart targets or farm packages");
                }
                else MessageBox.Show("Cannot set active village without fart targets or farm packages");
            }
            else if (itm.Text == "Disable")
            {
                match.farming.Active = false;
            }
            else if (itm.Text == "Configure")
            {
                MessageBox.Show("not yet boi");
            }
            else if (itm.Text == "Remove")
            {
                Villages.Remove(match);
            }
            UpdateVillageList(Villages);
        }

        //Building
        private void buildtest_Click(object sender, EventArgs e)
        {
            BuildVillages(null,null);
        } // test method
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

        //Farming
    }
    public class RawVillage
    {
        public string Points { get; set; }
        public string Link { get; set; }
    }
}
