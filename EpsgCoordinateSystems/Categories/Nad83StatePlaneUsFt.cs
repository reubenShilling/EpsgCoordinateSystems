using System.Collections.Generic;
using System.Linq;

namespace EpsgCoordinateSystems.Categories
{
    public class Nad83StatePlaneUsFt
    {
        public readonly List<string> Names;
        public readonly List<INad83StatePlaneUsFtCoordinateSystem> CoordinateSystems;
        public readonly INad83StatePlaneUsFtCoordinateSystem ArkansasNorth;
        public readonly INad83StatePlaneUsFtCoordinateSystem ArkansasSouth;
        public readonly INad83StatePlaneUsFtCoordinateSystem CaliforniaZone1;
        public readonly INad83StatePlaneUsFtCoordinateSystem CaliforniaZone2;
        public readonly INad83StatePlaneUsFtCoordinateSystem CaliforniaZone3;
        public readonly INad83StatePlaneUsFtCoordinateSystem CaliforniaZone4;
        public readonly INad83StatePlaneUsFtCoordinateSystem CaliforniaZone5;
        public readonly INad83StatePlaneUsFtCoordinateSystem CaliforniaZone6;
        public readonly INad83StatePlaneUsFtCoordinateSystem ColoradoCentral;
        public readonly INad83StatePlaneUsFtCoordinateSystem ColoradoNorth;
        public readonly INad83StatePlaneUsFtCoordinateSystem ColoradoSouth;
        public readonly INad83StatePlaneUsFtCoordinateSystem Connecticut;
        public readonly INad83StatePlaneUsFtCoordinateSystem Delaware;
        public readonly INad83StatePlaneUsFtCoordinateSystem FloridaEast;
        public readonly INad83StatePlaneUsFtCoordinateSystem FloridaNorth;
        public readonly INad83StatePlaneUsFtCoordinateSystem FloridaWest;
        public readonly INad83StatePlaneUsFtCoordinateSystem GeorgiaEast;
        public readonly INad83StatePlaneUsFtCoordinateSystem GeorgiaWest;
        public readonly INad83StatePlaneUsFtCoordinateSystem HawaiiZone3;
        public readonly INad83StatePlaneUsFtCoordinateSystem IdahoCentral;
        public readonly INad83StatePlaneUsFtCoordinateSystem IdahoEast;
        public readonly INad83StatePlaneUsFtCoordinateSystem IdahoWest;
        public readonly INad83StatePlaneUsFtCoordinateSystem IllinoisEast;
        public readonly INad83StatePlaneUsFtCoordinateSystem IllinoisWest;
        public readonly INad83StatePlaneUsFtCoordinateSystem IndianaEast;
        public readonly INad83StatePlaneUsFtCoordinateSystem IndianaWest;
        public readonly INad83StatePlaneUsFtCoordinateSystem KentuckyNorth;
        public readonly INad83StatePlaneUsFtCoordinateSystem KentuckySingleZone;
        public readonly INad83StatePlaneUsFtCoordinateSystem KentuckySouth;
        public readonly INad83StatePlaneUsFtCoordinateSystem LouisianaNorth;
        public readonly INad83StatePlaneUsFtCoordinateSystem LouisianaOffshore;
        public readonly INad83StatePlaneUsFtCoordinateSystem LouisianaSouth;
        public readonly INad83StatePlaneUsFtCoordinateSystem MaineEast;
        public readonly INad83StatePlaneUsFtCoordinateSystem MaineWest;
        public readonly INad83StatePlaneUsFtCoordinateSystem Maryland;
        public readonly INad83StatePlaneUsFtCoordinateSystem MassachusettsIsland;
        public readonly INad83StatePlaneUsFtCoordinateSystem MassachusettsMainland;
        public readonly INad83StatePlaneUsFtCoordinateSystem MinnesotaCentral;
        public readonly INad83StatePlaneUsFtCoordinateSystem MinnesotaNorth;
        public readonly INad83StatePlaneUsFtCoordinateSystem MinnesotaSouth;
        public readonly INad83StatePlaneUsFtCoordinateSystem MississippiEast;
        public readonly INad83StatePlaneUsFtCoordinateSystem MississippiWest;
        public readonly INad83StatePlaneUsFtCoordinateSystem Nebraska;
        public readonly INad83StatePlaneUsFtCoordinateSystem NewHampshire;
        public readonly INad83StatePlaneUsFtCoordinateSystem NewMexicoCentral;
        public readonly INad83StatePlaneUsFtCoordinateSystem NewMexicoEast;
        public readonly INad83StatePlaneUsFtCoordinateSystem NewMexicoWest;
        public readonly INad83StatePlaneUsFtCoordinateSystem NewYorkCentral;
        public readonly INad83StatePlaneUsFtCoordinateSystem NewYorkEast;
        public readonly INad83StatePlaneUsFtCoordinateSystem NewYorkLongIsland;
        public readonly INad83StatePlaneUsFtCoordinateSystem NewYorkWest;
        public readonly INad83StatePlaneUsFtCoordinateSystem NorthCarolina;
        public readonly INad83StatePlaneUsFtCoordinateSystem OhioNorth;
        public readonly INad83StatePlaneUsFtCoordinateSystem OhioSouth;
        public readonly INad83StatePlaneUsFtCoordinateSystem OklahomaNorth;
        public readonly INad83StatePlaneUsFtCoordinateSystem OklahomaSouth;
        public readonly INad83StatePlaneUsFtCoordinateSystem PennsylvaniaNorth;
        public readonly INad83StatePlaneUsFtCoordinateSystem PennsylvaniaSouth;
        public readonly INad83StatePlaneUsFtCoordinateSystem RhodeIsland;
        public readonly INad83StatePlaneUsFtCoordinateSystem SouthDakotaNorth;
        public readonly INad83StatePlaneUsFtCoordinateSystem SouthDakotaSouth;
        public readonly INad83StatePlaneUsFtCoordinateSystem Tennessee;
        public readonly INad83StatePlaneUsFtCoordinateSystem TexasCentral;
        public readonly INad83StatePlaneUsFtCoordinateSystem TexasNorthCentral;
        public readonly INad83StatePlaneUsFtCoordinateSystem TexasNorth;
        public readonly INad83StatePlaneUsFtCoordinateSystem TexasSouthCentral;
        public readonly INad83StatePlaneUsFtCoordinateSystem TexasSouth;
        public readonly INad83StatePlaneUsFtCoordinateSystem UtahCentral;
        public readonly INad83StatePlaneUsFtCoordinateSystem UtahNorth;
        public readonly INad83StatePlaneUsFtCoordinateSystem UtahSouth;
        public readonly INad83StatePlaneUsFtCoordinateSystem VirginiaNorth;
        public readonly INad83StatePlaneUsFtCoordinateSystem VirginiaSouth;
        public readonly INad83StatePlaneUsFtCoordinateSystem WashingtonNorth;
        public readonly INad83StatePlaneUsFtCoordinateSystem WashingtonSouth;
        public readonly INad83StatePlaneUsFtCoordinateSystem WestVirginiaNorth;
        public readonly INad83StatePlaneUsFtCoordinateSystem WestVirginiaSouth;
        public readonly INad83StatePlaneUsFtCoordinateSystem WisconsinCentral;
        public readonly INad83StatePlaneUsFtCoordinateSystem WisconsinNorth;
        public readonly INad83StatePlaneUsFtCoordinateSystem WisconsinSouth;
        public readonly INad83StatePlaneUsFtCoordinateSystem WyomingEastCentral;
        public readonly INad83StatePlaneUsFtCoordinateSystem WyomingEast;
        public readonly INad83StatePlaneUsFtCoordinateSystem WyomingWestCentral;
        public readonly INad83StatePlaneUsFtCoordinateSystem WyomingWest;

