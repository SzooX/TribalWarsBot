using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.OffScreen;
using Newtonsoft.Json;

namespace TribalWars.Workers
{
    public class BuildWorker
    {
        bool CanExecuteScript = false;
        ChromiumWebBrowser webbrowser;
        public BuildWorker()
        {
            webbrowser = new ChromiumWebBrowser("google.com");
        }

        public async Task<List<Village>> BuildVillages(List<Village> TVillages)
        {
            for (int i = 0; i < TVillages.Count; i++)
            {
                if (!TVillages[i].villageSettings.Active) continue;
                TVillages[i] = await BuildVillage(TVillages[i]);
            }
            return TVillages;
        }
        async Task<Village> BuildVillage(Village v)
        {
            try
            {
                var buildlink = v.villageSettings.Link.Substring(0,
                v.villageSettings.Link.LastIndexOf("=") + 1);
                buildlink += "main";
                if (!webbrowser.IsBrowserInitialized)
                {
                    webbrowser = new ChromiumWebBrowser("google.com");
                    System.Threading.Thread.Sleep(1000);
                }
                webbrowser.Load(buildlink);
                CanExecuteScript = false;
                webbrowser.LoadingStateChanged += BuildPageLoaded;
                for (; ; )
                {
                    if (CanExecuteScript) break;
                    //System.Threading.Thread.Sleep(500);
                }
                JavascriptResponse jsresponse = await webbrowser.EvaluateScriptAsPromiseAsync(JSfunctions.JsBuildingFunction(v.BuildQueue, v.buildSettings));
                dynamic res = jsresponse.Result;
                BuildObject ResBO = JsonConvert.DeserializeObject<BuildObject>(res);
                v.BuildQueue = ResBO.Queue.ToList();


                //setting buildings

                #region as above
                if (ResBO.Buildings.ContainsKey(StaticMethods.TranslateVillageIdReverse("Barracks")))
                 { v.buildings.Barracks = int.Parse(ResBO.Buildings[StaticMethods.TranslateVillageIdReverse("Barracks")]); }
                if (ResBO.Buildings.ContainsKey(StaticMethods.TranslateVillageIdReverse("Church")))
                { v.buildings.Church = int.Parse(ResBO.Buildings[StaticMethods.TranslateVillageIdReverse("Church")]); }
                if (ResBO.Buildings.ContainsKey(StaticMethods.TranslateVillageIdReverse("Farm")))
                { v.buildings.Farm = int.Parse(ResBO.Buildings[StaticMethods.TranslateVillageIdReverse("Farm")]); }
                if (ResBO.Buildings.ContainsKey(StaticMethods.TranslateVillageIdReverse("Garage")))
                { v.buildings.Garage = int.Parse(ResBO.Buildings[StaticMethods.TranslateVillageIdReverse("Garage")]); }
                if (ResBO.Buildings.ContainsKey(StaticMethods.TranslateVillageIdReverse("Hide")))
                { v.buildings.Hide = int.Parse(ResBO.Buildings[StaticMethods.TranslateVillageIdReverse("Hide")]); }
                if (ResBO.Buildings.ContainsKey(StaticMethods.TranslateVillageIdReverse("Iron")))
                { v.buildings.Iron = int.Parse(ResBO.Buildings[StaticMethods.TranslateVillageIdReverse("Iron")]); }
                if (ResBO.Buildings.ContainsKey(StaticMethods.TranslateVillageIdReverse("Main")))
                { v.buildings.Main = int.Parse(ResBO.Buildings[StaticMethods.TranslateVillageIdReverse("Main")]); }
                if (ResBO.Buildings.ContainsKey(StaticMethods.TranslateVillageIdReverse("Market")))
                { v.buildings.Market = int.Parse(ResBO.Buildings[StaticMethods.TranslateVillageIdReverse("Market")]); }
                if (ResBO.Buildings.ContainsKey(StaticMethods.TranslateVillageIdReverse("Place")))
                { v.buildings.Place = int.Parse(ResBO.Buildings[StaticMethods.TranslateVillageIdReverse("Place")]); }
                if (ResBO.Buildings.ContainsKey(StaticMethods.TranslateVillageIdReverse("Smith")))
                { v.buildings.Smith = int.Parse(ResBO.Buildings[StaticMethods.TranslateVillageIdReverse("Smith")]); }
                if (ResBO.Buildings.ContainsKey(StaticMethods.TranslateVillageIdReverse("Snob")))
                { v.buildings.Snob = int.Parse(ResBO.Buildings[StaticMethods.TranslateVillageIdReverse("Snob")]); }
                if (ResBO.Buildings.ContainsKey(StaticMethods.TranslateVillageIdReverse("Stable")))
                { v.buildings.Stable = int.Parse(ResBO.Buildings[StaticMethods.TranslateVillageIdReverse("Stable")]); }
                if (ResBO.Buildings.ContainsKey(StaticMethods.TranslateVillageIdReverse("Statue")))
                { v.buildings.Statue = int.Parse(ResBO.Buildings[StaticMethods.TranslateVillageIdReverse("Statue")]); }
                if (ResBO.Buildings.ContainsKey(StaticMethods.TranslateVillageIdReverse("Stone")))
                { v.buildings.Stone = int.Parse(ResBO.Buildings[StaticMethods.TranslateVillageIdReverse("Stone")]); }
                if (ResBO.Buildings.ContainsKey(StaticMethods.TranslateVillageIdReverse("Storage")))
                { v.buildings.Storage = int.Parse(ResBO.Buildings[StaticMethods.TranslateVillageIdReverse("Storage")]); }
                if (ResBO.Buildings.ContainsKey(StaticMethods.TranslateVillageIdReverse("Wall")))
                { v.buildings.Wall = int.Parse(ResBO.Buildings[StaticMethods.TranslateVillageIdReverse("Wall")]); }
                if (ResBO.Buildings.ContainsKey(StaticMethods.TranslateVillageIdReverse("Watchtower")))
                { v.buildings.Watchtower = int.Parse(ResBO.Buildings[StaticMethods.TranslateVillageIdReverse("Watchtower")]); }
                if (ResBO.Buildings.ContainsKey(StaticMethods.TranslateVillageIdReverse("Wood")))
                { v.buildings.Wood = int.Parse(ResBO.Buildings[StaticMethods.TranslateVillageIdReverse("Wood")]); }
                #endregion

                v.resources = ResBO.resources;

            }
            catch (Exception ex)
            {

            }
            return v;
        }

        private void BuildPageLoaded(object sender, LoadingStateChangedEventArgs e)
        {
            if(!e.IsLoading)CanExecuteScript = true;
        }
    }


    class BuildObject
    {
        public Resources resources { get; set;  }
        public Dictionary<string, string> Buildings  {get; set;}
        public int[] Codes { get; set; }
        public string[] Queue { get; set; }
    }

}
