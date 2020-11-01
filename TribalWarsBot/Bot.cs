using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace TribalWarsBot
{
    class Bot
    {
        Village village; // actuall isnpected village
        List<Village> villages; // all player villages
        IWebDriver driver;
        //Timers
        System.Timers.Timer buildtimer;
        System.Timers.Timer farmtimer;
        //Help variables
        //Overall
        public List<string> BotOrdersQueue = new List<string>();
            //Building
        public bool ManageBuilding;  // is bot allowed to manage buildings
        bool managingbuildings = false; // is bot managing buildings RN
        List<string> buildqueue;
            //Farming
        public bool FarmingEnabled;
        public bool farming = false;
        public List<ListViewItem> FarmTargets;
        public int actualFarmTarget = 0;


        Form1 mainform;


        //TODO Pass list of villages
        public Bot(Village village, IWebDriver driver, Form1 mainform)
        {
            mainform.ChangeLabel("Gathering info..", Color.Yellow, Form1.MainLabels.BotStatus);

            //Assing variables
            buildtimer = new System.Timers.Timer();
            farmtimer = new System.Timers.Timer();
            FarmTargets = mainform.farmsettings.GetFarmList();
            this.mainform = mainform;
            ManageBuilding = mainform.GetCheckBox(Form1.MainCheckBoxes.Build);
            this.driver = driver;
            this.village = village;

            //Navigate to main screen
            if (driver.Url.Contains("overview")) village.UpdateResourcesOverview();
            string actaullurl = driver.Url;
            if (actaullurl.Contains("overview&intro")) { actaullurl = actaullurl.Replace("overview&intro", "main"); }
            else
            {
                actaullurl = actaullurl.Replace("overview", "main");
            }
            driver.Navigate().GoToUrl(actaullurl);
            village.UpdateResourcesMain();


            //Start timer which managing building
            if (buildtimer.Interval == 100) buildtimer.Interval = 1000;
            buildtimer.Elapsed += BuildCheck;
            buildtimer.AutoReset = true;
            buildtimer.Enabled = true;

            //Start timer which managing farm
            if (farmtimer.Interval == 100) farmtimer.Interval = 1000;
            farmtimer.Elapsed += FarmCheck;
            farmtimer.AutoReset = true;
            farmtimer.Enabled = true;

            mainform.ChangeLabel("Working!", Color.Green, Form1.MainLabels.BotStatus);


        }

        private void FarmCheck(object sender, ElapsedEventArgs e)
        {
            FarmingEnabled = mainform.GetCheckBox(Form1.MainCheckBoxes.Farm);
            if (!FarmingEnabled)
            {
                if (!ManageBuilding) mainform.ChangeLabel("NO TASK", Color.White, Form1.MainLabels.BotTask);
            }else
            if (!managingbuildings && !farming)
            {
                Farm(village);
            }
            else
            {
                farmtimer.Interval = 1000;
            }
        }

        private void BuildCheck(object sender, ElapsedEventArgs e)
        {
            ManageBuilding = mainform.GetCheckBox(Form1.MainCheckBoxes.Build);
            if (!ManageBuilding)
            {
                if(!FarmingEnabled) mainform.ChangeLabel("NO TASK", Color.White, Form1.MainLabels.BotTask);
            }else
            if (!managingbuildings && !farming)
            {
                ManageBuildings(village);
            }
            else
            {
                buildtimer.Interval = 1000;
            }
        }

        void Farm(Village vill)
        {
            farming = true;
            mainform.ChangeLabel("Farming", Color.Yellow, Form1.MainLabels.BotTask);
            if (vill != village)
            {
                //navigate to correct village
            }
            //Navigate to attack pannel
            string actuallurl = driver.Url;
            int idx = actuallurl.IndexOf("screen") + 6;
            actuallurl = actuallurl.Substring(0, idx + 1) + "place";
            driver.Navigate().GoToUrl(actuallurl);
            //
            string[,] attackgroup = mainform.farmsettings.GetFarmGroups();
            //check every attack group (to be added)
            for (int i = 0; i < attackgroup.GetLength(0); i++)
            {
                string avaiable = driver.FindElement(By.Id($"units_entry_all_{attackgroup[i, 0]}")).Text;
                int avaiableAmount = int.Parse(avaiable.Substring(1, avaiable.Length - 2));
                if (avaiableAmount < int.Parse(attackgroup[i, 1]))
                {
                    farmtimer.Interval = 300 * 1000;
                    farming = false;
                    return;
                }   
                driver.FindElement(By.Id($"unit_input_{attackgroup[i, 0]}")).SendKeys(attackgroup[i, 1]);
            }
            try
            {
                var target = FarmTargets[actualFarmTarget];
                driver.FindElement(By.XPath("//*[@id=\"place_target\"]/input")).SendKeys($"{FarmTargets[actualFarmTarget].SubItems[1]}|{FarmTargets[actualFarmTarget].SubItems[2]}");
                driver.FindElement(By.Id("target_attack")).Click();
                driver.FindElement(By.Id("troop_confirm_go")).Click();  
                actualFarmTarget++;
                if (actualFarmTarget >= FarmTargets.Count) actualFarmTarget = 0;
            }
            catch(Exception ex)
            {

            }

            farming = false;
        }

        public int ideksik;
        //main method to decide what bot should build
        void ManageBuildings(Village vill)
        {
            managingbuildings = true;
            //to delete, temp try for debug 
            try
            {
                mainform.ChangeLabel("Building", Color.Yellow, Form1.MainLabels.BotTask);
            }
            catch (Exception ex)
            {
            }

            //if (!ManageBuilding) return; unnecessary?
            if (vill != village)
            {
                //navigate to correct village
            }
            //Check if queue is not full
            string actuallurl = driver.Url;
            int idx = actuallurl.IndexOf("screen") +6 ;
            actuallurl = actuallurl.Substring(0, idx + 1) + "main";
            driver.Navigate().GoToUrl(actuallurl);
            village.UpdateResourcesMain();
            //TODO Add checking when queue will be empty then apply to timer
            try //catch is happen when theres no buildings in queue
            {
                if (driver.FindElement(By.Id("build_queue")) != null)
                {
                    List<IWebElement> queueelements = new List<IWebElement>(driver.FindElement(By.Id("build_queue")).FindElements(By.TagName("tr")));
                    if (queueelements.Count > 3)
                    {
                        mainform.ChangeLabel("Place in build queue", Color.Black, Form1.MainLabels.Missing);
                        buildtimer.Interval = 300 * 1000; //TODO rework
                        return; // cuz of no place in queue
                    }
                }
            }
            catch(Exception ex)
            {
            }
            string[] buildorder = StaticVariables.BuildOrder;
            List<order> helplist = new List<order>(); // keeping levels needed to be

            for (int i = 0; i < buildorder.Length; i++)
            {
                bool founded = false;
                int mainorderidx = 0;
                foreach (order ord in helplist)
                {

                    if (ord.buildid == buildorder[i])
                    {
                        ord.level++;
                        founded = true;
                        mainorderidx = helplist.IndexOf(ord);
                        break;
                    }
                }
                if (!founded)
                {
                    helplist.Add(new order() { buildid = buildorder[i], level = 1 });
                    mainorderidx = helplist.Count - 1;
                }
                order mainorder = helplist[mainorderidx];
                foreach (Building build in vill.buildings)
                {
                    if (mainorder.buildid == build.name)
                    {
                        mainform.ChangeLabel(StaticVariables.BuildingIDtoName(build.name), Color.Black, Form1.MainLabels.Bulding);
                       if (build.level < mainorder.level)
                        {

                            if (build.nlclay < vill.stone && build.nliron < vill.iron && build.nlpop < (vill.popCapMax - vill.popCap) && build.nlwood < vill.wood)
                                        {
                                            
                                            Build(mainorder.buildid, mainorder.level);
                                            buildtimer.Interval = 10000;
                                            return;
                                        }
                                        else
                                        {
                                            mainform.ChangeLabel("Resources", Color.OrangeRed, Form1.MainLabels.Missing);
                                            //Calculate time to avaibilty
                                            try
                                            {
                                                string timetoavastring = driver.FindElement(By.Id(mainorder.buildid)).FindElement(By.ClassName("inactive")).Text;
                                                int middle = timetoavastring.IndexOf(':');
                                                timetoavastring = timetoavastring.Substring(middle - 2, 5);
                                                DateTime timeToAva = DateTime.Parse(timetoavastring);
                                                TimeSpan time = timeToAva - DateTime.Now;
                                                buildtimer.Interval = time.TotalSeconds > 300 ? 300 * 1000 : time.TotalMilliseconds;
                                            }
                                        
                                            catch(Exception ex)
                                            {
                                                buildtimer.Interval = 10000;
                                            }

                                            managingbuildings = false; // not enough resources
                                            return;
                                        }
                        }
                        else break;

                    }
                }
            }
        }

        private void Build(string buildid , int level)
        {
            //getting build url
            string actuallurl = driver.Url;
            int idx = actuallurl.IndexOf("screen") + 6;
            actuallurl = actuallurl.Substring(0, idx + 1) + "main";

            //getting right id for button
            string tmpbuildid = buildid;
            int idxbuildfirst = buildid.IndexOf('_');
            int idxbuildsecond = buildid.LastIndexOf('_');
            string tmpsub = buildid.Substring(idxbuildfirst + 1, idxbuildsecond-idxbuildfirst-1);
            tmpbuildid = tmpbuildid.Replace(tmpsub, "buildlink");
            //do

            driver.Navigate().GoToUrl(actuallurl);
            try
            {
                driver.FindElement(By.Id(buildid)).FindElement(By.Id(tmpbuildid + "_" + level)).Click();
            }catch ( Exception ex)
            {
                try
                {
                    driver.FindElement(By.Id(buildid)).FindElement(By.Id(tmpbuildid + "_" + (level + 1))).Click();
                }
                catch (Exception ex2)
                {
                    managingbuildings = false;
                }
            }

            managingbuildings = false;
        }

    }
    public class order
    {
        public string buildid;
        public int level = 0;
    }
}
