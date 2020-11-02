using System;
using System.Collections.Generic;
using System.Text;

namespace TribalWarsBot
{
    class StaticVariables
    {
        public static string TribalWarsURL = "https://www.plemiona.pl/";
        public static string[] BuildOrder = // TODO extract to config
        {
            "main_buildrow_statue",
            "main_buildrow_wood",
            "main_buildrow_stone",
            "main_buildrow_iron",
            "main_buildrow_wood",
            "main_buildrow_stone",//2 clay
            "main_buildrow_wood",
            "main_buildrow_wood",//4 wood
            "main_buildrow_main",
            "main_buildrow_main",
            "main_buildrow_main",//3 hq
            "main_buildrow_barracks", //1 barracaks
            "main_buildrow_stone",//3 clay
            "main_buildrow_wood",//5 wood
            "main_buildrow_stone",//4 clay
            "main_buildrow_iron", // 2 iron
            "main_buildrow_wood",//6 wood
            "main_buildrow_wood",//7 wood
            "main_buildrow_main",//4 hq
            "main_buildrow_main",//5 hq
            "main_buildrow_smith", //smith1
            "main_buildrow_smith", //smith2
            "main_buildrow_stone",//5 clay
            "main_buildrow_iron", // 3 iron
            "main_buildrow_wood",//8 wood
            "main_buildrow_iron", // 4 iron
            "main_buildrow_market", // 11 market
            "main_buildrow_stone",//6 clay
            "main_buildrow_iron", // 5 iron
            "main_buildrow_wood",//9 wood
            "main_buildrow_stone",//7 Clay
            "main_buildrow_wood",//10 wood
            "main_buildrow_iron", // 6 iron
            "main_buildrow_stone",//8 Clay
            "main_buildrow_stone",//9 Clay
            "main_buildrow_iron", // 7 iron
            "main_buildrow_wood",//11 wood 12?
            "main_buildrow_main",//6 hq
            "main_buildrow_main",//7 hq
            "main_buildrow_main",//8 hq
            "main_buildrow_main",//9 hq
            "main_buildrow_main",//10 hq
            "main_buildrow_barracks", //3 barracaks
            "main_buildrow_barracks", //4 barracaks
            "main_buildrow_barracks", //5 barracaks
            "main_buildrow_smith", //smith3
            "main_buildrow_smith", //smith4
            "main_buildrow_smith", //smith5
            "main_buildrow_farm", // 2 farm
            "main_buildrow_farm", // 3 farm
            "main_buildrow_stable", // 1 stable
            "main_buildrow_iron", // 8 iron"
            "main_buildrow_iron", // 9 iron"
            "main_buildrow_stone",//10 Clay
            "main_buildrow_stone",//11 Clay
            "main_buildrow_iron", // 10 iron"
            "main_buildrow_wood",//12 wood 13?
            "main_buildrow_wood",//13 wood 14?
            "main_buildrow_stone",//12 Clay
            "main_buildrow_stone",//13 Clay
            "main_buildrow_iron", // 11 iron"
            "main_buildrow_iron", // 12 iron"
            "main_buildrow_stone",//14 Clay
        };
        public static string[] Units =
        {
            "spear",
            "sword",
            "axe",
            "archer",
            "spy",
            "light",
            "marcher",
            "heavy",
            "ram",
            "catapult",
            "knight",
            "snob"
        };

        public static string BuildingIDtoName(string id)
        {
            return id.Substring(id.LastIndexOf('_')+1);
        }
    }
}
