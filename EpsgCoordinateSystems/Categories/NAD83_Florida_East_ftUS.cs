using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Florida_East_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2236;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Florida East";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Florida East (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,24.33333333333333],PARAMETER[central_meridian,-81],PARAMETER[scale_factor,0.999941177],PARAMETER[false_easting,656166.667],PARAMETER[false_northing,0],AUTHORITY[EPSG,2236],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Florida East (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,24.33333333333333],PARAMETER[central_meridian,-81],PARAMETER[scale_factor,0.999941177],PARAMETER[false_easting,656166.667],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(27.5556618181819, -80.3573779999999),
                    new Vector(27.7035858181819, -80.40137),
                    new Vector(27.8457138181818, -80.48185700000001),
                    new Vector(27.8257068181818, -80.50935200000001),
                    new Vector(27.8701848181819, -80.492243),
                    new Vector(28.3989888181819, -80.747195),
                    new Vector(28.7857008181819, -80.8507129999999),
                    new Vector(28.786177818182, -80.83210099999999),
                    new Vector(28.7363358181818, -80.76241400000001),
                    new Vector(28.785187818182, -80.785661),
                    new Vector(29.3518008181819, -81.09705200000001),
                    new Vector(29.4302358181819, -81.109886),
                    new Vector(29.6690238181818, -81.233762),
                    new Vector(29.7379458181818, -81.243779),
                    new Vector(29.8292328181818, -81.31649),
                    new Vector(29.9130588181819, -81.302756),
                    new Vector(30.2467788181819, -81.432761),
                    new Vector(30.3571908181818, -81.443264),
                    new Vector(30.38053681818189, -81.48080299999999),
                    new Vector(30.4547598181819, -81.45752899999999),
                    new Vector(30.5562078181819, -81.518117),
                    new Vector(30.5986068181819, -81.498785),
                    new Vector(30.7214568181819, -81.528593),
                    new Vector(30.7065798181818, -81.53659399999999),
                    new Vector(30.724894818182, -81.601169),
                    new Vector(30.7163178181819, -81.604769),
                    new Vector(30.7317708181819, -81.62797999999999),
                    new Vector(30.7290798181818, -81.64247),
                    new Vector(30.7453698181819, -81.716774),
                    new Vector(30.7638918181818, -81.7366729999999),
                    new Vector(30.7696248181819, -81.757706),
                    new Vector(30.7615788181819, -81.77670500000001),
                    new Vector(30.7880838181819, -81.803201),
                    new Vector(30.7990818181818, -81.872996),
                    new Vector(30.8283048181819, -81.899141),
                    new Vector(30.8134728181819, -81.90752000000001),
                    new Vector(30.8242458181819, -81.943808),
                    new Vector(30.8204298181819, -81.953024),
                    new Vector(30.7960128181819, -81.961556),
                    new Vector(30.7783548181819, -81.981482),
                    new Vector(30.7913148181819, -82.01553800000001),
                    new Vector(30.7642518181819, -82.012964),
                    new Vector(30.75753781818189, -82.0318819999999),
                    new Vector(30.6509058181819, -82.044905),
                    new Vector(30.5986878181819, -82.0136569999999),
                    new Vector(30.5709948181818, -82.00579999999989),
                    new Vector(30.4777188181819, -82.022513),
                    new Vector(30.442879818182, -82.035122),
                    new Vector(30.4340688181818, -82.046102),
                    new Vector(30.3788988181819, -82.038353),
                    new Vector(30.3637878181819, -82.052762),
                    new Vector(30.2702958181819, -82.04926999999989),
                    new Vector(30.1892148181818, -82.04792),
                    new Vector(30.1397058181819, -82.0462909999999),
                    new Vector(29.7236178181818, -82.0436629999999),
                    new Vector(29.4776748181818, -82.052312),
                    new Vector(29.5121988181818, -81.970664),
                    new Vector(29.5142418181819, -81.934916),
                    new Vector(29.5200738181818, -81.930992),
                    new Vector(29.5130178181819, -81.897746),
                    new Vector(29.5244568181819, -81.883094),
                    new Vector(29.5205958181818, -81.863843),
                    new Vector(29.52817381818179, -81.843593),
                    new Vector(29.48716081818189, -81.838049),
                    new Vector(29.4837048181819, -81.776876),
                    new Vector(29.4284988181819, -81.77201599999999),
                    new Vector(29.4265188181819, -81.741191),
                    new Vector(29.3731488181818, -81.736799),
                    new Vector(29.3692428181818, -81.67782200000001),
                    new Vector(29.3577588181819, -81.664214),
                    new Vector(29.3392278181819, -81.65930899999999),
                    new Vector(29.3366268181817, -81.676697),
                    new Vector(29.3260968181818, -81.677183),
                    new Vector(29.3103378181819, -81.672674),
                    new Vector(29.28359881818181, -81.643568),
                    new Vector(29.0516238181818, -81.63914),
                    new Vector(29.05185781818181, -81.658427),
                    new Vector(28.9580238181819, -81.654404),
                    new Vector(28.9571778181819, -81.950828),
                    new Vector(28.34280181818181, -81.953384),
                    new Vector(28.3418838181819, -81.85776799999999),
                    new Vector(28.3588848181819, -81.85702999999999),
                    new Vector(28.3589208181818, -81.791348),
                    new Vector(28.3408488181819, -81.78747799999989),
                    new Vector(28.3436658181819, -81.65912),
                    new Vector(28.2604158181818, -81.659795),
                    new Vector(28.2583188181818, -81.564305),
                    new Vector(28.1875788181819, -81.518045),
                    new Vector(28.1405628181818, -81.5161279999999),
                    new Vector(28.1376918181819, -81.4522819999999),
                    new Vector(28.080532818182, -81.450383),
                    new Vector(28.0811088181818, -81.34569500000001),
                    new Vector(28.0522188181819, -81.348647),
                    new Vector(28.0174878181818, -81.37920200000001),
                    new Vector(28.039960818182, -81.4126279999999),
                    new Vector(28.0414908181819, -81.4285399999999),
                    new Vector(28.0537578181819, -81.43619),
                    new Vector(28.0518498181819, -81.45844699999989),
                    new Vector(28.0454868181819, -81.46080499999999),
                    new Vector(28.0321398181818, -81.43672100000001),
                    new Vector(28.0032948181819, -81.41697499999999),
                    new Vector(27.999343818182, -81.386267),
                    new Vector(27.8922258181819, -81.3086059999999),
                    new Vector(27.8613738181818, -81.297275),
                    new Vector(27.8437338181819, -81.270887),
                    new Vector(27.8439048181819, -81.240548),
                    new Vector(27.8229978181819, -81.213314),
                    new Vector(27.7839648181819, -81.193703),
                    new Vector(27.7670718181819, -81.1750279999999),
                    new Vector(27.7327098181818, -81.168566),
                    new Vector(27.7205508181819, -81.153266),
                    new Vector(27.6830478181819, -81.14900900000001),
                    new Vector(27.6653538181819, -81.133493),
                    new Vector(27.6433848181818, -81.137192),
                    new Vector(27.6444468181819, -81.563405),
                    new Vector(27.339580818182, -81.561065),
                    new Vector(27.0309438181818, -81.56347700000001),
                    new Vector(26.7671628181818, -81.561785),
                    new Vector(26.5135158181819, -81.564701),
                    new Vector(26.4220398181819, -81.566816),
                    new Vector(26.4239748181819, -81.655736),
                    new Vector(26.3176488181819, -81.6574099999999),
                    new Vector(26.3183598181819, -81.817475),
                    new Vector(26.3304108181817, -81.81797899999999),
                    new Vector(26.3322018181818, -81.84935299999999),
                    new Vector(26.2844658181818, -81.813857),
                    new Vector(26.1111618181819, -81.794714),
                    new Vector(26.0001738181817, -81.70569500000001),
                    new Vector(25.9235838181818, -81.7182949999999),
                    new Vector(25.9146558181819, -81.530744),
                    new Vector(25.8031008181819, -81.256208),
                    new Vector(25.710418818182, -81.199949),
                    new Vector(25.6810968181818, -81.2583769999999),
                    new Vector(25.3968228181819, -81.14333000000001),
                    new Vector(25.3224648181817, -80.974283),
                    new Vector(25.2467298181819, -80.91527000000001),
                    new Vector(25.2025398181818, -80.951027),
                    new Vector(25.2144288181818, -81.011561),
                    new Vector(25.3207638181819, -81.140576),
                    new Vector(25.2688788181818, -81.183785),
                    new Vector(25.1646948181819, -81.14822599999999),
                    new Vector(25.1341938181819, -81.119021),
                    new Vector(25.1305038181818, -80.975876),
                    new Vector(25.1856288181819, -80.856797),
                    new Vector(25.1523018181818, -80.693825),
                    new Vector(25.2123138181818, -80.551877),
                    new Vector(25.19221681818181, -80.42081),
                    new Vector(25.2498978181818, -80.416814),
                    new Vector(25.4011968181818, -80.301974),
                    new Vector(25.4900178181817, -80.32999100000001),
                    new Vector(25.6137588181817, -80.301452),
                    new Vector(25.7600358181819, -80.193101),
                    new Vector(25.9775388181819, -80.127779),
                    new Vector(26.32637881818191, -80.084687),
                    new Vector(26.7971958181818, -80.05091),
                    new Vector(26.9738388181818, -80.11461199999999),
                    new Vector(26.9740458181819, -80.090366),
                    new Vector(27.1090728181819, -80.1479659999999),
                    new Vector(27.2028438181819, -80.221271),
                    new Vector(27.2128518181818, -80.290418),
                    new Vector(27.2482668181818, -80.326787),
                    new Vector(27.2413368181818, -80.289635),
                    new Vector(27.2150658181819, -80.223989),
                    new Vector(27.1856808181819, -80.190095),
                    new Vector(27.2646468181819, -80.23963999999999),
                    new Vector(27.5556618181819, -80.3573779999999)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(28.7843598181818, -80.72590099999999),
                    new Vector(28.6573428181819, -80.64120200000001),
                    new Vector(28.7368848181818, -80.754062),
                    new Vector(28.7066178181819, -80.73499099999999),
                    new Vector(28.6877178181819, -80.78593100000001),
                    new Vector(28.6189668181818, -80.7804409999999),
                    new Vector(28.5883578181818, -80.691881),
                    new Vector(28.6186518181819, -80.660048),
                    new Vector(28.6039188181818, -80.599127),
                    new Vector(28.5486588181819, -80.57744599999999),
                    new Vector(28.41265981818182, -80.621627),
                    new Vector(28.4092668181819, -80.58765200000001),
                    new Vector(28.4634648181819, -80.525948),
                    new Vector(28.5901578181819, -80.57968700000001),
                    new Vector(28.7843598181818, -80.72590099999999)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(28.5817608181818, -80.68862300000001),
                    new Vector(28.38539881818181, -80.721041),
                    new Vector(28.1449458181819, -80.6055709999999),
                    new Vector(28.3018428181818, -80.667113),
                    new Vector(28.427410818182, -80.66273),
                    new Vector(28.5735618181818, -80.609189),
                    new Vector(28.6008948181819, -80.65379299999999),
                    new Vector(28.5817608181818, -80.68862300000001)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(25.354936818182, -80.249459),
                    new Vector(25.2964998181819, -80.361599),
                    new Vector(25.2679788181818, -80.330297),
                    new Vector(25.2115398181818, -80.353067),
                    new Vector(24.9563718181819, -80.5878139999999),
                    new Vector(25.1582328181819, -80.35566799999999),
                    new Vector(25.354936818182, -80.249459)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(28.7888418181819, -80.735837),
                    new Vector(28.9916298181819, -80.86244000000001),
                    new Vector(29.0615058181818, -80.8990969999999),
                    new Vector(29.07181981818181, -80.916287),
                    new Vector(29.0133918181818, -80.89107799999999),
                    new Vector(28.8953928181818, -80.8171789999999),
                    new Vector(28.8220608181819, -80.763323),
                    new Vector(28.7888418181819, -80.735837)
                })
            }
        };
    }
}