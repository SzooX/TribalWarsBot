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
using System.Xml;
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
        //
        public int MaxFarmDistance;
        //public List<List<string>> BuildOrders; rework (missing place for order name)
        public List<FarmTarget> FarmTargetsList = new List<FarmTarget>();
        public List<FarmPreset> FarmPresetsList = new List<FarmPreset>();



        //forms
        public Form2 farmsettings = new Form2();

        //Configs
        public XmlDocument buildorderConfig = new XmlDocument();
        public XmlDocument MainConfig = new XmlDocument();
        public XmlDocument FarmTargets = new XmlDocument();
        public XmlDocument FarmPresets = new XmlDocument();
        public Form1()
        {
            InitializeComponent();



            //Loading configs

            if (!System.IO.Directory.Exists("Configs")) System.IO.Directory.CreateDirectory("Configs");

            
            try//loading build order config
            {

                buildorderConfig.Load("Configs/BuildOrders.xml");
            } catch (Exception ex) //no config file
            {
                //Creating default xml file
                XmlDeclaration declaration = buildorderConfig.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = buildorderConfig.DocumentElement;
                buildorderConfig.InsertBefore(declaration, root);

                //creating body
                //1 LEVEL
                XmlElement element1 = buildorderConfig.CreateElement(string.Empty, "BuildOrders", string.Empty);
                buildorderConfig.AppendChild(element1);
                //2LEVEL
                XmlElement element2 = buildorderConfig.CreateElement(string.Empty, "BuildOrder", string.Empty);
                element2.SetAttribute("name", "ExampleBuildOrder");
                element1.AppendChild(element2);
                //3 level (orders)
                for (int i = 0; i < StaticVariables.BuildOrder.Length; i++)
                {
                    XmlElement element3 = buildorderConfig.CreateElement(string.Empty, "Order", string.Empty);
                    XmlText text1 = buildorderConfig.CreateTextNode(StaticVariables.BuildOrder[i]);
                    element3.AppendChild(text1);
                    element2.AppendChild(element3);
                }
                buildorderConfig.Save("Configs/BuildOrders.xml");
            }
            try//loading bot config
            {
                MainConfig.Load("Configs/MainConfig.xml");
            }
            catch (Exception ex) //no config file
            {
                //Creating default xml file
                XmlDeclaration declaration = MainConfig.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = MainConfig.DocumentElement;
                MainConfig.InsertBefore(declaration, root);

                //creating body
                //1 LEVEL
                XmlElement element1 = MainConfig.CreateElement(string.Empty, "BotConfig", string.Empty);
                MainConfig.AppendChild(element1);
                //2LEVEL
                //username
                XmlElement element2 = MainConfig.CreateElement(string.Empty, "Username", string.Empty);
                XmlText text1 = MainConfig.CreateTextNode("");
                element2.AppendChild(text1);
                element1.AppendChild(element2);
                //password
                XmlElement element3 = MainConfig.CreateElement(string.Empty, "Password", string.Empty);
                XmlText text2 = MainConfig.CreateTextNode("");
                element3.AppendChild(text2);
                element1.AppendChild(element3);
                //world
                XmlElement element4 = MainConfig.CreateElement(string.Empty, "World", string.Empty);
                XmlText text3 = MainConfig.CreateTextNode("");
                element4.AppendChild(text3);
                element1.AppendChild(element4);
                //Farm variables
                XmlElement element5 = MainConfig.CreateElement(string.Empty, "MaxFarmDistance", string.Empty);
                XmlText text4 = MainConfig.CreateTextNode("5");
                element5.AppendChild(text4);
                element1.AppendChild(element5);

                MainConfig.Save("Configs/MainConfig.xml");
            }
            try//loading farm targets config
            {
                FarmTargets.Load("Configs/FarmTargets.xml");
            }
            catch (Exception ex) //no config file
            {
                //Creating default xml file
                XmlDeclaration declaration = FarmTargets.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = FarmTargets.DocumentElement;
                FarmTargets.InsertBefore(declaration, root);

                //creating body
                //1 LEVEL
                XmlElement element1 = FarmTargets.CreateElement(string.Empty, "FarmTargets", string.Empty);
                FarmTargets.AppendChild(element1);
                //2LEVEL
                //targets
                XmlElement element2 = FarmTargets.CreateElement(string.Empty, "Targets", string.Empty);
                element1.AppendChild(element2);
                //target
                XmlElement element3 = FarmTargets.CreateElement(string.Empty, "Target", string.Empty);
                //element3.SetAttribute("name", "example");
                element2.AppendChild(element3);
                //target body
                XmlElement element4 = FarmTargets.CreateElement(string.Empty, "Name", string.Empty);
                XmlText text1 = FarmTargets.CreateTextNode("ExampleTarget");
                element4.AppendChild(text1);
                element3.AppendChild(element4);
                //
                element4 = FarmTargets.CreateElement(string.Empty, "YCord", string.Empty);
                text1 = FarmTargets.CreateTextNode("0");
                element4.AppendChild(text1);
                element3.AppendChild(element4);
                //
                element4 = FarmTargets.CreateElement(string.Empty, "XCord", string.Empty);
                text1 = FarmTargets.CreateTextNode("0");
                element4.AppendChild(text1);
                element3.AppendChild(element4);

                FarmTargets.Save("Configs/FarmTargets.xml");
            }
            try//loading farm targets config
            {
                FarmPresets.Load("Configs/FarmPresets.xml");
            }
            catch (Exception ex) //no config file
            {
                //Creating default xml file
                XmlDeclaration declaration = FarmPresets.CreateXmlDeclaration("1.0", "UTF-8", null);
                XmlElement root = FarmPresets.DocumentElement;
                FarmPresets.InsertBefore(declaration, root);

                //creating body
                //1 LEVEL
                XmlElement element1 = FarmPresets.CreateElement(string.Empty, "FarmPresets", string.Empty);
                FarmPresets.AppendChild(element1);
                //2LEVEL
                //targets
                XmlElement element2 = FarmPresets.CreateElement(string.Empty, "Presets", string.Empty);
                element1.AppendChild(element2);
                //target
                XmlElement element3 = FarmPresets.CreateElement(string.Empty, "Preset", string.Empty);
                element2.AppendChild(element3);
                //target body
                XmlElement element4 = FarmPresets.CreateElement(string.Empty, "Name", string.Empty);
                XmlText text1 = FarmPresets.CreateTextNode("ExamplePreset");
                element4.AppendChild(text1);
                element3.AppendChild(element4);
                //
                element4 = FarmPresets.CreateElement(string.Empty, "Order", string.Empty);
                text1 = FarmPresets.CreateTextNode("0");
                element4.AppendChild(text1);
                element3.AppendChild(element4);
                //
                element4 = FarmPresets.CreateElement(string.Empty, "Units", string.Empty);
                element3.AppendChild(element4);
                //Units
                for (int i = 0; i < StaticVariables.Units.Length; i++)
                {
                    XmlElement element5 = FarmPresets.CreateElement(string.Empty, "Unit", string.Empty);
                    element5.SetAttribute("name", StaticVariables.Units[i]);
                    text1 = FarmPresets.CreateTextNode((i < 2 ? 10 : 0).ToString());
                    element5.AppendChild(text1);
                    element4.AppendChild(element5);
                }
                FarmPresets.Save("Configs/FarmPresets.xml");
            }
                // Loading main xml file
            XmlNode node = MainConfig.SelectSingleNode("BotConfig");
            node = node.SelectSingleNode("Username");
            usernamebox.Text = node.ChildNodes[0] == null ? "" : node.ChildNodes[0].Value;
            node = MainConfig.SelectSingleNode("BotConfig");
            node = node.SelectSingleNode("Password");
            passwordbox.Text = node.ChildNodes[0] == null ? "" : node.ChildNodes[0].Value;
            node = MainConfig.SelectSingleNode("BotConfig");
            node = node.SelectSingleNode("World");
            WorldNumberBox.Text = node.ChildNodes[0] == null ? "" : node.ChildNodes[0].Value;
            node = MainConfig.SelectSingleNode("BotConfig");
            node = node.SelectSingleNode("MaxFarmDistance");
            MaxFarmDistance = int.Parse(node.ChildNodes[0] == null ? "" : node.ChildNodes[0].Value);
            //loading xml with orders
            //XXX problem with place for order name
            //node = buildorderConfig.SelectSingleNode("BuildOrders");
            //XmlNodeList nodes = node.SelectNodes("BuildOrder");
            //for (int i = 0; i < nodes.Count; i++)
            //{
            //    List<string> BuildOrder = 
            //}

            //Loading farm targets
            try
            {
                node = FarmTargets.SelectSingleNode("FarmTargets");
                node = node.SelectSingleNode("Targets");
                XmlNodeList nodes = node.SelectNodes("Target");
                for (int i = 0; i < nodes.Count; i++)
                {
                    FarmTargetsList.Add(new FarmTarget()
                    {
                        Name = nodes[i].SelectSingleNode("Name").ChildNodes[0].Value,
                        Ycorr = int.Parse(nodes[i].SelectSingleNode("YCord").ChildNodes[0].Value),
                        Xcorr = int.Parse(nodes[i].SelectSingleNode("XCord").ChildNodes[0].Value)

                    });
                }
            }catch(Exception ex)
            {
                throw new Exception("Problem with reading FarmTarget config file");
            }
            //Loading farm presets xml
            try
            {
                node = FarmPresets.SelectSingleNode("FarmPresets");
                node = node.SelectSingleNode("Presets");
                XmlNodeList nodes1 = node.SelectNodes("Preset");
                for (int i = 0; i < nodes1.Count; i++)
                {
                    List<FarmPresetUnit> flist = new List<FarmPresetUnit>();
                    XmlNode UnitsMain = nodes1[i].SelectSingleNode("Units");
                    XmlNodeList Units = UnitsMain.SelectNodes("Unit");
                    for (int f = 0; f < Units.Count; f++)
                    {
                        flist.Add(new FarmPresetUnit()
                        {
                            Count = int.Parse(Units[f].ChildNodes[0].Value),
                            Unitid = Units[f].Attributes["name"].Value
                        });
                    }
                    FarmPresetsList.Add(new FarmPreset()
                    {
                        Name = nodes1[i].SelectSingleNode("Name").ChildNodes[0].Value,
                        Order = int.Parse(nodes1[i].SelectSingleNode("Order").ChildNodes[0].Value),
                        Units = flist
                    });
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Problem with readin FarmPreset config file");
            }
            

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
    public class FarmTarget
    {
        public string Name;
        public int Ycorr;
        public int Xcorr;
    }
    public class FarmPreset
    {
        public string Name;
        public int Order;
        public List<FarmPresetUnit> Units;
    }
    public class FarmPresetUnit
    {
        public string Unitid;
        public int Count;
    }
}
