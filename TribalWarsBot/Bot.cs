using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
        System.Timers.Timer buildtimer;

        public bool ManageBuilding; //TODO manage by checkbox
        bool managingbuildings = false;
        CheckBox mngBuildings;
        List<string> queue;
        public Bot(Village village, IWebDriver driver , CheckBox mngbuildings)
        {
            this.mngBuildings = mngbuildings;
            ManageBuilding = mngBuildings.Checked;
            this.driver = driver;
            this.village = village;
            if (driver.Url.Contains("overview")) village.UpdateResourcesOverview();
            string actaullurl = driver.Url;
            if (actaullurl.Contains("overview&intro")) { actaullurl = actaullurl.Replace("overview&intro", "main"); }
            else
            {
                actaullurl = actaullurl.Replace("overview", "main");
            }

            driver.Navigate().GoToUrl(actaullurl);
            village.UpdateResourcesMain();
            if(ManageBuilding)ManageBuildings(village);//TODO change it


            buildtimer = new System.Timers.Timer();
            buildtimer.Interval = 10000;
            buildtimer.Elapsed += BuildCheck;
            buildtimer.AutoReset = true;
            buildtimer.Enabled = true;

        }

        private void BuildCheck(object sender, ElapsedEventArgs e)
        {
            ManageBuilding = mngBuildings.Checked;
            if (!managingbuildings)ManageBuildings(village);
        }

        void ManageBuildings(Village vill)
        {
            if (!ManageBuilding) return;
            if (vill != village)
            {
                //navigate to correct village
            }
            //Check if queue is not full
            string actuallurl = driver.Url;
            int idx = actuallurl.LastIndexOf('=');
            actuallurl = actuallurl.Substring(0, idx + 1) + "main";
            driver.Navigate().GoToUrl(actuallurl);
            village.UpdateResourcesMain();
            //
            try
            {
                if (driver.FindElement(By.Id("build_queue")) != null)
                {
                    List<IWebElement> queueelements = new List<IWebElement>(driver.FindElement(By.Id("build_queue")).FindElements(By.TagName("tr")));
                    if (queueelements.Count > 3)
                    {
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
                        if (build.level < mainorder.level)
                        {

                            if (build.nlclay < vill.stone && build.nliron < vill.iron && build.nlpop < (vill.popCapMax - vill.popCap) && build.nlwood < vill.wood)
                                        {
                                            Build(mainorder.buildid, mainorder.level);
                                            return;
                                        }
                                        else
                                        {
                                            managingbuildings = false; // not enough resources
                                            //calcualte remaining time to resources
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
            int idx = actuallurl.LastIndexOf('=');
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
