using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribalWars
{
    public class StaticMethods
    {
        public static string TranslateVillageIdReverse(string Name)
        {
            switch (Name)
            {
                case "Main": return "main_buildrow_main";
                case "Barracks": return "main_buildrow_barracks"; 
                case "Stable": return "main_buildrow_stable";
                case "Garage": return "main_buildrow_garage";
                case "Watchtower": return "main_buildrow_watchtower";
                case "Snob": return "main_buildrow_snob";
                case "Smith": return "main_buildrow_smith"; 
                case "Place": return "main_buildrow_place"; 
                case "Statue": return "main_buildrow_statue"; 
                case "Market": return "main_buildrow_market"; 
                case "Wood": return "main_buildrow_wood"; 
                case "Stone": return "main_buildrow_stone";
                case "Iron": return "main_buildrow_iron"; 
                case "Farm": return "main_buildrow_farm"; 
                case "Storage": return "main_buildrow_storage"; 
                case "Hide": return "main_buildrow_hide"; 
                case "Wall": return "main_buildrow_wall"; 
                default: return "error";
            }
        }
        public static string TranslateVillageId(string villageid)
        {
            switch (villageid)
            {
                case "main_buildrow_main": return "Main";
                case "main_buildrow_barracks": return "Barracks";
                case "main_buildrow_stable": return "Stable";
                case "main_buildrow_garage": return "Garage";
                case "main_buildrow_watchtower": return "Watchtower";
                case "main_buildrow_snob": return "Snob";
                case "main_buildrow_smith": return "Smith";
                case "main_buildrow_place": return "Place";
                case "main_buildrow_statue": return "Statue";
                case "main_buildrow_market": return "Market";
                case "main_buildrow_wood": return "Wood";
                case "main_buildrow_stone": return "Stone";
                case "main_buildrow_iron": return "Iron";
                case "main_buildrow_farm": return "Farm";
                case "main_buildrow_storage": return "Storage";
                case "main_buildrow_hide": return "Hide";
                case "main_buildrow_wall": return "Wall";
                default: return "error";
            }
        }
        
    }
}
