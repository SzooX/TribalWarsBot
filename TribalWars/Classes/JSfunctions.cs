using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribalWars
{
    public class JSfunctions
    {

        public static string JsBuildingFunction(List<string> q, BuildSettings s)//BuildSettings buildsettings , List<string> queue
        {
            //building strings
            string queuestring = "[";
            for (int i = 0; i < q.Count; i++)
            {
                queuestring += $@"""{ q[i]}""";
                if (i < q.Count - 1) queuestring += ",";
            }
            queuestring += "]";

            string funstring = $@"return new Promise(async function(resolve, reject){{
async function test(){{
    let BuildRequiments = {s.BuildRequiments.ToString().ToLower()};
    let BuildFarmIfLowSpace = {s.BuildFarmIfLowSpace.ToString().ToLower()};
    let LowSpacePercent = {s.LowSpacePercent};
    let BuildFarmIfNotEnoughCap = {s.BuildFarmIfNotEnoughCap.ToString().ToLower()};
    let BuildStorageForRequiments = {s.BuildStorageForRequiments.ToString().ToLower()};
    let BuildStorageIfNoSpace = {s.BuildStorageIfNoSpace.ToString().ToLower()};
    let Queue = {queuestring};

    var Codes = [];

    if(CheckQueue()){{
        Codes.push(11);
         return BuildReturnObj(); 
    }}
    console.log(""Starting building :)"")
    //First check most important bools
    if(BuildFarmIfLowSpace){{
        if(!IsBuildingInQueue(""farm"")){{
            var currpop = document.getElementById(""pop_current_label"").innerText;
            var maxpop = document.getElementById(""pop_max_label"").innerText;
            var fullifmentpercent = (currpop/maxpop)*100;
            if(100 - fullifmentpercent < LowSpacePercent){{
                var res = await Build(""main_buildrow_farm"");//XXX midsucces
                if(res == 2|| res == 3||res == 4||res == 9||res == 10||res == 11){{
                    Codes.push(res);
                    if(res != 4)return BuildReturnObj(); 
                }}else if(res == 0|| res == 1){{
                    Codes.push(7);
                }}
                // console.error(""Not implemented exception! Unhandled return number : "" + res)
            }}
        }}  
    }}
    if(BuildStorageIfNoSpace && !IsBuildingInQueue(""storage"")){{
        console.log(""Checking storage..."")
        var Wood = document.getElementById(""wood"").innerHTML;
        var Stone = document.getElementById(""stone"").innerHTML;
        var Iron = document.getElementById(""iron"").innerHTML;
        var Storage = document.getElementById(""storage"").innerHTML;
        console.log(""Data loaded!"")
        if(Wood == Storage || Stone == Storage || Iron == Storage){{
            console.log(""Storage too small! Proceeding to building"")
            var res = await Build(""main_buildrow_storage"") //XXX midsucces 
            if(res == 2|| res == 3||res == 4||res == 9||res == 10||res == 11){{
                Codes.push(res);
                if(res != 4)return BuildReturnObj(); 
            }}else if(res == 0|| res == 1){{
                Codes.push(6);
            }}
        }}
    }}
    console.log(""Place in storage: OK"")
    //normal bulding behaviour
    for(i = 0; i < Queue.length + 1; i++){{
    i=0;
    console.log(""for i: "" + i);
    console.log(Queue[i]);
    var res = await Build(""main_buildrow_"" + Queue[i]); ///XXX testing method
    console.log(""main_buildrow_"" + Queue[i]);
    Codes.push(res);
    if(res == 2|| res == 3||res == 4||res == 8||res == 9||res == 10||res == 11){{
        if(res != 4 && res != 8)return BuildReturnObj(); 
    }}else if(res == 0|| res == 1){{
    }}else if(res == 12){{
        return BuildReturnObj(); 
    }}
    HandleCode(res);
    i=0;
    console.log(""For closing with i : "" + i + ""q length : "" + Queue.length);
    }}
    console.log(""exited for"");
    return BuildReturnObj();
    function HandleCode(code){{
        console.log(""handling code "" + code)
        console.log(Queue);
        switch(code){{
            case 0: Queue.splice(0,1); break;
            case 1: Queue.splice(0,1);break;
            case 2: break;
            case 3: break;
            case 4: Queue.splice(0,1);break;
            case 5:break;
            case 6:break;
            case 7:break;
            case 8: Queue.splice(0,1);break;
            case 9: break;
        }}
        console.log(Queue);
    }}
    // function ReturnMessamge(code, name, condition){{ ///XXX unnecesary?

    //     if(condition != """") return ""Condition "" + condition + "" throwed code "" + code + "" for "" + name;
    //     else return name + "" throwed code "" + code;
    // }}
function BuildReturnObj(){{
        //resorces
        var Resources = {{
            Wood,
            Stone,
            Iron
        }};
        Resources.Wood = document.getElementById(""wood"").innerHTML;
        Resources.Stone = document.getElementById(""stone"").innerHTML;
        Resources.Iron = document.getElementById(""iron"").innerHTML;

        //buildings
        var Buildings = {{}};
        var blds = document.getElementById(""buildings"").getElementsByTagName(""tbody"")[0].getElementsByTagName(""tr"");

        for(i = 1; i < blds.length; i++){{
            var actlevel = blds[i].getElementsByTagName(""td"")[0].getElementsByTagName(""span"")[0]
            .innerText.toString().split(' ')[1];
            if(!isNaN(actlevel)){{
                Buildings[blds[i].getAttribute(""id"")] = actlevel;
            }}
        }}

        var returnobj = {{
            Resources,
            Buildings,
            Codes,
            Queue
        }}
        console.log(JSON.stringify(returnobj));
        console.log(returnobj.Codes);
        return JSON.stringify(returnobj);
    }}
    //results
    //0 - succes, no more spaces in queue
    //1 - succes, theres space in queue
    //2 - Unsuccesfull, not enough resources
    //3 - Unsuccesfull, not enough cap
    //4 - Unsuccesfull, fully upgraded
    //5-0/1 - Midsucces, building requied building + result 0/1
    //6-0/1 - Midsucces, building requied storage + result 0/1
    //7-0/1 - Midsucces, building requied farm + result 0/1
    //8 - Building unavaiable on this world
    //9 - Requiments not met
    //10 - Storage not big enough
    //11 - Queue is full
    //12 - Waiting for requiments to be build
    async function Build(buildid){{
        //Building requiments not met / building not avaiable on this world
        if(CheckQueue())return 11;
        console.log(""Build function initialized for "" + buildid);
        console.log(""Checking for building avaiability..."");
        if(document.getElementById(buildid) == null){{
            //check for building in second table
            console.log(""building doesnt exist. Checking if its exist on world settings"");
            var unmetbuildings = document.getElementById(""buildings_unmet"").getElementsByTagName(""tr"");
            var match = null;
            for(i = 1; i < unmetbuildings.length; i++){{
                var stringF = unmetbuildings[i].getElementsByTagName(""td"")[0].getElementsByTagName(""a"")[0]
                .getAttribute(""href"");
                if(stringF.substring(stringF.lastIndexOf('=') + 1,  stringF.length) == 
                buildid.substring(buildid.lastIndexOf('_') + 1, buildid.length)){{
                    match = unmetbuildings[i];
                    break;
                }}
            }}
            if(match != null){{ // Build requiments //BUG Dodaje 1 level za duzo do kolejki mimo ze bedzie spelniac wymagania
                console.log(""Building exist! Can i build requiments?"");
                if(!BuildRequiments) return 9;
                console.log(""Yep - building them!"");
                var requiments = match.getElementsByTagName(""td"")[1].getElementsByClassName(""unmet_req"")[0].getElementsByTagName(""span"");
                var lvlung = 0;
                for(i = 0; i < requiments.length; i++){{
                    if(requiments[i].innerHTML == """") continue;
                    if(requiments[i].getElementsByTagName(""span"")[0] == null) continue;
                    if(requiments[i].getElementsByTagName(""span"")[0].getElementsByTagName(""img"").length == 0 )continue; 
                    var buildid = requiments[i].getElementsByTagName(""span"")[0].getElementsByTagName(""img"")[0].getAttribute(""src"");
                    buildid = buildid.substring(buildid.lastIndexOf('/')+1, buildid.length);
                    buildid = buildid.replace("".png"", """");
                    buildid = buildid.slice(0,-1);
                    //check for level
                    var levelreq = requiments[i].getElementsByTagName(""span"")[0].innerText;
                    levelreq = levelreq.substring(levelreq.indexOf(""("")+1,levelreq.lastIndexOf("")""))
                    console.log(levelreq);

                    var actlevel = document.getElementById(""main_buildrow_""+buildid).getElementsByTagName(""td"")[0].getElementsByTagName(""span"")[0].innerText.toString().split(' ')[1];

                    actlevel = parseInt(actlevel);
                    if(IsBuildingInQueue(buildid)) actlevel++;
                    console.log(actlevel);
                    if(parseInt(actlevel) >= (levelreq)){{
                        console.log(""Level is enough"");
                        lvlung++;
                        if(lvlung >= 3)break;
                        continue;
                    }}
                    //building
                    var res = await Build(""main_buildrow_"" + buildid) //XXX midsucces
                    console.log(""Req build status: "" + res);
                    if(res == 2|| res == 3||res == 4||res == 9||res == 8||res == 10||res == 11){{
                        Codes.push(res);
                        if(res != 8)return BuildReturnObj(); 
                    }}else if(res == 0 || res == 1){{
                        Codes.push(5);
                        if(res == 0) return 5;
                    }}else HandleCode(res);
                    console.log(""im edned waiting"");
                    if(res == 1)
                    {{
                        if(await CheckQueue()){{
                            return 11;
                        }}
                        i--; 
                    }} 
                    else {{return 1;}}
                    // console.error(""Not implemented exception! Unhandled return number : "" + result)

                }}
                console.log(""im here boio"");
                return 12;
            }}else return 8;
        }}
        else
        {{
            var buildT = document.getElementById(buildid);
            //Check if is fully upgraded
            if(buildT.getElementsByClassName(""build_options"").length <= 0){{
                console.log(""Building fully upgraded!"");
                return 4;
            }}
            //Checking if we have enough cap to build
            var currpop = document.getElementById(""pop_current_label"").innerText;
            var maxpop = document.getElementById(""pop_max_label"").innerText;
            var capavaiable = maxpop - currpop;
            var capreq = buildT.getElementsByTagName(""td"")[5].innerText;
            console.log(""Checking do we have enough cap to build = cap avaiable: "" + capavaiable + ""  = cap required : "" + capreq);
            if(capavaiable < capreq){{
                console.log(""No, we dont"");
                if(BuildFarmIfNotEnoughCap){{
                    console.log(""Building farm!"");
                    var res = await Build(""main_buildrow_farm"") 
                    return res;
                    // console.error(""Not implemented exception! Unhandled return number : "" + res)
                }}else return 3;

            }}
            //Checking do we have enough big storage to build that
            console.log(""Checking storage status - storage cap: "" + Storage);
            if(parseInt(Storage) < parseInt(buildT.getElementsByTagName(""td"")[1].getAttribute(""data-cost"")) ||
            parseInt(Storage) <parseInt(buildT.getElementsByTagName(""td"")[2].getAttribute(""data-cost"")) ||
            parseInt(Storage) < parseInt(buildT.getElementsByTagName(""td"")[3].getAttribute(""data-cost""))){{
                console.log(""Storage not big enough!"");
                if(BuildStorageForRequiments){{
                    console.log(""Building storage!"");
                    var res = await Build(""main_buildrow_storage"") //XXX midsucces
                    return res;
                }}else return 10;
            }}
            //Checking do we have enough resources to build
            if(parseInt(Wood) < parseInt(buildT.getElementsByTagName(""td"")[1].getAttribute(""data-cost"")) ||
            parseInt(Stone) < parseInt(buildT.getElementsByTagName(""td"")[2].getAttribute(""data-cost"")) ||
            parseInt(Iron) < parseInt(buildT.getElementsByTagName(""td"")[3].getAttribute(""data-cost""))){{
                return 2;
            }}
            //finally build
            console.log(""Making build call!"");
            buildT.getElementsByClassName(""build_options"")[0].getElementsByClassName(""btn btn-build"")[0].click();
            await sleep(350);
            console.log(CheckQueue());
            return (CheckQueue() ? 0 : 1);
        }}
        
    }}

    function sleep(ms) {{
        return new Promise(resolve => setTimeout(resolve, ms));
      }}

    //queue full = true
    function CheckQueue(){{
        //Check if queue is >2
    if(document.getElementById(""buildqueue"") != null){{
    if(document.getElementById(""buildqueue"").getElementsByTagName(""tr"").length -2 >= 2){{
        return true;
            }}else return false;
        }}else{{
            return false;
        }}
    }}
    function IsBuildingInQueue(name){{
    if(document.getElementById(""buildqueue"") != null){{
        var trelements = document.getElementById(""buildqueue"").getElementsByTagName(""tr"");
        for(i = 0; i < trelements.length; i++){{
            if(trelements[i].className.lastIndexOf(""_"") > -1)
            {{
                if(trelements[i].className.substring(trelements[i].className.lastIndexOf(""_"") + 1, trelements[i].length) == name){{
                    return true;
                }}
            }}
        }}
        return false;
        }}
    }}
}}
var res  = await test();
resolve(res);
}});";
            return funstring;
        }
        
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
        var Buildings = {
            Main:0,
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
        }
        var Village = {
            Name:"""",
            Points: 0,
            buildings: { },
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
        Buildings[TranslateName(budynki[i].getAttribute(""id""))] = budynki[i].getElementsByTagName(""span"")[0].innerHTML.split("" "")[1];
    }
}
Village.units = Units;
Village.resources = Resources;
Village.buildings = Buildings;
return JSON.stringify(Village); ;
        
    };
var res = await test();
resolve(res);
}); ";
    }
}
