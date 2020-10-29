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





        };
    }
}
