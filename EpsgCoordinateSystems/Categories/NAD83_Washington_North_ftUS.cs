using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Washington_North_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2285;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Washington North";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Washington North (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,48.73333333333333],PARAMETER[standard_parallel_2,47.5],PARAMETER[latitude_of_origin,47],PARAMETER[central_meridian,-120.8333333333333],PARAMETER[false_easting,1640416.667],PARAMETER[false_northing,0],AUTHORITY[EPSG,2285],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Washington North (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,48.73333333333333],PARAMETER[standard_parallel_2,47.5],PARAMETER[latitude_of_origin,47],PARAMETER[central_meridian,-120.8333333333333],PARAMETER[false_easting,1640416.667],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-120.004889, 47.2211838181819, 0),
                    new Vector(-120.005087, 47.31265081818201, 0),
                    new Vector(-119.982461, 47.31499081818181, 0),
                    new Vector(-119.9831, 47.3287608181819, 0),
                    new Vector(-119.959106, 47.3306598181819, 0),
                    new Vector(-119.959079, 47.3449158181819, 0),
                    new Vector(-119.938406, 47.34581581818169, 0),
                    new Vector(-119.937668, 47.3591628181819, 0),
                    new Vector(-119.917706, 47.36143981818191, 0),
                    new Vector(-119.916896, 47.3881158181819, 0),
                    new Vector(-119.897546, 47.3894478181818, 0),
                    new Vector(-119.896925, 47.40601681818189, 0),
                    new Vector(-119.875586, 47.4073848181819, 0),
                    new Vector(-119.87537, 47.4331338181819, 0),
                    new Vector(-119.531399, 47.4375708181818, 0),
                    new Vector(-119.532398, 47.4988878181819, 0),
                    new Vector(-118.977431, 47.5002018181819, 0),
                    new Vector(-118.980356, 47.2599198181819, 0),
                    new Vector(-117.960197, 47.2565448181819, 0),
                    new Vector(-117.828032, 47.2573998181817, 0),
                    new Vector(-117.042395, 47.2584978181818, 0),
                    new Vector(-117.041792, 47.3614488181819, 0),
                    new Vector(-117.037472, 47.97109081818191, 0),
                    new Vector(-117.038867, 48.0461778181818, 0),
                    new Vector(-117.02912, 48.8380698181818, 0),
                    new Vector(-117.032054, 48.9999258181819, 0),
                    new Vector(-117.438584, 48.9999168181819, 0),
                    new Vector(-118.200344, 48.99990781818181, 0),
                    new Vector(-118.843601, 48.99989881818181, 0),
                    new Vector(-120.857063, 48.9998268181819, 0),
                    new Vector(-122.765117, 48.9997458181819, 0),
                    new Vector(-122.74394, 48.95580781818181, 0),
                    new Vector(-122.82242, 48.95072281818191, 0),
                    new Vector(-122.754245, 48.9099888181818, 0),
                    new Vector(-122.697401, 48.80301481818199, 0),
                    new Vector(-122.516852, 48.7579158181819, 0),
                    new Vector(-122.526563, 48.71172781818191, 0),
                    new Vector(-122.4878, 48.6385758181819, 0),
                    new Vector(-122.429543, 48.5993988181818, 0),
                    new Vector(-122.505296, 48.5594478181819, 0),
                    new Vector(-122.473832, 48.462193818182, 0),
                    new Vector(-122.523224, 48.45839581818181, 0),
                    new Vector(-122.608184, 48.5188308181819, 0),
                    new Vector(-122.699417, 48.494323818182, 0),
                    new Vector(-122.667035, 48.41289181818189, 0),
                    new Vector(-122.564363, 48.4142418181819, 0),
                    new Vector(-122.378315, 48.2897178181818, 0),
                    new Vector(-122.404406, 48.24658981818191, 0),
                    new Vector(-122.50913, 48.25378981818181, 0),
                    new Vector(-122.54207, 48.2104638181819, 0),
                    new Vector(-122.514503, 48.1339728181818, 0),
                    new Vector(-122.361332, 48.06010081818191, 0),
                    new Vector(-122.454428, 48.1284918181818, 0),
                    new Vector(-122.462861, 48.22836481818189, 0),
                    new Vector(-122.402021, 48.2252148181818, 0),
                    new Vector(-122.368334, 48.1281498181819, 0),
                    new Vector(-122.216981, 48.0074328181818, 0),
                    new Vector(-122.230112, 47.96911081818191, 0),
                    new Vector(-122.302922, 47.9502198181818, 0),
                    new Vector(-122.394488, 47.77417081818179, 0),
                    new Vector(-122.41481, 47.66418181818191, 0),
                    new Vector(-122.382221, 47.5954128181818, 0),
                    new Vector(-122.392643, 47.51024581818179, 0),
                    new Vector(-122.319725, 47.3901138181818, 0),
                    new Vector(-122.325377, 47.34433081818181, 0),
                    new Vector(-122.42084, 47.31884281818181, 0),
                    new Vector(-122.32886, 47.2558158181818, 0),
                    new Vector(-122.152397, 47.2560858181819, 0),
                    new Vector(-122.109692, 47.2056858181818, 0),
                    new Vector(-122.064161, 47.1783798181818, 0),
                    new Vector(-121.966529, 47.1584808181819, 0),
                    new Vector(-121.943309, 47.142757818182, 0),
                    new Vector(-121.896221, 47.1554748181819, 0),
                    new Vector(-121.840736, 47.1450168181818, 0),
                    new Vector(-121.794503, 47.1696228181819, 0),
                    new Vector(-121.702496, 47.1525768181819, 0),
                    new Vector(-121.641998, 47.155546818182, 0),
                    new Vector(-121.578053, 47.1190518181818, 0),
                    new Vector(-121.513676, 47.1234798181819, 0),
                    new Vector(-121.443008, 47.0844018181819, 0),
                    new Vector(-121.385921, 47.0876148181818, 0),
                    new Vector(-121.40492, 47.1127428181819, 0),
                    new Vector(-121.38206, 47.13967981818179, 0),
                    new Vector(-121.364906, 47.14252381818181, 0),
                    new Vector(-121.319474, 47.1310938181818, 0),
                    new Vector(-121.303895, 47.1375558181818, 0),
                    new Vector(-121.308899, 47.19349081818189, 0),
                    new Vector(-121.357346, 47.2292208181819, 0),
                    new Vector(-121.330994, 47.254879818182, 0),
                    new Vector(-121.339697, 47.2753098181818, 0),
                    new Vector(-121.427348, 47.296441818182, 0),
                    new Vector(-121.438661, 47.3351778181819, 0),
                    new Vector(-121.461143, 47.36068381818181, 0),
                    new Vector(-121.44047, 47.3714838181819, 0),
                    new Vector(-121.360424, 47.4559398181818, 0),
                    new Vector(-121.295723, 47.4911028181819, 0),
                    new Vector(-121.221617, 47.5582878181819, 0),
                    new Vector(-121.154765, 47.5939188181818, 0),
                    new Vector(-121.117991, 47.5964028181818, 0),
                    new Vector(-121.090622, 47.57787181818181, 0),
                    new Vector(-121.074134, 47.5502778181819, 0),
                    new Vector(-121.040555, 47.5282458181819, 0),
                    new Vector(-121.004276, 47.5164108181819, 0),
                    new Vector(-120.916643, 47.43102781818191, 0),
                    new Vector(-120.842492, 47.4114798181818, 0),
                    new Vector(-120.800381, 47.4131088181818, 0),
                    new Vector(-120.671474, 47.3471388181818, 0),
                    new Vector(-120.613703, 47.3426748181819, 0),
                    new Vector(-120.57557, 47.3183748181818, 0),
                    new Vector(-120.574985, 47.30735881818179, 0),
                    new Vector(-120.541712, 47.3100498181819, 0),
                    new Vector(-120.520562, 47.32714981818189, 0),
                    new Vector(-120.380495, 47.2561578181819, 0),
                    new Vector(-120.091343, 47.2569678181819, 0),
                    new Vector(-120.070463, 47.2247928181818, 0),
                    new Vector(-120.004889, 47.2211838181819, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-122.982755, 47.60547481818189, 0),
                    new Vector(-122.899352, 47.6725158181819, 0),
                    new Vector(-122.858798, 47.8273248181819, 0),
                    new Vector(-122.809514, 47.8570698181819, 0),
                    new Vector(-122.789804, 47.8025478181819, 0),
                    new Vector(-122.745875, 47.8089918181818, 0),
                    new Vector(-122.65358, 47.86442281818181, 0),
                    new Vector(-122.661563, 47.91715381818189, 0),
                    new Vector(-122.802926, 48.0853188181819, 0),
                    new Vector(-122.768879, 48.14398981818191, 0),
                    new Vector(-122.841113, 48.1331358181818, 0),
                    new Vector(-122.924849, 48.0667968181818, 0),
                    new Vector(-122.921591, 48.0941838181819, 0),
                    new Vector(-123.123218, 48.1487328181818, 0),
                    new Vector(-123.396854, 48.1110228181818, 0),
                    new Vector(-123.991214, 48.1591638181819, 0),
                    new Vector(-124.563542, 48.3572808181819, 0),
                    new Vector(-124.717172, 48.3775578181819, 0),
                    new Vector(-124.705211, 48.2320008181818, 0),
                    new Vector(-124.732769, 48.1499928181819, 0),
                    new Vector(-124.606679, 47.873737818182, 0),
                    new Vector(-124.484036, 47.8082538181819, 0),
                    new Vector(-124.373606, 47.6387658181818, 0),
                    new Vector(-124.349081, 47.5269048181819, 0),
                    new Vector(-124.051109, 47.5273368181819, 0),
                    new Vector(-124.050299, 47.51354881818191, 0),
                    new Vector(-123.502019, 47.51275681818189, 0),
                    new Vector(-123.500516, 47.6054928181818, 0),
                    new Vector(-122.982755, 47.60547481818189, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-123.026333, 47.5159338181819, 0),
                    new Vector(-122.803457, 47.5180308181818, 0),
                    new Vector(-122.799551, 47.39888881818191, 0),
                    new Vector(-122.637434, 47.3985828181818, 0),
                    new Vector(-122.628758, 47.3985558181819, 0),
                    new Vector(-122.558459, 47.3983668181818, 0),
                    new Vector(-122.504468, 47.5072218181819, 0),
                    new Vector(-122.5427, 47.52273781818201, 0),
                    new Vector(-122.555273, 47.5835058181819, 0),
                    new Vector(-122.586467, 47.5711938181819, 0),
                    new Vector(-122.621504, 47.69696881818191, 0),
                    new Vector(-122.473589, 47.75498281818191, 0),
                    new Vector(-122.531891, 47.90946781818191, 0),
                    new Vector(-122.613215, 47.9361888181817, 0),
                    new Vector(-122.611163, 47.8500048181818, 0),
                    new Vector(-122.723051, 47.75689981818189, 0),
                    new Vector(-122.752949, 47.66068981818179, 0),
                    new Vector(-122.916974, 47.6146098181819, 0),
                    new Vector(-123.026333, 47.5159338181819, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-122.733194, 48.2766498181818, 0),
                    new Vector(-122.768771, 48.218815818182, 0),
                    new Vector(-122.695547, 48.18117781818191, 0),
                    new Vector(-122.608625, 48.0314268181818, 0),
                    new Vector(-122.544968, 47.9675268181819, 0),
                    new Vector(-122.471618, 47.9875068181818, 0),
                    new Vector(-122.442791, 47.9180538181819, 0),
                    new Vector(-122.386964, 47.9045448181819, 0),
                    new Vector(-122.355401, 47.9638818181818, 0),
                    new Vector(-122.379989, 48.0321468181817, 0),
                    new Vector(-122.496206, 48.0940758181819, 0),
                    new Vector(-122.546201, 48.0768588181818, 0),
                    new Vector(-122.610929, 48.2063148181818, 0),
                    new Vector(-122.732033, 48.2254218181819, 0),
                    new Vector(-122.623511, 48.29635081818189, 0),
                    new Vector(-122.528642, 48.2835078181819, 0),
                    new Vector(-122.525753, 48.3210468181819, 0),
                    new Vector(-122.604386, 48.4047918181818, 0),
                    new Vector(-122.665613, 48.3967818181818, 0),
                    new Vector(-122.733194, 48.2766498181818, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-122.967986, 48.4437888181818, 0),
                    new Vector(-123.018881, 48.4896078181818, 0),
                    new Vector(-123.022274, 48.5133678181818, 0),
                    new Vector(-122.967986, 48.5269398181817, 0),
                    new Vector(-123.008702, 48.53371681818191, 0),
                    new Vector(-123.012095, 48.5574858181819, 0),
                    new Vector(-123.103715, 48.60838081818181, 0),
                    new Vector(-123.141065, 48.6236448181817, 0),
                    new Vector(-123.169901, 48.5625618181818, 0),
                    new Vector(-123.159713, 48.5218458181818, 0),
                    new Vector(-123.095237, 48.4794198181819, 0),
                    new Vector(-122.967986, 48.4437888181818, 0)
                })
            }
        };
    }
}