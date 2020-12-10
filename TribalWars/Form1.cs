using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TribalWars
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeBrowserEvents(wbextended);
            Timer bottime = new Timer();
            bottime.Tick += new EventHandler(UpdateBotTime);
            bottime.Interval = 1;
            bottime.Start();
        }
        private void UpdateBotTime(object sender, EventArgs e)
        {
            bottime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff",  CultureInfo.InvariantCulture);
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
            SourceBrowser.NewWindow2 += new EventHandler<NewWindow2EventArgs>(SourceBrowser_NewWindow2);
        }

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

        public void LoginPageLoaded(object sender, EventArgs e)
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
            wbextended.DocumentCompleted -= LoginPageLoaded;
        }
        private void botstartbtt_Click(object sender, EventArgs e)
        {
            wbextended.Navigate(panelbox.Text);
            wbextended.DocumentCompleted += LoginPageLoaded; 
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

    }
}
