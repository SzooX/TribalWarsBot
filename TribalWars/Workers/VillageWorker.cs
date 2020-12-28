using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.OffScreen;
using Newtonsoft.Json;

namespace TribalWars
{
    public class VillageWorker
    {
        string mainurl;
        public VillageWorker()
        {
        }
        public  async Task<List<Village>> GatherVillageData(string murl , string[] VillageUrls)
        {
            mainurl = murl;
            List<Village> returnlist = new List<Village>();
            // for here
            for (int i = 0; i < VillageUrls.Length; i++)
            {
                returnlist.Add(await GetVillageData(VillageUrls[i]));
            }
            return returnlist;
        }
        async Task<Village> GetVillageData(string url)
        {
            ChromiumWebBrowser wb = new ChromiumWebBrowser(mainurl + url);
            System.Threading.Thread.Sleep(1000);
            JavascriptResponse jsresponse = await wb.EvaluateScriptAsPromiseAsync(JSfunctions.ScrapVillage);
            dynamic res = jsresponse.Result;
            Village village = JsonConvert.DeserializeObject<Village>(res);
            village.villageSettings = new VillageSettings();
            village.villageSettings.Link = url;
            return village;
        }
    }
}
