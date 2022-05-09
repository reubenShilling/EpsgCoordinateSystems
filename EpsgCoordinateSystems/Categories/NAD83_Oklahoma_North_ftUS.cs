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
    internal class NAD83_Oklahoma_North_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2267;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Oklahoma North";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Oklahoma North (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,36.76666666666667],PARAMETER[standard_parallel_2,35.56666666666667],PARAMETER[latitude_of_origin,35],PARAMETER[central_meridian,-98],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],AUTHORITY[EPSG,2267],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Oklahoma North (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,36.76666666666667],PARAMETER[standard_parallel_2,35.56666666666667],PARAMETER[latitude_of_origin,35],PARAMETER[central_meridian,-98],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(35.618851818182, -100.000391),
                    new Vector(35.4246138181819, -99.994748),
                    new Vector(35.427025818182, -99.573161),
                    new Vector(35.5073598181818, -99.57384499999999),
                    new Vector(35.5063968181819, -99.36086),
                    new Vector(35.4700818181819, -99.35834899999999),
                    new Vector(35.4673908181819, -98.61918799999999),
                    new Vector(35.5545378181818, -98.619872),
                    new Vector(35.5545558181819, -98.30665399999999),
                    new Vector(35.3798388181819, -98.308823),
                    new Vector(35.3778408181818, -98.08830500000001),
                    new Vector(35.3767428181819, -98.022335),
                    new Vector(35.3532798181819, -97.97726299999999),
                    new Vector(35.3691018181819, -97.94695100000001),
                    new Vector(35.3534778181818, -97.91071700000002),
                    new Vector(35.3588418181819, -97.8801169999999),
                    new Vector(35.3415078181819, -97.85014700000001),
                    new Vector(35.3368908181818, -97.821518),
                    new Vector(35.3484828181819, -97.785662),
                    new Vector(35.3307168181818, -97.734875),
                    new Vector(35.3422098181819, -97.69506800000001),
                    new Vector(35.3362518181819, -97.669301),
                    new Vector(35.3807118181819, -97.66738400000001),
                    new Vector(35.385940818182, -97.14076700000001),
                    new Vector(35.4699468181819, -97.14100999999988),
                    new Vector(35.4688218181819, -96.61675099999998),
                    new Vector(35.3989728181818, -96.61984699999999),
                    new Vector(35.4081078181818, -96.59009299999998),
                    new Vector(35.3893878181819, -96.540125),
                    new Vector(35.4020058181819, -96.5367229999999),
                    new Vector(35.4455748181819, -96.56637799999999),
                    new Vector(35.4528378181819, -96.55080800000002),
                    new Vector(35.4490578181818, -96.53007199999999),
                    new Vector(35.4329748181819, -96.5240239999999),
                    new Vector(35.4294918181819, -96.498212),
                    new Vector(35.4582378181819, -96.472031),
                    new Vector(35.4603978181818, -96.43803799999999),
                    new Vector(35.2941138181818, -96.436751),
                    new Vector(35.2929798181819, -95.977301),
                    new Vector(35.3843118181818, -95.97756200000001),
                    new Vector(35.3845368181818, -95.87875999999999),
                    new Vector(35.4720888181819, -95.875151),
                    new Vector(35.4730878181818, -95.82593900000001),
                    new Vector(35.5583628181819, -95.82239300000002),
                    new Vector(35.5574088181819, -95.70700399999998),
                    new Vector(35.5630698181819, -95.340479),
                    new Vector(35.3058588181819, -95.339795),
                    new Vector(35.3000988181819, -95.297837),
                    new Vector(35.2719108181818, -95.25219800000001),
                    new Vector(35.2719288181819, -95.21892500000001),
                    new Vector(35.3391048181819, -95.17238599999999),
                    new Vector(35.3609118181819, -95.1388249999999),
                    new Vector(35.3847348181818, -95.143514),
                    new Vector(35.3918088181818, -95.105795),
                    new Vector(35.4358728181819, -95.083187),
                    new Vector(35.4537108181818, -95.086004),
                    new Vector(35.4690288181818, -95.07200899999989),
                    new Vector(35.4434058181819, -95.01373400000001),
                    new Vector(35.4370518181819, -94.9712),
                    new Vector(35.4133728181819, -94.959203),
                    new Vector(35.4086748181818, -94.92390499999999),
                    new Vector(35.3988828181818, -94.90760599999999),
                    new Vector(35.3721978181819, -94.900352),
                    new Vector(35.3784798181819, -94.85644099999999),
                    new Vector(35.3445048181819, -94.80735499999999),
                    new Vector(35.3593818181818, -94.76342600000001),
                    new Vector(35.3479248181819, -94.70039899999999),
                    new Vector(35.3085948181818, -94.664759),
                    new Vector(35.2815228181819, -94.669466),
                    new Vector(35.2849968181819, -94.63593200000001),
                    new Vector(35.3111868181819, -94.63183700000002),
                    new Vector(35.3366388181819, -94.601822),
                    new Vector(35.3057508181819, -94.50409999999989),
                    new Vector(35.3575638181819, -94.503767),
                    new Vector(35.3666088181819, -94.492949),
                    new Vector(35.3773458181819, -94.45036100000002),
                    new Vector(35.4005478181819, -94.42855400000001),
                    new Vector(35.6410908181819, -94.46847799999999),
                    new Vector(35.7603048181817, -94.485938),
                    new Vector(36.1068408181819, -94.542422),
                    new Vector(36.1645308181818, -94.553105),
                    new Vector(36.4787928181818, -94.607456),
                    new Vector(36.4894218181819, -94.6172569999999),
                    new Vector(36.6705468181819, -94.621073),
                    new Vector(36.7636068181819, -94.621685),
                    new Vector(36.997048818182, -94.62038),
                    new Vector(37.0007838181819, -95.0327419999999),
                    new Vector(37.0014858181819, -95.07192799999999),
                    new Vector(37.0006218181818, -95.40662),
                    new Vector(37.0010178181819, -95.526014),
                    new Vector(36.9981198181819, -95.78574500000001),
                    new Vector(37.0000818181819, -95.95795999999999),
                    new Vector(36.9983358181819, -96.006056),
                    new Vector(37.0005858181819, -96.51919099999999),
                    new Vector(37.0001628181819, -96.74870000000001),
                    new Vector(36.9998118181818, -97.13768899999998),
                    new Vector(36.9964638181819, -97.465406),
                    new Vector(36.9985608181818, -97.80425600000001),
                    new Vector(36.9986688181819, -98.104523),
                    new Vector(36.9990648181818, -98.347145),
                    new Vector(36.9983718181818, -98.540222),
                    new Vector(36.9980748181819, -98.99951899999999),
                    new Vector(36.9945558181819, -99.43747699999999),
                    new Vector(36.9954648181818, -99.54464000000002),
                    new Vector(36.9954198181818, -99.99926600000001),
                    new Vector(36.9976518181817, -100.088573),
                    new Vector(36.9978408181819, -100.634243),
                    new Vector(36.9966618181819, -100.950593),
                    new Vector(36.9974628181819, -101.071598),
                    new Vector(36.9966888181818, -101.553674),
                    new Vector(36.9888768181819, -102.024518),
                    new Vector(36.9889938181818, -102.037208),
                    new Vector(36.9985248181819, -102.997706),
                    new Vector(36.4923738181818, -102.9974),
                    new Vector(36.4902408181819, -102.165674),
                    new Vector(36.4929858181818, -102.034652),
                    new Vector(36.4920228181819, -101.62076),
                    new Vector(36.4880538181819, -101.090102),
                    new Vector(36.4896378181819, -100.957343),
                    new Vector(36.4894848181818, -100.549841),
                    new Vector(36.4939128181819, -100.007276),
                    new Vector(36.4925538181819, -100.001543),
                    new Vector(36.0575928181819, -99.997556),
                    new Vector(35.8838388181819, -99.99812300000002),
                    new Vector(35.618851818182, -100.000391)
                })
            }
        };
    }
}