﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribalWars
{
    public class Village
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public List<string> BuildQueue { get; set; }
        public BuildSettings buildSettings { get; set; }
        public Buildings buildings { get; set; }
        public Units units { get; set; }
        public Resources resources { get; set; }
        public VillageSettings villageSettings { get; set; }
    }
    public class VillageSettings
    {
        public bool Active { get; set; } = false;
        public string Link { get; set; } = "";
    }
    public class Buildings
    {
        public int Main { get; set; }
        public int Barracks { get; set; }
        public int Stable { get; set; }
        public int Garage { get; set; }
        public int Church { get; set; }
        public int Watchtower { get; set; }
        public int Snob { get; set; }
        public int Smith { get; set; }
        public int Place { get; set; }
        public int Statue { get; set; }
        public int Market { get; set; }
        public int Wood { get; set; }
        public int Stone { get; set; }
        public int Iron { get; set; }
        public int Farm { get; set; }
        public int Storage { get; set; }
        public int Hide { get; set; }
        public int Wall { get; set; }
    }
    public class BuildSettings
    {
        public bool BuildRequiments { get; set; }
        public bool BuildFarmIfLowSpace { get; set; }
        public int LowSpacePercent { get; set; }
        public bool BuildFarmIfNotEnoughCap { get; set; }
        public bool BuildStorageForRequiments { get; set; }
        public bool BuildStorageIfNoSpace { get; set; }

        public bool AnyOption()
        {
            if(BuildRequiments || BuildFarmIfLowSpace || LowSpacePercent > 0 || BuildFarmIfNotEnoughCap || BuildStorageForRequiments || BuildStorageIfNoSpace)
            {
                return true;
            }else return false;
        }
    }
    public class Resources
    {
        public int Wood { get; set; } = 0;
        public int Stone { get; set; } = 0;
        public int Iron { get; set; } = 0;
    }
    public class Units
    {
        public int Spear { get; set; } = 0;
        public int Sword { get; set; } = 0;
        public int Axe { get; set; } = 0;
        public int Archer { get; set; } = 0;
        public int Spy { get; set; } = 0;
        public int Light { get; set; } = 0;
        public int Marcher { get; set; } = 0;
        public int Heavy { get; set; } = 0;
        public int Ram { get; set; } = 0;
        public int Catapult { get; set; } = 0;
        public int Snob { get; set; } = 0;
    }

}
