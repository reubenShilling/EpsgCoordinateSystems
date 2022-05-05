using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_California_zone_5_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2229;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "California zone 5";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / California zone 5 (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,35.46666666666667],PARAMETER[standard_parallel_2,34.03333333333333],PARAMETER[latitude_of_origin,33.5],PARAMETER[central_meridian,-118],PARAMETER[false_easting,6561666.667],PARAMETER[false_northing,1640416.667],AUTHORITY[EPSG,2229],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / California zone 5 (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,35.46666666666667],PARAMETER[standard_parallel_2,34.03333333333333],PARAMETER[latitude_of_origin,33.5],PARAMETER[central_meridian,-118],PARAMETER[false_easting,6561666.667],PARAMETER[false_northing,1640416.667],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-114.424025, 34.0783398181819, 0),
                    new Vector(-114.410165, 34.1026578181819, 0),
                    new Vector(-114.322793, 34.1413038181819, 0),
                    new Vector(-114.285362, 34.1712288181818, 0),
                    new Vector(-114.235772, 34.186213818182, 0),
                    new Vector(-114.149912, 34.2669798181819, 0),
                    new Vector(-114.125225, 34.2726138181819, 0),
                    new Vector(-114.134126, 34.3145448181819, 0),
                    new Vector(-114.153422, 34.3364418181818, 0),
                    new Vector(-114.182078, 34.3652058181819, 0),
                    new Vector(-114.257849, 34.4054898181819, 0),
                    new Vector(-114.283391, 34.4120688181818, 0),
                    new Vector(-114.302867, 34.4357568181819, 0),
                    new Vector(-114.332639, 34.4548728181819, 0),
                    new Vector(-114.376505, 34.4596788181818, 0),
                    new Vector(-114.383867, 34.4770848181819, 0),
                    new Vector(-114.376829, 34.5365658181818, 0),
                    new Vector(-114.409742, 34.5837258181819, 0),
                    new Vector(-114.434303, 34.5989628181818, 0),
                    new Vector(-114.42227, 34.6108878181819, 0),
                    new Vector(-114.465632, 34.7098698181818, 0),
                    new Vector(-114.497798, 34.7447538181819, 0),
                    new Vector(-114.525554, 34.7489118181819, 0),
                    new Vector(-114.542033, 34.7599548181819, 0),
                    new Vector(-114.570221, 34.8318648181819, 0),
                    new Vector(-114.627254, 34.8755328181819, 0),
                    new Vector(-114.630476, 34.9194978181818, 0),
                    new Vector(-114.621008, 34.9436088181819, 0),
                    new Vector(-114.632276, 34.9976538181818, 0),
                    new Vector(-114.621071, 34.9989138181818, 0),
                    new Vector(-115.6262, 35.7957018181818, 0),
                    new Vector(-116.607317, 35.7966378181818, 0),
                    new Vector(-117.642173, 35.8057008181819, 0),
                    new Vector(-117.931046, 35.8049808181818, 0),
                    new Vector(-117.929831, 35.7981858181818, 0),
                    new Vector(-118.007519, 35.7975468181819, 0),
                    new Vector(-119.52977, 35.7930558181819, 0),
                    new Vector(-120.189083, 35.7944328181818, 0),
                    new Vector(-120.199235, 35.7932538181818, 0),
                    new Vector(-121.329086, 35.8010388181818, 0),
                    new Vector(-121.270271, 35.6635368181819, 0),
                    new Vector(-121.146566, 35.6293188181818, 0),
                    new Vector(-120.991946, 35.4565818181819, 0),
                    new Vector(-120.875207, 35.4277638181819, 0),
                    new Vector(-120.849998, 35.3645388181818, 0),
                    new Vector(-120.883604, 35.2594098181819, 0),
                    new Vector(-120.861347, 35.2092528181818, 0),
                    new Vector(-120.638417, 35.1400248181819, 0),
                    new Vector(-120.616763, 35.0748198181819, 0),
                    new Vector(-120.644339, 34.9726338181818, 0),
                    new Vector(-120.665948, 34.9038108181818, 0),
                    new Vector(-120.608159, 34.8556158181819, 0),
                    new Vector(-120.631676, 34.7599098181819, 0),
                    new Vector(-120.601616, 34.7040198181818, 0),
                    new Vector(-120.641288, 34.5723408181819, 0),
                    new Vector(-120.509411, 34.5213738181818, 0),
                    new Vector(-120.456203, 34.4424978181819, 0),
                    new Vector(-120.140168, 34.4719008181818, 0),
                    new Vector(-120.011495, 34.4616678181819, 0),
                    new Vector(-119.869439, 34.4047968181818, 0),
                    new Vector(-119.606288, 34.4164338181819, 0),
                    new Vector(-119.483015, 34.3748628181818, 0),
                    new Vector(-119.266763, 34.2380988181818, 0),
                    new Vector(-119.216336, 34.1463348181819, 0),
                    new Vector(-118.939361, 34.0400808181818, 0),
                    new Vector(-118.788116, 34.0182558181818, 0),
                    new Vector(-118.541858, 34.0372548181819, 0),
                    new Vector(-118.412105, 33.882967818182, 0),
                    new Vector(-118.388174, 33.8123268181818, 0),
                    new Vector(-118.428953, 33.7754448181818, 0),
                    new Vector(-118.405094, 33.7384548181819, 0),
                    new Vector(-118.286888, 33.7039128181818, 0),
                    new Vector(-118.246622, 33.7739238181819, 0),
                    new Vector(-118.106717, 33.7475628181818, 0),
                    new Vector(-118.087889, 33.7623498181819, 0),
                    new Vector(-118.091642, 33.7941378181818, 0),
                    new Vector(-118.065353, 33.8102928181819, 0),
                    new Vector(-118.042286, 33.8627898181819, 0),
                    new Vector(-118.012649, 33.8807898181819, 0),
                    new Vector(-117.99221, 33.8832378181819, 0),
                    new Vector(-117.990185, 33.8982678181819, 0),
                    new Vector(-117.971573, 33.9138738181819, 0),
                    new Vector(-117.970295, 33.9447978181819, 0),
                    new Vector(-117.78323, 33.9507648181819, 0),
                    new Vector(-117.677408, 33.880960818182, 0),
                    new Vector(-117.680936, 33.9041268181819, 0),
                    new Vector(-117.655493, 33.9056388181819, 0),
                    new Vector(-117.653468, 33.9265638181818, 0),
                    new Vector(-117.608081, 33.9286248181818, 0),
                    new Vector(-117.605651, 33.9731928181819, 0),
                    new Vector(-117.554846, 33.9920838181819, 0),
                    new Vector(-117.554594, 34.0334478181819, 0),
                    new Vector(-117.372785, 34.0346358181819, 0),
                    new Vector(-117.371606, 34.0205418181818, 0),
                    new Vector(-117.223079, 34.0182018181818, 0),
                    new Vector(-117.22361, 34.0072938181818, 0),
                    new Vector(-116.924405, 34.0056558181818, 0),
                    new Vector(-116.924918, 34.0347528181819, 0),
                    new Vector(-115.973249, 34.0333938181818, 0),
                    new Vector(-115.312343, 34.0406568181818, 0),
                    new Vector(-115.312091, 34.0779258181819, 0),
                    new Vector(-114.424025, 34.0783398181819, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-119.867828, 34.0752258181818, 0),
                    new Vector(-119.927687, 34.0591788181819, 0),
                    new Vector(-119.873984, 34.0318728181817, 0),
                    new Vector(-119.889068, 34.0046748181819, 0),
                    new Vector(-119.847272, 33.9684138181819, 0),
                    new Vector(-119.712533, 33.9652818181819, 0),
                    new Vector(-119.539373, 34.0065018181818, 0),
                    new Vector(-119.523092, 34.0345908181819, 0),
                    new Vector(-119.572592, 34.0557858181818, 0),
                    new Vector(-119.66792, 34.0213428181818, 0),
                    new Vector(-119.867828, 34.0752258181818, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-120.167384, 33.9241608181818, 0),
                    new Vector(-120.10919, 33.8948208181819, 0),
                    new Vector(-119.96339, 33.9477678181819, 0),
                    new Vector(-120.046802, 34.0411068181818, 0),
                    new Vector(-120.238547, 34.0108848181818, 0),
                    new Vector(-120.167384, 33.9241608181818, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-118.594769, 33.4808208181818, 0),
                    new Vector(-118.556438, 33.4344798181818, 0),
                    new Vector(-118.481342, 33.4195578181819, 0),
                    new Vector(-118.455395, 33.3247788181819, 0),
                    new Vector(-118.304033, 33.3074898181819, 0),
                    new Vector(-118.294601, 33.3344448181818, 0),
                    new Vector(-118.362398, 33.4110078181818, 0),
                    new Vector(-118.594769, 33.4808208181818, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-118.350959, 32.8191948181819, 0),
                    new Vector(-118.541579, 32.9873778181819, 0),
                    new Vector(-118.571486, 33.0359688181817, 0),
                    new Vector(-118.599521, 33.0210198181819, 0),
                    new Vector(-118.511681, 32.8920768181819, 0),
                    new Vector(-118.420106, 32.8061178181819, 0),
                    new Vector(-118.350959, 32.8191948181819, 0)
                })
            }
        };
    }
}