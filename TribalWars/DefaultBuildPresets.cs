using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribalWars
{
    public class DefaultBuildPresets
    {
        public static BuildPreset Eko = new BuildPreset()
        {
            Name = "Eko",
            buildSettings = new BuildSettings()
            {
                BuildFarmIfLowSpace = true,
                BuildFarmIfNotEnoughCap = true,
                BuildRequiments = true,
                BuildStorageForRequiments = true,
                BuildStorageIfNoSpace = true,
                LowSpacePercent = 10
            },
            Queue = new List<string>()
            {
                "main",
                "place",
                "farm",
                "storage",
                "stone",
                "main",
                "main",
                "main",
                "main",//5
                "storage",
                "storage",
                "storage",
                "storage",
                "storage",
                "storage",
                "storage",
                "storage",
                "storage",
                "wood",//1
                "iron",//1
                "stone",//2
                "wood",//2
                "stone",//3
                "wood",//3
                "stone",//4
                "wood",//4
                "stone",//5
                "wood",//5
                "stone",//6
                "wood",//6
                "barracks",//1
                "stone",//7
                "wood",//7
                "market",//1
                "iron",//2
                 "stone",//8
                "wood",//8
                 "iron",//3
                 "stone",//9
                "wood",//9
                "iron",//4
                "wall",//1
                "main",//7
                "stone",//10
                "wood",//10
                "iron",//5
                 "barracks",//2
                 "barracks",//3
                 "stone",//11
                 "wood",//11
                 "iron",//6
                 "main",//8
                 "main",//9
                 "main",//10
                 "farm",//2
                  "stone",//12
                 "wood",//12
                  "farm",//3
                  "iron",//7
                  "iron",//8
                  "stone",//13
                 "wood",//13
                 "iron",//9
                 "storage",//12
                 "barracks",//4
                 "market",//2
                 "stone",//14
                 "wood",//14
                 "iron",//10
                 "storage",//13
                 "storage",//14
                 "stone",//15
                 "wood",//15
                 "iron",//11
                 "storage",//15
                 "barracks",//5
                 "smith",//1
                 "main",//11
                 "main",//12
                 "main",//13
                 "smith",//2
                 "smith",//3
                 "stone",//16
                 "market",//3
                 "wood",//16
                 "iron",//12
                 "iron",//13
                 "farm",//4
                 "storage",//16
                 "storage",//17
                 "storage",//18
                 "storage",//19
                 "stone",//17
                 "wood",//17
                 "iron",//14
                 "iron",//15
                 "farm",//5
                 "smith",//4
                 "smith",//5
                  "stone",//18
                 "wood",//18
                 "main",//14
                 "main",//15
                 "stone",//19
                 "wood",//19
                 "iron",//16
                 "market",//4
                 "storage",//20
                 "farm",//6
                 "stone",//20
                 "wood",//20
                 "iron",//17
                 "farm",//7
                 "stable",//1
                 "stone",//21
                 "stable",//2
                 "iron",//21
                 "iron",//18
                 "iron",//19
                 "stable",//3
                 "farm",//8
                 "stone",//22
                 "market",//5
                  "stone",//22
                  "iron",//20
                  "farm",//9
                  "main",//16
                  "stone",//23
                  "wood",//23
                  "iron",//21
                  "storage",//21
                   "stone",//24
                  "wood",//24
                  "iron",//22
                  "main",//17
                  "market",//6
                  "stone",//25
                  "farm",//10
                  "wood",//25
                  "iron",//23
                  "market",//7
                  "main",//19
                  "market",//8
                  "main",//20
                  "farm",//11
                  "stone",//26
                  "iron",//24
                  "market",//9
                   "wood",//26
                   "market",//10
                   "storage",//22
                   "farm",//12
                    "stone",//27
                    "wood",//27
                    "iron",//25
                    "iron",//26
                    "stone",//28
                    "wood",//28
                    "storage",//23
                    "farm",//13
                    "iron",//27
                    "stone",//29
                    "wood",//29
                    "iron",//28
                    "farm",//14
                    "stone",//30
                    "wood",//30
                     "iron",//29
                     "farm",//15
                     "iron",//30
                    
            }
        };
        
    }
}