        public INad83StatePlaneUsFtCoordinateSystem GetBySrid(int srid)
        {
            var thisType = GetType();
            var fields = thisType.GetFields();
            foreach (var f in fields)
            {
                if (!(f.GetValue(this) is INad83StatePlaneUsFtCoordinateSystem cs))
                    continue;
                if (cs.Srid == srid)
                    return cs;
            }

            return null;
        }

        public INad83StatePlaneUsFtCoordinateSystem GetByName(string name)
        {
            var thisType = GetType();
            var fields = thisType.GetFields();
            foreach (var f in fields)
            {
                if (!(f.GetValue(this) is INad83StatePlaneUsFtCoordinateSystem cs))
                    continue;
                if (cs.Name == name)
                    return cs;
            }

            return null;
        }

        public Nad83StatePlaneUsFt()
        {
            ArkansasNorth = new NAD83_Arkansas_North_ftUS();
            ArkansasSouth = new NAD83_Arkansas_South_ftUS();
            CaliforniaZone1 = new NAD83_California_zone_1_ftUS();
            CaliforniaZone2 = new NAD83_California_zone_2_ftUS();
            CaliforniaZone3 = new NAD83_California_zone_3_ftUS();
            CaliforniaZone4 = new NAD83_California_zone_4_ftUS();
            CaliforniaZone5 = new NAD83_California_zone_5_ftUS();
            CaliforniaZone6 = new NAD83_California_zone_6_ftUS();
            ColoradoCentral = new NAD83_Colorado_Central_ftUS();
            ColoradoNorth = new NAD83_Colorado_North_ftUS();
            ColoradoSouth = new NAD83_Colorado_South_ftUS();
            Connecticut = new NAD83_Connecticut_ftUS();
            Delaware = new NAD83_Delaware_ftUS();
            FloridaEast = new NAD83_Florida_East_ftUS();
            FloridaNorth = new NAD83_Florida_North_ftUS();
            FloridaWest = new NAD83_Florida_West_ftUS();
            GeorgiaEast = new NAD83_Georgia_East_ftUS();
            GeorgiaWest = new NAD83_Georgia_West_ftUS();
            HawaiiZone3 = new NAD83_Hawaii_zone_3_ftUS();
            IdahoCentral = new NAD83_Idaho_Central_ftUS();
            IdahoEast = new NAD83_Idaho_East_ftUS();
            IdahoWest = new NAD83_Idaho_West_ftUS();
            IllinoisEast = new NAD83_Illinois_East_ftUS();
            IllinoisWest = new NAD83_Illinois_West_ftUS();
            IndianaEast = new NAD83_Indiana_East_ftUS();
            IndianaWest = new NAD83_Indiana_West_ftUS();
            KentuckyNorth = new NAD83_Kentucky_North_ftUS();
            KentuckySingleZone = new NAD83_Kentucky_Single_Zone_ftUS();
            KentuckySouth = new NAD83_Kentucky_South_ftUS();
            LouisianaNorth = new NAD83_Louisiana_North_ftUS();
            LouisianaOffshore = new NAD83_Louisiana_Offshore_ftUS();
            LouisianaSouth = new NAD83_Louisiana_South_ftUS();
            MaineEast = new NAD83_Maine_East_ftUS();
            MaineWest = new NAD83_Maine_West_ftUS();
            Maryland = new NAD83_Maryland_ftUS();
            MassachusettsIsland = new NAD83_Massachusetts_Island_ftUS();
            MassachusettsMainland = new NAD83_Massachusetts_Mainland_ftUS();
            MinnesotaCentral = new NAD83_Minnesota_Central_ftUS();
            MinnesotaNorth = new NAD83_Minnesota_North_ftUS();
            MinnesotaSouth = new NAD83_Minnesota_South_ftUS();
            MississippiEast = new NAD83_Mississippi_East_ftUS();
            MississippiWest = new NAD83_Mississippi_West_ftUS();
            Nebraska = new NAD83_Nebraska_ftUS();
            NewHampshire = new NAD83_New_Hampshire_ftUS();
            NewMexicoCentral = new NAD83_New_Mexico_Central_ftUS();
            NewMexicoEast = new NAD83_New_Mexico_East_ftUS();
            NewMexicoWest = new NAD83_New_Mexico_West_ftUS();
            NewYorkCentral = new NAD83_New_York_Central_ftUS();
            NewYorkEast = new NAD83_New_York_East_ftUS();
            NewYorkLongIsland = new NAD83_New_York_Long_Island_ftUS();
            NewYorkWest = new NAD83_New_York_West_ftUS();
            NorthCarolina = new NAD83_North_Carolina_ftUS();
            OhioNorth = new NAD83_Ohio_North_ftUS();
            OhioSouth = new NAD83_Ohio_South_ftUS();
            OklahomaNorth = new NAD83_Oklahoma_North_ftUS();
            OklahomaSouth = new NAD83_Oklahoma_South_ftUS();
            PennsylvaniaNorth = new NAD83_Pennsylvania_North_ftUS();
            PennsylvaniaSouth = new NAD83_Pennsylvania_South_ftUS();
            RhodeIsland = new NAD83_Rhode_Island_ftUS();
            SouthDakotaNorth = new NAD83_South_Dakota_North_ftUS();
            SouthDakotaSouth = new NAD83_South_Dakota_South_ftUS();
            Tennessee = new NAD83_Tennessee_ftUS();
            TexasCentral = new NAD83_Texas_Central_ftUS();
            TexasNorthCentral = new NAD83_Texas_North_Central_ftUS();
            TexasNorth = new NAD83_Texas_North_ftUS();
            TexasSouthCentral = new NAD83_Texas_South_Central_ftUS();
            TexasSouth = new NAD83_Texas_South_ftUS();
            UtahCentral = new NAD83_Utah_Central_ftUS();
            UtahNorth = new NAD83_Utah_North_ftUS();
            UtahSouth = new NAD83_Utah_South_ftUS();
            VirginiaNorth = new NAD83_Virginia_North_ftUS();
            VirginiaSouth = new NAD83_Virginia_South_ftUS();
            WashingtonNorth = new NAD83_Washington_North_ftUS();
            WashingtonSouth = new NAD83_Washington_South_ftUS();
            WestVirginiaNorth = new NAD83_West_Virginia_North_ftUS();
            WestVirginiaSouth = new NAD83_West_Virginia_South_ftUS();
            WisconsinCentral = new NAD83_Wisconsin_Central_ftUS();
            WisconsinNorth = new NAD83_Wisconsin_North_ftUS();
            WisconsinSouth = new NAD83_Wisconsin_South_ftUS();
            WyomingEastCentral = new NAD83_Wyoming_East_Central_ftUS();
            WyomingEast = new NAD83_Wyoming_East_ftUS();
            WyomingWestCentral = new NAD83_Wyoming_West_Central_ftUS();
            WyomingWest = new NAD83_Wyoming_West_ftUS();

            var thisType = GetType();
            var fields = thisType.GetFields();
            CoordinateSystems = new List<INad83StatePlaneUsFtCoordinateSystem>();
            foreach (var f in fields)
            {
                if (!(f.GetValue(this) is INad83StatePlaneUsFtCoordinateSystem cs))
                    continue;
                CoordinateSystems.Add(cs);
            }

            Names = CoordinateSystems.Select(x => x.Name).ToList();
        }
    }
}