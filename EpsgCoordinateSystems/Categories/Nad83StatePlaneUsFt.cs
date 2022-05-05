using System.Collections.Generic;
using System.Linq;

namespace EpsgCoordinateSystems.Categories
{
    public class Nad83StatePlaneUsFt
    {
        public readonly List<string> Names;
        public readonly List<string> Descriptions;
        public readonly List<Nad83StatePlaneUsFtCoordinateSystem> CoordinateSystems;
        public readonly Nad83StatePlaneUsFtCoordinateSystem ArkansasNorth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem ArkansasSouth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem CaliforniaZone1;
        public readonly Nad83StatePlaneUsFtCoordinateSystem CaliforniaZone2;
        public readonly Nad83StatePlaneUsFtCoordinateSystem CaliforniaZone3;
        public readonly Nad83StatePlaneUsFtCoordinateSystem CaliforniaZone4;
        public readonly Nad83StatePlaneUsFtCoordinateSystem CaliforniaZone5;
        public readonly Nad83StatePlaneUsFtCoordinateSystem CaliforniaZone6;
        public readonly Nad83StatePlaneUsFtCoordinateSystem ColoradoCentral;
        public readonly Nad83StatePlaneUsFtCoordinateSystem ColoradoNorth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem ColoradoSouth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem Connecticut;
        public readonly Nad83StatePlaneUsFtCoordinateSystem Delaware;
        public readonly Nad83StatePlaneUsFtCoordinateSystem FloridaEast;
        public readonly Nad83StatePlaneUsFtCoordinateSystem FloridaNorth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem FloridaWest;
        public readonly Nad83StatePlaneUsFtCoordinateSystem GeorgiaEast;
        public readonly Nad83StatePlaneUsFtCoordinateSystem GeorgiaWest;
        public readonly Nad83StatePlaneUsFtCoordinateSystem HawaiiZone3;
        public readonly Nad83StatePlaneUsFtCoordinateSystem IdahoCentral;
        public readonly Nad83StatePlaneUsFtCoordinateSystem IdahoEast;
        public readonly Nad83StatePlaneUsFtCoordinateSystem IdahoWest;
        public readonly Nad83StatePlaneUsFtCoordinateSystem IllinoisEast;
        public readonly Nad83StatePlaneUsFtCoordinateSystem IllinoisWest;
        public readonly Nad83StatePlaneUsFtCoordinateSystem IndianaEast;
        public readonly Nad83StatePlaneUsFtCoordinateSystem IndianaWest;
        public readonly Nad83StatePlaneUsFtCoordinateSystem KentuckyNorth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem KentuckySingleZone;
        public readonly Nad83StatePlaneUsFtCoordinateSystem KentuckySouth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem LouisianaNorth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem LouisianaOffshore;
        public readonly Nad83StatePlaneUsFtCoordinateSystem LouisianaSouth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem MaineEast;
        public readonly Nad83StatePlaneUsFtCoordinateSystem MaineWest;
        public readonly Nad83StatePlaneUsFtCoordinateSystem Maryland;
        public readonly Nad83StatePlaneUsFtCoordinateSystem MassachusettsIsland;
        public readonly Nad83StatePlaneUsFtCoordinateSystem MassachusettsMainland;
        public readonly Nad83StatePlaneUsFtCoordinateSystem MinnesotaCentral;
        public readonly Nad83StatePlaneUsFtCoordinateSystem MinnesotaNorth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem MinnesotaSouth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem MississippiEast;
        public readonly Nad83StatePlaneUsFtCoordinateSystem MississippiWest;
        public readonly Nad83StatePlaneUsFtCoordinateSystem Nebraska;
        public readonly Nad83StatePlaneUsFtCoordinateSystem NewHampshire;
        public readonly Nad83StatePlaneUsFtCoordinateSystem NewMexicoCentral;
        public readonly Nad83StatePlaneUsFtCoordinateSystem NewMexicoEast;
        public readonly Nad83StatePlaneUsFtCoordinateSystem NewMexicoWest;
        public readonly Nad83StatePlaneUsFtCoordinateSystem NewYorkCentral;
        public readonly Nad83StatePlaneUsFtCoordinateSystem NewYorkEast;
        public readonly Nad83StatePlaneUsFtCoordinateSystem NewYorkLongIsland;
        public readonly Nad83StatePlaneUsFtCoordinateSystem NewYorkWest;
        public readonly Nad83StatePlaneUsFtCoordinateSystem NorthCarolina;
        public readonly Nad83StatePlaneUsFtCoordinateSystem OhioNorth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem OhioSouth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem OklahomaNorth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem OklahomaSouth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem PennsylvaniaNorth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem PennsylvaniaSouth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem RhodeIsland;
        public readonly Nad83StatePlaneUsFtCoordinateSystem SouthDakotaNorth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem SouthDakotaSouth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem Tennessee;
        public readonly Nad83StatePlaneUsFtCoordinateSystem TexasCentral;
        public readonly Nad83StatePlaneUsFtCoordinateSystem TexasNorthCentral;
        public readonly Nad83StatePlaneUsFtCoordinateSystem TexasNorth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem TexasSouthCentral;
        public readonly Nad83StatePlaneUsFtCoordinateSystem TexasSouth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem UtahCentral;
        public readonly Nad83StatePlaneUsFtCoordinateSystem UtahNorth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem UtahSouth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem VirginiaNorth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem VirginiaSouth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem WashingtonNorth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem WashingtonSouth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem WestVirginiaNorth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem WestVirginiaSouth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem WisconsinCentral;
        public readonly Nad83StatePlaneUsFtCoordinateSystem WisconsinNorth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem WisconsinSouth;
        public readonly Nad83StatePlaneUsFtCoordinateSystem WyomingEastCentral;
        public readonly Nad83StatePlaneUsFtCoordinateSystem WyomingEast;
        public readonly Nad83StatePlaneUsFtCoordinateSystem WyomingWestCentral;
        public readonly Nad83StatePlaneUsFtCoordinateSystem WyomingWest;

        public Nad83StatePlaneUsFtCoordinateSystem GetBySrid(int srid)
        {
            var thisType = GetType();
            var fields = thisType.GetFields();
            foreach (var f in fields)
            {
                if (!(f.GetValue(this) is Nad83StatePlaneUsFtCoordinateSystem cs))
                    continue;
                if (cs.Srid == srid)
                    return cs;
            }

            return null;
        }

        public Nad83StatePlaneUsFtCoordinateSystem GetByName(string name)
        {
            var thisType = GetType();
            var fields = thisType.GetFields();
            foreach (var f in fields)
            {
                if (!(f.GetValue(this) is Nad83StatePlaneUsFtCoordinateSystem cs))
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
            CoordinateSystems = new List<Nad83StatePlaneUsFtCoordinateSystem>();
            foreach (var f in fields)
            {
                if (!(f.GetValue(this) is Nad83StatePlaneUsFtCoordinateSystem cs))
                    continue;
                CoordinateSystems.Add(cs);
            }

            Names = CoordinateSystems.Select(x => x.Name).ToList();
            Descriptions = CoordinateSystems.Select(x => x.Description).ToList();
        }
    }
}