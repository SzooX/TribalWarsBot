using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribalWars
{
    class JSfunctions
    {
        public static string ScrapVillage = @"return new Promise(async function(resolve, reject){
        async function test(){
        function TranslateName(name){
            switch(name){
                case ""main_buildrow_main"": return ""Main"";
                case ""main_buildrow_barracks"": return ""Barracks"";
                case ""main_buildrow_stable"": return ""Stable"";
                case ""main_buildrow_garage"": return ""Garage"";
                case ""main_buildrow_watchtower"": return ""Watchtower"";
                case ""main_buildrow_snob"": return ""Snob"";
                case ""main_buildrow_smith"": return ""Smith"";
                case ""main_buildrow_place"": return ""Place"";
                case ""main_buildrow_statue"": return ""Statue"";
                case ""main_buildrow_market"": return ""Market"";
                case ""main_buildrow_wood"": return ""Wood"";
                case ""main_buildrow_stone"": return ""Stone"";
                case ""main_buildrow_iron"": return ""Iron"";
                case ""main_buildrow_farm"": return ""Farm"";
                case ""main_buildrow_storage"": return ""Storage"";
                case ""main_buildrow_hide"": return ""Hide"";
                case ""main_buildrow_wall"": return ""Wall"";
                default:
            }
}
String.prototype.capitalize = function() {
    return this.charAt(0).toUpperCase() + this.slice(1);
}

var Units ={
            Spear:0,
            Sword: 0,
            Axe: 0,
            Archer: 0,
            Spy: 0,
            Light: 0,
            Marcher: 0,
            Heavy: 0,
            Ram: 0,
            Catapult: 0,
            Snob: 0,
        }
        var Resources ={
            Wood:0,
            Stone: 0,
            Iron: 0,
        }
        var Village = {
            Name:"""",
            Points: 0,
            Main: 0,
            Barracks: 0,
            Stable: 0,
            Garage: 0,
            Church: 0,
            Watchtower: 0,
            Sno: 0,
            Smith: 0,
            Place: 0,
            Statue: 0,
            Market: 0,
            Wood: 0,
            Stone: 0,
            Iron: 0,
            Farm: 0,
            Storage: 0,
            Hide: 0,
            Wall: 0,
            Link: """",
            units: { },
            resources: { }
        }
        function getElementByXpath(path)
{
    return document.evaluate(path, document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;
}
//change page in c#
var paths = getElementByXpath(""/html/body/table/tbody/tr[2]/td[2]/table[2]/tbody/tr/td/table/tbody/tr/td/table/tbody/tr/td/table/tbody/tr/td[1]/div[1]/div/table/tbody/tr[1]/td/a"");
var table = `
                <iframe id=""frame1""
            title=""Inline Frame Example""
            width=""300""
            height=""200""
            src=""${paths}"">
        </iframe>
            `
            var oldTables = document.getElementById(""topdisplay"")
            var oldTablesHTML = oldTables.innerHTML
            oldTablesHTML += table;
oldTables.innerHTML = oldTablesHTML
        Village.Name = document.getElementsByClassName(""nowrap tooltip-delayed"")[0].innerText
        var villageunits = document.getElementById(""unit_overview_table"").getElementsByTagName(""tbody"")[0].getElementsByTagName(""tr"");
for (i = 0; i < villageunits.length; i++)
{
    Units[villageunits[i].getElementsByTagName(""strong"")[0].getAttribute(""data-count"").toString().capitalize()] = villageunits[i].getElementsByTagName(""strong"")[0].innerText;
}
Resources.Wood = document.getElementById(""wood"").innerHTML;
Resources.Stone = document.getElementById(""stone"").innerHTML;
Resources.Iron = document.getElementById(""iron"").innerHTML;
function sleep(ms)
{
    return new Promise(resolve => setTimeout(resolve, ms));
}
await sleep(2000);
//then call this
var ifrejm = document.getElementById(""frame1"");
var budynki = ifrejm.contentWindow.document.getElementById(""buildings"").getElementsByTagName(""tr"");
for (i = 1; i < budynki.length; i++)
{
    if (budynki[1] == undefined) continue;
    if (!isNaN(budynki[i].getElementsByTagName(""span"")[0].innerHTML.split("" "")[1]))
    {
        Village[TranslateName(budynki[i].getAttribute(""id""))] = budynki[i].getElementsByTagName(""span"")[0].innerHTML.split("" "")[1];
    }
}
Village.units = Units;
Village.resources = Resources;
return JSON.stringify(Village); ;
        
    };
var res = await test();
resolve(res);
}); ";
    }
}
