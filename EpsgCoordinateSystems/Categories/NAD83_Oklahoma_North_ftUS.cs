using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Oklahoma_North_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2267;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Oklahoma North";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Oklahoma North (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,36.76666666666667],PARAMETER[standard_parallel_2,35.56666666666667],PARAMETER[latitude_of_origin,35],PARAMETER[central_meridian,-98],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],AUTHORITY[EPSG,2267],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Oklahoma North (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,36.76666666666667],PARAMETER[standard_parallel_2,35.56666666666667],PARAMETER[latitude_of_origin,35],PARAMETER[central_meridian,-98],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-100.000391, 35.618851818182, 0),
                    new Vector(-99.994748, 35.4246138181819, 0),
                    new Vector(-99.573161, 35.427025818182, 0),
                    new Vector(-99.57384499999999, 35.5073598181818, 0),
                    new Vector(-99.36086, 35.5063968181819, 0),
                    new Vector(-99.35834899999999, 35.4700818181819, 0),
                    new Vector(-98.61918799999999, 35.4673908181819, 0),
                    new Vector(-98.619872, 35.5545378181818, 0),
                    new Vector(-98.30665399999999, 35.5545558181819, 0),
                    new Vector(-98.308823, 35.3798388181819, 0),
                    new Vector(-98.08830500000001, 35.3778408181818, 0),
                    new Vector(-98.022335, 35.3767428181819, 0),
                    new Vector(-97.97726299999999, 35.3532798181819, 0),
                    new Vector(-97.94695100000001, 35.3691018181819, 0),
                    new Vector(-97.91071700000002, 35.3534778181818, 0),
                    new Vector(-97.8801169999999, 35.3588418181819, 0),
                    new Vector(-97.85014700000001, 35.3415078181819, 0),
                    new Vector(-97.821518, 35.3368908181818, 0),
                    new Vector(-97.785662, 35.3484828181819, 0),
                    new Vector(-97.734875, 35.3307168181818, 0),
                    new Vector(-97.69506800000001, 35.3422098181819, 0),
                    new Vector(-97.669301, 35.3362518181819, 0),
                    new Vector(-97.66738400000001, 35.3807118181819, 0),
                    new Vector(-97.14076700000001, 35.385940818182, 0),
                    new Vector(-97.14100999999988, 35.4699468181819, 0),
                    new Vector(-96.61675099999998, 35.4688218181819, 0),
                    new Vector(-96.61984699999999, 35.3989728181818, 0),
                    new Vector(-96.59009299999998, 35.4081078181818, 0),
                    new Vector(-96.540125, 35.3893878181819, 0),
                    new Vector(-96.5367229999999, 35.4020058181819, 0),
                    new Vector(-96.56637799999999, 35.4455748181819, 0),
                    new Vector(-96.55080800000002, 35.4528378181819, 0),
                    new Vector(-96.53007199999999, 35.4490578181818, 0),
                    new Vector(-96.5240239999999, 35.4329748181819, 0),
                    new Vector(-96.498212, 35.4294918181819, 0),
                    new Vector(-96.472031, 35.4582378181819, 0),
                    new Vector(-96.43803799999999, 35.4603978181818, 0),
                    new Vector(-96.436751, 35.2941138181818, 0),
                    new Vector(-95.977301, 35.2929798181819, 0),
                    new Vector(-95.97756200000001, 35.3843118181818, 0),
                    new Vector(-95.87875999999999, 35.3845368181818, 0),
                    new Vector(-95.875151, 35.4720888181819, 0),
                    new Vector(-95.82593900000001, 35.4730878181818, 0),
                    new Vector(-95.82239300000002, 35.5583628181819, 0),
                    new Vector(-95.70700399999998, 35.5574088181819, 0),
                    new Vector(-95.340479, 35.5630698181819, 0),
                    new Vector(-95.339795, 35.3058588181819, 0),
                    new Vector(-95.297837, 35.3000988181819, 0),
                    new Vector(-95.25219800000001, 35.2719108181818, 0),
                    new Vector(-95.21892500000001, 35.2719288181819, 0),
                    new Vector(-95.17238599999999, 35.3391048181819, 0),
                    new Vector(-95.1388249999999, 35.3609118181819, 0),
                    new Vector(-95.143514, 35.3847348181818, 0),
                    new Vector(-95.105795, 35.3918088181818, 0),
                    new Vector(-95.083187, 35.4358728181819, 0),
                    new Vector(-95.086004, 35.4537108181818, 0),
                    new Vector(-95.07200899999989, 35.4690288181818, 0),
                    new Vector(-95.01373400000001, 35.4434058181819, 0),
                    new Vector(-94.9712, 35.4370518181819, 0),
                    new Vector(-94.959203, 35.4133728181819, 0),
                    new Vector(-94.92390499999999, 35.4086748181818, 0),
                    new Vector(-94.90760599999999, 35.3988828181818, 0),
                    new Vector(-94.900352, 35.3721978181819, 0),
                    new Vector(-94.85644099999999, 35.3784798181819, 0),
                    new Vector(-94.80735499999999, 35.3445048181819, 0),
                    new Vector(-94.76342600000001, 35.3593818181818, 0),
                    new Vector(-94.70039899999999, 35.3479248181819, 0),
                    new Vector(-94.664759, 35.3085948181818, 0),
                    new Vector(-94.669466, 35.2815228181819, 0),
                    new Vector(-94.63593200000001, 35.2849968181819, 0),
                    new Vector(-94.63183700000002, 35.3111868181819, 0),
                    new Vector(-94.601822, 35.3366388181819, 0),
                    new Vector(-94.50409999999989, 35.3057508181819, 0),
                    new Vector(-94.503767, 35.3575638181819, 0),
                    new Vector(-94.492949, 35.3666088181819, 0),
                    new Vector(-94.45036100000002, 35.3773458181819, 0),
                    new Vector(-94.42855400000001, 35.4005478181819, 0),
                    new Vector(-94.46847799999999, 35.6410908181819, 0),
                    new Vector(-94.485938, 35.7603048181817, 0),
                    new Vector(-94.542422, 36.1068408181819, 0),
                    new Vector(-94.553105, 36.1645308181818, 0),
                    new Vector(-94.607456, 36.4787928181818, 0),
                    new Vector(-94.6172569999999, 36.4894218181819, 0),
                    new Vector(-94.621073, 36.6705468181819, 0),
                    new Vector(-94.621685, 36.7636068181819, 0),
                    new Vector(-94.62038, 36.997048818182, 0),
                    new Vector(-95.0327419999999, 37.0007838181819, 0),
                    new Vector(-95.07192799999999, 37.0014858181819, 0),
                    new Vector(-95.40662, 37.0006218181818, 0),
                    new Vector(-95.526014, 37.0010178181819, 0),
                    new Vector(-95.78574500000001, 36.9981198181819, 0),
                    new Vector(-95.95795999999999, 37.0000818181819, 0),
                    new Vector(-96.006056, 36.9983358181819, 0),
                    new Vector(-96.51919099999999, 37.0005858181819, 0),
                    new Vector(-96.74870000000001, 37.0001628181819, 0),
                    new Vector(-97.13768899999998, 36.9998118181818, 0),
                    new Vector(-97.465406, 36.9964638181819, 0),
                    new Vector(-97.80425600000001, 36.9985608181818, 0),
                    new Vector(-98.104523, 36.9986688181819, 0),
                    new Vector(-98.347145, 36.9990648181818, 0),
                    new Vector(-98.540222, 36.9983718181818, 0),
                    new Vector(-98.99951899999999, 36.9980748181819, 0),
                    new Vector(-99.43747699999999, 36.9945558181819, 0),
                    new Vector(-99.54464000000002, 36.9954648181818, 0),
                    new Vector(-99.99926600000001, 36.9954198181818, 0),
                    new Vector(-100.088573, 36.9976518181817, 0),
                    new Vector(-100.634243, 36.9978408181819, 0),
                    new Vector(-100.950593, 36.9966618181819, 0),
                    new Vector(-101.071598, 36.9974628181819, 0),
                    new Vector(-101.553674, 36.9966888181818, 0),
                    new Vector(-102.024518, 36.9888768181819, 0),
                    new Vector(-102.037208, 36.9889938181818, 0),
                    new Vector(-102.997706, 36.9985248181819, 0),
                    new Vector(-102.9974, 36.4923738181818, 0),
                    new Vector(-102.165674, 36.4902408181819, 0),
                    new Vector(-102.034652, 36.4929858181818, 0),
                    new Vector(-101.62076, 36.4920228181819, 0),
                    new Vector(-101.090102, 36.4880538181819, 0),
                    new Vector(-100.957343, 36.4896378181819, 0),
                    new Vector(-100.549841, 36.4894848181818, 0),
                    new Vector(-100.007276, 36.4939128181819, 0),
                    new Vector(-100.001543, 36.4925538181819, 0),
                    new Vector(-99.997556, 36.0575928181819, 0),
                    new Vector(-99.99812300000002, 35.8838388181819, 0),
                    new Vector(-100.000391, 35.618851818182, 0)
                })
            }
        };
    }
}