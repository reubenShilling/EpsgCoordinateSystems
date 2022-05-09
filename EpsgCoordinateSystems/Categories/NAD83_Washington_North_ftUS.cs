using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Washington_North_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2285;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Washington North";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Washington North (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,48.73333333333333],PARAMETER[standard_parallel_2,47.5],PARAMETER[latitude_of_origin,47],PARAMETER[central_meridian,-120.8333333333333],PARAMETER[false_easting,1640416.667],PARAMETER[false_northing,0],AUTHORITY[EPSG,2285],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Washington North (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,48.73333333333333],PARAMETER[standard_parallel_2,47.5],PARAMETER[latitude_of_origin,47],PARAMETER[central_meridian,-120.8333333333333],PARAMETER[false_easting,1640416.667],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(47.2211838181819, -120.004889),
                    new Vector(47.31265081818201, -120.005087),
                    new Vector(47.31499081818181, -119.982461),
                    new Vector(47.3287608181819, -119.9831),
                    new Vector(47.3306598181819, -119.959106),
                    new Vector(47.3449158181819, -119.959079),
                    new Vector(47.34581581818169, -119.938406),
                    new Vector(47.3591628181819, -119.937668),
                    new Vector(47.36143981818191, -119.917706),
                    new Vector(47.3881158181819, -119.916896),
                    new Vector(47.3894478181818, -119.897546),
                    new Vector(47.40601681818189, -119.896925),
                    new Vector(47.4073848181819, -119.875586),
                    new Vector(47.4331338181819, -119.87537),
                    new Vector(47.4375708181818, -119.531399),
                    new Vector(47.4988878181819, -119.532398),
                    new Vector(47.5002018181819, -118.977431),
                    new Vector(47.2599198181819, -118.980356),
                    new Vector(47.2565448181819, -117.960197),
                    new Vector(47.2573998181817, -117.828032),
                    new Vector(47.2584978181818, -117.042395),
                    new Vector(47.3614488181819, -117.041792),
                    new Vector(47.97109081818191, -117.037472),
                    new Vector(48.0461778181818, -117.038867),
                    new Vector(48.8380698181818, -117.02912),
                    new Vector(48.9999258181819, -117.032054),
                    new Vector(48.9999168181819, -117.438584),
                    new Vector(48.99990781818181, -118.200344),
                    new Vector(48.99989881818181, -118.843601),
                    new Vector(48.9998268181819, -120.857063),
                    new Vector(48.9997458181819, -122.765117),
                    new Vector(48.95580781818181, -122.74394),
                    new Vector(48.95072281818191, -122.82242),
                    new Vector(48.9099888181818, -122.754245),
                    new Vector(48.80301481818199, -122.697401),
                    new Vector(48.7579158181819, -122.516852),
                    new Vector(48.71172781818191, -122.526563),
                    new Vector(48.6385758181819, -122.4878),
                    new Vector(48.5993988181818, -122.429543),
                    new Vector(48.5594478181819, -122.505296),
                    new Vector(48.462193818182, -122.473832),
                    new Vector(48.45839581818181, -122.523224),
                    new Vector(48.5188308181819, -122.608184),
                    new Vector(48.494323818182, -122.699417),
                    new Vector(48.41289181818189, -122.667035),
                    new Vector(48.4142418181819, -122.564363),
                    new Vector(48.2897178181818, -122.378315),
                    new Vector(48.24658981818191, -122.404406),
                    new Vector(48.25378981818181, -122.50913),
                    new Vector(48.2104638181819, -122.54207),
                    new Vector(48.1339728181818, -122.514503),
                    new Vector(48.06010081818191, -122.361332),
                    new Vector(48.1284918181818, -122.454428),
                    new Vector(48.22836481818189, -122.462861),
                    new Vector(48.2252148181818, -122.402021),
                    new Vector(48.1281498181819, -122.368334),
                    new Vector(48.0074328181818, -122.216981),
                    new Vector(47.96911081818191, -122.230112),
                    new Vector(47.9502198181818, -122.302922),
                    new Vector(47.77417081818179, -122.394488),
                    new Vector(47.66418181818191, -122.41481),
                    new Vector(47.5954128181818, -122.382221),
                    new Vector(47.51024581818179, -122.392643),
                    new Vector(47.3901138181818, -122.319725),
                    new Vector(47.34433081818181, -122.325377),
                    new Vector(47.31884281818181, -122.42084),
                    new Vector(47.2558158181818, -122.32886),
                    new Vector(47.2560858181819, -122.152397),
                    new Vector(47.2056858181818, -122.109692),
                    new Vector(47.1783798181818, -122.064161),
                    new Vector(47.1584808181819, -121.966529),
                    new Vector(47.142757818182, -121.943309),
                    new Vector(47.1554748181819, -121.896221),
                    new Vector(47.1450168181818, -121.840736),
                    new Vector(47.1696228181819, -121.794503),
                    new Vector(47.1525768181819, -121.702496),
                    new Vector(47.155546818182, -121.641998),
                    new Vector(47.1190518181818, -121.578053),
                    new Vector(47.1234798181819, -121.513676),
                    new Vector(47.0844018181819, -121.443008),
                    new Vector(47.0876148181818, -121.385921),
                    new Vector(47.1127428181819, -121.40492),
                    new Vector(47.13967981818179, -121.38206),
                    new Vector(47.14252381818181, -121.364906),
                    new Vector(47.1310938181818, -121.319474),
                    new Vector(47.1375558181818, -121.303895),
                    new Vector(47.19349081818189, -121.308899),
                    new Vector(47.2292208181819, -121.357346),
                    new Vector(47.254879818182, -121.330994),
                    new Vector(47.2753098181818, -121.339697),
                    new Vector(47.296441818182, -121.427348),
                    new Vector(47.3351778181819, -121.438661),
                    new Vector(47.36068381818181, -121.461143),
                    new Vector(47.3714838181819, -121.44047),
                    new Vector(47.4559398181818, -121.360424),
                    new Vector(47.4911028181819, -121.295723),
                    new Vector(47.5582878181819, -121.221617),
                    new Vector(47.5939188181818, -121.154765),
                    new Vector(47.5964028181818, -121.117991),
                    new Vector(47.57787181818181, -121.090622),
                    new Vector(47.5502778181819, -121.074134),
                    new Vector(47.5282458181819, -121.040555),
                    new Vector(47.5164108181819, -121.004276),
                    new Vector(47.43102781818191, -120.916643),
                    new Vector(47.4114798181818, -120.842492),
                    new Vector(47.4131088181818, -120.800381),
                    new Vector(47.3471388181818, -120.671474),
                    new Vector(47.3426748181819, -120.613703),
                    new Vector(47.3183748181818, -120.57557),
                    new Vector(47.30735881818179, -120.574985),
                    new Vector(47.3100498181819, -120.541712),
                    new Vector(47.32714981818189, -120.520562),
                    new Vector(47.2561578181819, -120.380495),
                    new Vector(47.2569678181819, -120.091343),
                    new Vector(47.2247928181818, -120.070463),
                    new Vector(47.2211838181819, -120.004889)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(47.60547481818189, -122.982755),
                    new Vector(47.6725158181819, -122.899352),
                    new Vector(47.8273248181819, -122.858798),
                    new Vector(47.8570698181819, -122.809514),
                    new Vector(47.8025478181819, -122.789804),
                    new Vector(47.8089918181818, -122.745875),
                    new Vector(47.86442281818181, -122.65358),
                    new Vector(47.91715381818189, -122.661563),
                    new Vector(48.0853188181819, -122.802926),
                    new Vector(48.14398981818191, -122.768879),
                    new Vector(48.1331358181818, -122.841113),
                    new Vector(48.0667968181818, -122.924849),
                    new Vector(48.0941838181819, -122.921591),
                    new Vector(48.1487328181818, -123.123218),
                    new Vector(48.1110228181818, -123.396854),
                    new Vector(48.1591638181819, -123.991214),
                    new Vector(48.3572808181819, -124.563542),
                    new Vector(48.3775578181819, -124.717172),
                    new Vector(48.2320008181818, -124.705211),
                    new Vector(48.1499928181819, -124.732769),
                    new Vector(47.873737818182, -124.606679),
                    new Vector(47.8082538181819, -124.484036),
                    new Vector(47.6387658181818, -124.373606),
                    new Vector(47.5269048181819, -124.349081),
                    new Vector(47.5273368181819, -124.051109),
                    new Vector(47.51354881818191, -124.050299),
                    new Vector(47.51275681818189, -123.502019),
                    new Vector(47.6054928181818, -123.500516),
                    new Vector(47.60547481818189, -122.982755)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(47.5159338181819, -123.026333),
                    new Vector(47.5180308181818, -122.803457),
                    new Vector(47.39888881818191, -122.799551),
                    new Vector(47.3985828181818, -122.637434),
                    new Vector(47.3985558181819, -122.628758),
                    new Vector(47.3983668181818, -122.558459),
                    new Vector(47.5072218181819, -122.504468),
                    new Vector(47.52273781818201, -122.5427),
                    new Vector(47.5835058181819, -122.555273),
                    new Vector(47.5711938181819, -122.586467),
                    new Vector(47.69696881818191, -122.621504),
                    new Vector(47.75498281818191, -122.473589),
                    new Vector(47.90946781818191, -122.531891),
                    new Vector(47.9361888181817, -122.613215),
                    new Vector(47.8500048181818, -122.611163),
                    new Vector(47.75689981818189, -122.723051),
                    new Vector(47.66068981818179, -122.752949),
                    new Vector(47.6146098181819, -122.916974),
                    new Vector(47.5159338181819, -123.026333)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(48.2766498181818, -122.733194),
                    new Vector(48.218815818182, -122.768771),
                    new Vector(48.18117781818191, -122.695547),
                    new Vector(48.0314268181818, -122.608625),
                    new Vector(47.9675268181819, -122.544968),
                    new Vector(47.9875068181818, -122.471618),
                    new Vector(47.9180538181819, -122.442791),
                    new Vector(47.9045448181819, -122.386964),
                    new Vector(47.9638818181818, -122.355401),
                    new Vector(48.0321468181817, -122.379989),
                    new Vector(48.0940758181819, -122.496206),
                    new Vector(48.0768588181818, -122.546201),
                    new Vector(48.2063148181818, -122.610929),
                    new Vector(48.2254218181819, -122.732033),
                    new Vector(48.29635081818189, -122.623511),
                    new Vector(48.2835078181819, -122.528642),
                    new Vector(48.3210468181819, -122.525753),
                    new Vector(48.4047918181818, -122.604386),
                    new Vector(48.3967818181818, -122.665613),
                    new Vector(48.2766498181818, -122.733194)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(48.4437888181818, -122.967986),
                    new Vector(48.4896078181818, -123.018881),
                    new Vector(48.5133678181818, -123.022274),
                    new Vector(48.5269398181817, -122.967986),
                    new Vector(48.53371681818191, -123.008702),
                    new Vector(48.5574858181819, -123.012095),
                    new Vector(48.60838081818181, -123.103715),
                    new Vector(48.6236448181817, -123.141065),
                    new Vector(48.5625618181818, -123.169901),
                    new Vector(48.5218458181818, -123.159713),
                    new Vector(48.4794198181819, -123.095237),
                    new Vector(48.4437888181818, -122.967986)
                })
            }
        };
    }
}