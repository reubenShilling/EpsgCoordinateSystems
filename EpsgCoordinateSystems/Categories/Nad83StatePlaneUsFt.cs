using System.Collections.Generic;
using System.Linq;

namespace EpsgCoordinateSystems.Categories
{
    public class Nad83StatePlaneUsFt
    {
        public readonly List<string> Names;
        public readonly List<IEpsgCoordinateSystem> CoordinateSystems;
        public readonly IEpsgCoordinateSystem ArkansasNorth;
        public readonly IEpsgCoordinateSystem ArkansasSouth;
        public readonly IEpsgCoordinateSystem CaliforniaZone1;
        public readonly IEpsgCoordinateSystem CaliforniaZone2;
        public readonly IEpsgCoordinateSystem CaliforniaZone3;
        public readonly IEpsgCoordinateSystem CaliforniaZone4;
        public readonly IEpsgCoordinateSystem CaliforniaZone5;
        public readonly IEpsgCoordinateSystem CaliforniaZone6;
        public readonly IEpsgCoordinateSystem ColoradoCentral;
        public readonly IEpsgCoordinateSystem ColoradoNorth;
        public readonly IEpsgCoordinateSystem ColoradoSouth;
        public readonly IEpsgCoordinateSystem Connecticut;
        public readonly IEpsgCoordinateSystem Delaware;
        public readonly IEpsgCoordinateSystem FloridaEast;
        public readonly IEpsgCoordinateSystem FloridaNorth;
        public readonly IEpsgCoordinateSystem FloridaWest;
        public readonly IEpsgCoordinateSystem GeorgiaEast;
        public readonly IEpsgCoordinateSystem GeorgiaWest;
        public readonly IEpsgCoordinateSystem HawaiiZone3;
        public readonly IEpsgCoordinateSystem IdahoCentral;
        public readonly IEpsgCoordinateSystem IdahoEast;
        public readonly IEpsgCoordinateSystem IdahoWest;
        public readonly IEpsgCoordinateSystem IllinoisEast;
        public readonly IEpsgCoordinateSystem IllinoisWest;
        public readonly IEpsgCoordinateSystem IndianaEast;
        public readonly IEpsgCoordinateSystem IndianaWest;
        public readonly IEpsgCoordinateSystem KentuckyNorth;
        public readonly IEpsgCoordinateSystem KentuckySingleZone;
        public readonly IEpsgCoordinateSystem KentuckySouth;
        public readonly IEpsgCoordinateSystem LouisianaNorth;
        public readonly IEpsgCoordinateSystem LouisianaOffshore;
        public readonly IEpsgCoordinateSystem LouisianaSouth;
        public readonly IEpsgCoordinateSystem MaineEast;
        public readonly IEpsgCoordinateSystem MaineWest;
        public readonly IEpsgCoordinateSystem Maryland;
        public readonly IEpsgCoordinateSystem MassachusettsIsland;
        public readonly IEpsgCoordinateSystem MassachusettsMainland;
        public readonly IEpsgCoordinateSystem MinnesotaCentral;
        public readonly IEpsgCoordinateSystem MinnesotaNorth;
        public readonly IEpsgCoordinateSystem MinnesotaSouth;
        public readonly IEpsgCoordinateSystem MississippiEast;
        public readonly IEpsgCoordinateSystem MississippiWest;
        public readonly IEpsgCoordinateSystem Nebraska;
        public readonly IEpsgCoordinateSystem NewHampshire;
        public readonly IEpsgCoordinateSystem NewMexicoCentral;
        public readonly IEpsgCoordinateSystem NewMexicoEast;
        public readonly IEpsgCoordinateSystem NewMexicoWest;
        public readonly IEpsgCoordinateSystem NewYorkCentral;
        public readonly IEpsgCoordinateSystem NewYorkEast;
        public readonly IEpsgCoordinateSystem NewYorkLongIsland;
        public readonly IEpsgCoordinateSystem NewYorkWest;
        public readonly IEpsgCoordinateSystem NorthCarolina;
        public readonly IEpsgCoordinateSystem OhioNorth;
        public readonly IEpsgCoordinateSystem OhioSouth;
        public readonly IEpsgCoordinateSystem OklahomaNorth;
        public readonly IEpsgCoordinateSystem OklahomaSouth;
        public readonly IEpsgCoordinateSystem PennsylvaniaNorth;
        public readonly IEpsgCoordinateSystem PennsylvaniaSouth;
        public readonly IEpsgCoordinateSystem RhodeIsland;
        public readonly IEpsgCoordinateSystem SouthDakotaNorth;
        public readonly IEpsgCoordinateSystem SouthDakotaSouth;
        public readonly IEpsgCoordinateSystem Tennessee;
        public readonly IEpsgCoordinateSystem TexasCentral;
        public readonly IEpsgCoordinateSystem TexasNorthCentral;
        public readonly IEpsgCoordinateSystem TexasNorth;
        public readonly IEpsgCoordinateSystem TexasSouthCentral;
        public readonly IEpsgCoordinateSystem TexasSouth;
        public readonly IEpsgCoordinateSystem UtahCentral;
        public readonly IEpsgCoordinateSystem UtahNorth;
        public readonly IEpsgCoordinateSystem UtahSouth;
        public readonly IEpsgCoordinateSystem VirginiaNorth;
        public readonly IEpsgCoordinateSystem VirginiaSouth;
        public readonly IEpsgCoordinateSystem WashingtonNorth;
        public readonly IEpsgCoordinateSystem WashingtonSouth;
        public readonly IEpsgCoordinateSystem WestVirginiaNorth;
        public readonly IEpsgCoordinateSystem WestVirginiaSouth;
        public readonly IEpsgCoordinateSystem WisconsinCentral;
        public readonly IEpsgCoordinateSystem WisconsinNorth;
        public readonly IEpsgCoordinateSystem WisconsinSouth;
        public readonly IEpsgCoordinateSystem WyomingEastCentral;
        public readonly IEpsgCoordinateSystem WyomingEast;
        public readonly IEpsgCoordinateSystem WyomingWestCentral;
        public readonly IEpsgCoordinateSystem WyomingWest;

        public IEpsgCoordinateSystem GetBySrid(int srid)
        {
            var thisType = GetType();
            var fields = thisType.GetFields();
            foreach (var f in fields)
            {
                if (!(f.GetValue(this) is IEpsgCoordinateSystem cs))
                    continue;
                if (cs.Srid == srid)
                    return cs;
            }

            return null;
        }

        public IEpsgCoordinateSystem GetByName(string name)
        {
            var thisType = GetType();
            var fields = thisType.GetFields();
            foreach (var f in fields)
            {
                if (!(f.GetValue(this) is IEpsgCoordinateSystem cs))
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
            CoordinateSystems = new List<IEpsgCoordinateSystem>();
            foreach (var f in fields)
            {
                if (!(f.GetValue(this) is IEpsgCoordinateSystem cs))
                    continue;
                CoordinateSystems.Add(cs);
            }

            Names = CoordinateSystems.Select(x => x.Name).ToList();
        }
    }
}