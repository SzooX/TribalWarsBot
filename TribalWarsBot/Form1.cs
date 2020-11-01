using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace TribalWarsBot
{
    public partial class Form1 : Form
    {
        //Safe thread iplementation
        private delegate void SafeCallDelegate(string text);
        private Thread thread2 = null;
        //
        Village villagefirst = null;
        Bot bot = null;
        System.Timers.Timer aTimer;
        IWebDriver driver;

        //forms
        public Form2 farmsettings = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //RunBOT 
        {
            BotStatusLabel.ForeColor = Color.Yellow;
            BotStatusLabel.Text = "Logging in";
            LogginIn();
        }
        public async void LogginIn()
        {
            //Launching browser
            try
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--incognito");
                driver = new ChromeDriver("./", options);
                driver.Navigate().GoToUrl(StaticVariables.TribalWarsURL);
                driver.Navigate().GoToUrl(StaticVariables.TribalWarsURL);
            }catch(Exception ex)
            {
                MessageBox.Show("Problem with launching chromedriver : " + ex);
                throw new Exception("Problem occured while launching chromedriver : " + ex);
            }
            
            if (autologin.Checked)
            {
                //logging
                try
                {
                    driver.FindElement(By.Id("user")).SendKeys(usernamebox.Text);
                    driver.FindElement(By.Id("password")).SendKeys(passwordbox.Text);
                    var pagecontent = driver.PageSource;
                    driver.FindElement(By.ClassName("btn-login")).Click();
                    int timeout = 10000;
                    while (pagecontent == driver.PageSource)
                    {
                        timeout--;
                        if (timeout < 0) {
                            BotStatusLabel.Text = "LOGIN IN FAILED";
                            BotStatusLabel.ForeColor = Color.Red;
                                }
                        }
                }
                catch(Exception ex)
                {
                    throw new Exception("Error while loggin in " + ex);
                }
                //Entering world
                try
                {
                checkforworlds:
                    List<IWebElement> activeworlds = new List<IWebElement>(driver.FindElements(By.ClassName("world_button_active")));
                    if (activeworlds.Count == 0)
                    {
                        goto checkforworlds;
                    }
                    bool worldlocated = false;
                    foreach (IWebElement element in activeworlds)
                    {
                        string worldnumber = element.Text;
                        if (-1 < worldnumber.IndexOf(WorldNumberBox.Text))
                        {
                            worldlocated = true;
                            element.Click();
                            break;
                        }
                    }
                    if (!worldlocated)
                    {
                        //throw error
                    }
                    //Enabling village
                    //TODO Find all villages
                    villagefirst = new Village(driver);
                    villagefirst.UpdateResources();
                    bot = new Bot(villagefirst, driver, this);
                    //Starting timer for update villages
                    aTimer = new System.Timers.Timer();
                    aTimer.Interval = 2000;
                    aTimer.Elapsed += OnTimedEvent;
                    aTimer.AutoReset = true;
                    aTimer.Enabled = true;
                }
                catch(Exception ex)
                {
                    throw new Exception("Problem while entering world" + ex);
                }
            }
            else
            {
                throw new NotImplementedException("Manual loggin feauture is disabled for now");
            }
        }
        //TODO Methhod for getting checkbox status
        public bool GetCheckBox(MainCheckBoxes checkbox)
        {
            switch (checkbox)
            {
                case MainCheckBoxes.Farm:
                    return FarmCheckBox.Checked;
                case MainCheckBoxes.Build:
                    return BuildingsManageBox.Checked;
                default:
                    throw new Exception("something went wrong");
            }
        }
        public void ChangeLabel(string text, Color color, MainLabels label)
        {
            Label targetlabel= null;
            switch (label)
            {
                case MainLabels.BotStatus:
                    targetlabel = BotStatusLabel;
                    break;
                case MainLabels.BotTask:
                    targetlabel = TaskLabel;
                    break;
                case MainLabels.Bulding:
                    targetlabel = BuildingLabel;
                    break;
                case MainLabels.Missing:
                    targetlabel = MissingLabel;
                    break;
                default:
                    break;
            }
            targetlabel.Invoke((MethodInvoker)delegate
            {
                targetlabel.Text = text ;
                targetlabel.ForeColor = color;
            });
            
        }
        
        public enum MainLabels
        {
            BotStatus,
            BotTask,
            Bulding,
            Missing
        }

        public enum MainCheckBoxes
        {
            Farm,
            Build
        }
        private  void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            //TODO update all villages
            villagefirst.UpdateResources();
        }

        private void button2_Click(object sender, EventArgs e) // Configure farming
        {
            
            farmsettings.Show();
        }
    }
}
