using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
namespace TribalWarsBot
{
    class Village
    {
        IWebDriver driver;

        string VillageName;
        //resources\\
        public int wood = 0;
        public int stone = 0;
        public int iron = 0;
        //resource income\\
        public int woodincome;
        public int stoneincome;
        public int ironincome;
        //limits\\
        int magazineSize = 1000;
        public int popCap = 0;
        public int popCapMax = 240;
        //Buildings\\
        #region buldings
        public List<Building> buildings = new List<Building>();
        #endregion

        public Village(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void UpdateResources()
        {
            
            wood = int.Parse(driver.FindElement(By.Id("wood")).Text);
            stone = int.Parse(driver.FindElement(By.Id("stone")).Text);
            iron = int.Parse(driver.FindElement(By.Id("iron")).Text);
            var f  = (driver.FindElement(By.XPath("//*[@id=\"wood\"]"))).GetAttribute("title"); // to implement
            magazineSize = int.Parse(driver.FindElement(By.Id("storage")).Text);
            popCap = int.Parse(driver.FindElement(By.Id("pop_current_label")).Text);
            popCapMax = int.Parse(driver.FindElement(By.Id("pop_max_label")).Text);
            
        }
        public void UpdateResourcesOverview()
        {
            VillageName = driver.FindElement(By.XPath("//*[@id=\"menu_row2_village\"]/a")).Text;
        }
        public void UpdateResourcesMain()
        {
            var table = driver.FindElement(By.Id("buildings")).FindElements(By.TagName("tr"));
            buildings = new List<Building>();
            for (int i = 1; i < table.Count; i++)
            {
                string[] buildingstats = table[i].Text.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                string[] buildingdetails = buildingstats[1].Split(' ');
                int usellesint;
                bool isparasable = int.TryParse(buildingdetails[1], out usellesint);
                if (!isparasable) buildingdetails[1] = "0";
                if(buildingdetails.Length == 7)
                {
                    buildings.Add(new Building()
                    {
                        name = table[i].GetAttribute("id"),
                        level = int.Parse(buildingdetails[1]),
                        nlwood = int.Parse(buildingdetails[2]),
                        nlclay = int.Parse(buildingdetails[3]),
                        nliron = int.Parse(buildingdetails[4]),
                        nltime = buildingdetails[5],
                        nlpop = int.Parse(buildingdetails[6]),
                    });
                }
                else // building is full
                {
                    buildings.Add(new Building()
                    {
                        name = table[i].GetAttribute("id"),
                        level = int.Parse(buildingdetails[1]),
                    });
                }
               
            }
        }

    }
    public class Building
    {
        public string name;
        public int level;
        public int nlwood;
        public int nlclay;
        public int nliron;
        public string nltime;
        public int nlpop;
    }
}
