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
        Village rc = null;
        Bot bot = null;
        System.Timers.Timer aTimer;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //RunBOT 
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--incognito");
            IWebDriver driver = new ChromeDriver("./", options);
            driver.Navigate().GoToUrl(StaticVariables.TribalWarsURL);
            if (autologin.Checked)
            {
                driver.FindElement(By.Id("user")).SendKeys(usernamebox.Text);
                driver.FindElement(By.Id("password")).SendKeys(passwordbox.Text);
                var pagecontent = driver.PageSource;
                driver.FindElement(By.ClassName("btn-login")).Click();
                while (pagecontent == driver.PageSource)
                {
                    //wait effect
                }
                checkforworlds:
                List<IWebElement> activeworlds = new List<IWebElement>(driver.FindElements(By.ClassName("world_button_active")));
                if(activeworlds.Count == 0) {
                    goto checkforworlds;
                }
                bool worldlocated = false;
                foreach (IWebElement element in activeworlds)
                {
                    string worldnumber = element.Text;
                    if (-1<worldnumber.IndexOf(WorldNumberBox.Text))
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
                //Enabling resourcetracker
                rc = new Village(driver);
                rc.UpdateResources();
                bot = new Bot(rc, driver , BuildingsManageBox);

                aTimer = new System.Timers.Timer();
                aTimer.Interval = 2000;
                aTimer.Elapsed += OnTimedEvent;
                aTimer.AutoReset = true;
                aTimer.Enabled = true;
            }
            else
            {
                MessageBox.Show("You have 15 seconds to log in");
                Thread.Sleep(15000);
            }


        }
        private  void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            rc.UpdateResources();
        }


    }
}
