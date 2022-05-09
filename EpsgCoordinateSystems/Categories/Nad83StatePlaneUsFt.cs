using System.Collections.Generic;
using System.Linq;

namespace EpsgCoordinateSystems.Categories
{
    public class Nad83StatePlaneUsFt
    {
        public readonly List<string> Names;
        public readonly List<string> Descriptions;
        public readonly List<INad83UsFtCrs> CoordinateSystems;
        public readonly INad83UsFtCrs ArkansasNorth;
        public readonly INad83UsFtCrs ArkansasSouth;
        public readonly INad83UsFtCrs CaliforniaZone1;
        public readonly INad83UsFtCrs CaliforniaZone2;
        public readonly INad83UsFtCrs CaliforniaZone3;
        public readonly INad83UsFtCrs CaliforniaZone4;
        public readonly INad83UsFtCrs CaliforniaZone5;
        public readonly INad83UsFtCrs CaliforniaZone6;
        public readonly INad83UsFtCrs ColoradoCentral;
        public readonly INad83UsFtCrs ColoradoNorth;
        public readonly INad83UsFtCrs ColoradoSouth;
        public readonly INad83UsFtCrs Connecticut;
        public readonly INad83UsFtCrs Delaware;
        public readonly INad83UsFtCrs FloridaEast;
        public readonly INad83UsFtCrs FloridaNorth;
        public readonly INad83UsFtCrs FloridaWest;
        public readonly INad83UsFtCrs GeorgiaEast;
        public readonly INad83UsFtCrs GeorgiaWest;
        public readonly INad83UsFtCrs HawaiiZone3;
        public readonly INad83UsFtCrs IdahoCentral;
        public readonly INad83UsFtCrs IdahoEast;
        public readonly INad83UsFtCrs IdahoWest;
        public readonly INad83UsFtCrs IllinoisEast;
        public readonly INad83UsFtCrs IllinoisWest;
        public readonly INad83UsFtCrs IndianaEast;
        public readonly INad83UsFtCrs IndianaWest;
        public readonly INad83UsFtCrs IowaNorth;
        public readonly INad83UsFtCrs IowaSouth;
        public readonly INad83UsFtCrs KansasNorth;
        public readonly INad83UsFtCrs KansasSouth;
        public readonly INad83UsFtCrs KentuckyNorth;
        public readonly INad83UsFtCrs KentuckySouth;
        public readonly INad83UsFtCrs LouisianaNorth;
        public readonly INad83UsFtCrs LouisianaSouth;
        public readonly INad83UsFtCrs MaineEast;
        public readonly INad83UsFtCrs MaineWest;
        public readonly INad83UsFtCrs Maryland;
        public readonly INad83UsFtCrs MassachusettsIsland;
        public readonly INad83UsFtCrs MassachusettsMainland;
        public readonly INad83UsFtCrs MinnesotaCentral;
        public readonly INad83UsFtCrs MinnesotaNorth;
        public readonly INad83UsFtCrs MinnesotaSouth;
        public readonly INad83UsFtCrs MississippiEast;
        public readonly INad83UsFtCrs MississippiWest;
        public readonly INad83UsFtCrs Nebraska;
        public readonly INad83UsFtCrs NevadaCentral;
        public readonly INad83UsFtCrs NevadaEast;
        public readonly INad83UsFtCrs NevadaWest;
        public readonly INad83UsFtCrs NewHampshire;
        public readonly INad83UsFtCrs NewJersey;
        public readonly INad83UsFtCrs NewMexicoCentral;
        public readonly INad83UsFtCrs NewMexicoEast;
        public readonly INad83UsFtCrs NewMexicoWest;
        public readonly INad83UsFtCrs NewYorkCentral;
        public readonly INad83UsFtCrs NewYorkEast;
        public readonly INad83UsFtCrs NewYorkLongIsland;
        public readonly INad83UsFtCrs NewYorkWest;
        public readonly INad83UsFtCrs NorthCarolina;
        public readonly INad83UsFtCrs OhioNorth;
        public readonly INad83UsFtCrs OhioSouth;
        public readonly INad83UsFtCrs OklahomaNorth;
        public readonly INad83UsFtCrs OklahomaSouth;
        public readonly INad83UsFtCrs PennsylvaniaNorth;
        public readonly INad83UsFtCrs PennsylvaniaSouth;
        public readonly INad83UsFtCrs RhodeIsland;
        public readonly INad83UsFtCrs SouthDakotaNorth;
        public readonly INad83UsFtCrs SouthDakotaSouth;
        public readonly INad83UsFtCrs Tennessee;
        public readonly INad83UsFtCrs TexasCentral;
        public readonly INad83UsFtCrs TexasNorthCentral;
        public readonly INad83UsFtCrs TexasNorth;
        public readonly INad83UsFtCrs TexasSouthCentral;
        public readonly INad83UsFtCrs TexasSouth;
        public readonly INad83UsFtCrs UtahCentral;
        public readonly INad83UsFtCrs UtahNorth;
        public readonly INad83UsFtCrs UtahSouth;
        public readonly INad83UsFtCrs VirginiaNorth;
        public readonly INad83UsFtCrs VirginiaSouth;
        public readonly INad83UsFtCrs WashingtonNorth;
        public readonly INad83UsFtCrs WashingtonSouth;
        public readonly INad83UsFtCrs WestVirginiaNorth;
        public readonly INad83UsFtCrs WestVirginiaSouth;
        public readonly INad83UsFtCrs WisconsinCentral;
        public readonly INad83UsFtCrs WisconsinNorth;
        public readonly INad83UsFtCrs WisconsinSouth;
        public readonly INad83UsFtCrs WyomingEastCentral;
        public readonly INad83UsFtCrs WyomingEast;
        public readonly INad83UsFtCrs WyomingWestCentral;
        public readonly INad83UsFtCrs WyomingWest;

        public INad83UsFtCrs GetBySrid(int srid)
        {
            var thisType = GetType();
            var fields = thisType.GetFields();
            foreach (var f in fields)
            {
                if (!(f.GetValue(this) is INad83UsFtCrs cs))
                    continue;
                if (cs.Srid == srid)
                    return cs;
            }

            return null;
        }

        public INad83UsFtCrs GetByName(string name)
        {
            var thisType = GetType();
            var fields = thisType.GetFields();
            foreach (var f in fields)
            {
                if (!(f.GetValue(this) is INad83UsFtCrs cs))
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
            IowaNorth = new NAD83_Iowa_North_ftUS();
            IowaSouth = new NAD83_Iowa_South_ftUS();
            KansasNorth = new NAD83_Kansas_North_ftUS();
            KansasSouth = new NAD83_Kansas_South_ftUS();
            IllinoisEast = new NAD83_Illinois_East_ftUS();
            IllinoisWest = new NAD83_Illinois_West_ftUS();
            IndianaEast = new NAD83_Indiana_East_ftUS();
            IndianaWest = new NAD83_Indiana_West_ftUS();
            KentuckyNorth = new NAD83_Kentucky_North_ftUS();
            KentuckySouth = new NAD83_Kentucky_South_ftUS();
            LouisianaNorth = new NAD83_Louisiana_North_ftUS();
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
            NevadaCentral = new NAD83_Nevada_Central_ftUS();
            NevadaEast = new NAD83_Nevada_East_ftUS();
            NevadaWest = new NAD83_Nevada_West_ftUS();
            NewHampshire = new NAD83_New_Hampshire_ftUS();
            NewJersey = new NAD83_New_Jersey_ftUS();
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
            CoordinateSystems = new List<INad83UsFtCrs>();
            foreach (var f in fields)
            {
                if (!(f.GetValue(this) is INad83UsFtCrs cs))
                    continue;
                CoordinateSystems.Add(cs);
            }

            Names = CoordinateSystems.Select(x => x.Name).ToList();
            Descriptions = CoordinateSystems.Select(x => x.Description).ToList();
        }
    }
}