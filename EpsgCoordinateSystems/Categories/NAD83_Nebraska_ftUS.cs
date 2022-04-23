using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Nebraska_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 26852;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Nebraska";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Nebraska (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,43],PARAMETER[standard_parallel_2,40],PARAMETER[latitude_of_origin,39.83333333333334],PARAMETER[central_meridian,-100],PARAMETER[false_easting,1640416.6667],PARAMETER[false_northing,0],AUTHORITY[EPSG,26852],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Nebraska (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,43],PARAMETER[standard_parallel_2,40],PARAMETER[latitude_of_origin,39.83333333333334],PARAMETER[central_meridian,-100],PARAMETER[false_easting,1640416.6667],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-101.407388, 40.0009968181819, 0),
                    new Vector(-101.322149, 40.0018158181818, 0),
                    new Vector(-100.754861, 40.0001958181819, 0),
                    new Vector(-100.735043, 39.9991698181819, 0),
                    new Vector(-100.19111, 40.0005828181819, 0),
                    new Vector(-100.180913, 40.0004838181819, 0),
                    new Vector(-99.627863, 40.0029948181818, 0),
                    new Vector(-99.178196, 39.9995838181819, 0),
                    new Vector(-99.064742, 39.9983328181819, 0),
                    new Vector(-98.720636, 39.9984678181819, 0),
                    new Vector(-98.50448299999999, 39.9971268181818, 0),
                    new Vector(-98.26416500000001, 39.998440818182, 0),
                    new Vector(-97.92959, 39.9984588181819, 0),
                    new Vector(-97.81659500000002, 39.9997278181818, 0),
                    new Vector(-97.361906, 39.9973788181819, 0),
                    new Vector(-96.908288, 39.9961548181818, 0),
                    new Vector(-96.80142199999999, 39.9944718181818, 0),
                    new Vector(-96.45404000000001, 39.9941748181819, 0),
                    new Vector(-96.24059599999991, 39.9944988181817, 0),
                    new Vector(-96.00125900000002, 39.9951648181818, 0),
                    new Vector(-95.78069600000001, 39.9934908181818, 0),
                    new Vector(-95.3296969999999, 39.9925908181818, 0),
                    new Vector(-95.3087, 39.9994128181819, 0),
                    new Vector(-95.34506000000002, 40.0249728181818, 0),
                    new Vector(-95.371241, 40.0287528181819, 0),
                    new Vector(-95.39053699999998, 40.0437558181818, 0),
                    new Vector(-95.413766, 40.0481118181818, 0),
                    new Vector(-95.40378500000001, 40.0803858181819, 0),
                    new Vector(-95.38454299999998, 40.0953618181819, 0),
                    new Vector(-95.392805, 40.1154138181819, 0),
                    new Vector(-95.42246900000001, 40.1317488181818, 0),
                    new Vector(-95.46095300000002, 40.1739948181819, 0),
                    new Vector(-95.466632, 40.2132528181819, 0),
                    new Vector(-95.47682, 40.2268518181817, 0),
                    new Vector(-95.54713700000001, 40.2662178181818, 0),
                    new Vector(-95.595539, 40.3097688181819, 0),
                    new Vector(-95.64682999999999, 40.3091118181819, 0),
                    new Vector(-95.645552, 40.3223418181819, 0),
                    new Vector(-95.61794, 40.3314138181819, 0),
                    new Vector(-95.61620299999989, 40.3464978181818, 0),
                    new Vector(-95.634185, 40.3588008181817, 0),
                    new Vector(-95.6368219999999, 40.3963938181818, 0),
                    new Vector(-95.695367, 40.4853408181819, 0),
                    new Vector(-95.68497199999999, 40.5122058181819, 0),
                    new Vector(-95.65806200000002, 40.5303408181818, 0),
                    new Vector(-95.66294900000001, 40.5587268181819, 0),
                    new Vector(-95.675693, 40.5658368181819, 0),
                    new Vector(-95.687411, 40.5611748181818, 0),
                    new Vector(-95.692064, 40.5241308181818, 0),
                    new Vector(-95.737037, 40.5323748181818, 0),
                    new Vector(-95.763407, 40.5497088181818, 0),
                    new Vector(-95.767484, 40.5890478181819, 0),
                    new Vector(-95.757548, 40.6208988181819, 0),
                    new Vector(-95.76799699999999, 40.643119818182, 0),
                    new Vector(-95.87661799999999, 40.7304378181819, 0),
                    new Vector(-95.85178700000002, 40.7926008181818, 0),
                    new Vector(-95.84643199999991, 40.8483378181817, 0),
                    new Vector(-95.834399, 40.8702978181819, 0),
                    new Vector(-95.836541, 40.9011048181818, 0),
                    new Vector(-95.837603, 40.9742568181819, 0),
                    new Vector(-95.860904, 41.0026518181818, 0),
                    new Vector(-95.85953599999999, 41.0349978181819, 0),
                    new Vector(-95.878805, 41.0658768181819, 0),
                    new Vector(-95.858276, 41.1091938181818, 0),
                    new Vector(-95.87668099999999, 41.1642018181818, 0),
                    new Vector(-95.85979699999999, 41.1668658181818, 0),
                    new Vector(-95.85920299999998, 41.1805368181819, 0),
                    new Vector(-95.916101, 41.1940638181819, 0),
                    new Vector(-95.922257, 41.2078518181819, 0),
                    new Vector(-95.91098, 41.2252488181818, 0),
                    new Vector(-95.93023100000001, 41.3020548181818, 0),
                    new Vector(-95.911196, 41.3084718181818, 0),
                    new Vector(-95.8975879999999, 41.2868628181818, 0),
                    new Vector(-95.88911, 41.3013888181818, 0),
                    new Vector(-95.94289399999998, 41.3400798181819, 0),
                    new Vector(-95.94005900000001, 41.3948088181818, 0),
                    new Vector(-95.9350639999999, 41.4623808181818, 0),
                    new Vector(-95.953181, 41.4723888181819, 0),
                    new Vector(-96.00690199999988, 41.4819558181819, 0),
                    new Vector(-96.013454, 41.4929898181819, 0),
                    new Vector(-95.99668699999999, 41.5115208181819, 0),
                    new Vector(-95.99396, 41.5280988181819, 0),
                    new Vector(-96.004589, 41.5366668181819, 0),
                    new Vector(-96.0501739999999, 41.5243368181818, 0),
                    new Vector(-96.0858319999999, 41.5375218181819, 0),
                    new Vector(-96.09193399999999, 41.5631448181819, 0),
                    new Vector(-96.08083700000002, 41.5759968181819, 0),
                    new Vector(-96.111311, 41.5990098181818, 0),
                    new Vector(-96.099305, 41.6546838181818, 0),
                    new Vector(-96.12026599999999, 41.6840868181819, 0),
                    new Vector(-96.122201, 41.6949048181819, 0),
                    new Vector(-96.085553, 41.7049938181819, 0),
                    new Vector(-96.099773, 41.7315618181819, 0),
                    new Vector(-96.09931400000001, 41.7529728181819, 0),
                    new Vector(-96.076418, 41.7914748181819, 0),
                    new Vector(-96.13562899999999, 41.8626198181818, 0),
                    new Vector(-96.15997400000002, 41.9041548181819, 0),
                    new Vector(-96.145871, 41.9249088181818, 0),
                    new Vector(-96.147329, 41.9662548181819, 0),
                    new Vector(-96.185219, 41.9806818181819, 0),
                    new Vector(-96.20284100000001, 41.996620818182, 0),
                    new Vector(-96.23608699999998, 42.0012558181818, 0),
                    new Vector(-96.238724, 42.0284358181819, 0),
                    new Vector(-96.26548099999998, 42.0489018181819, 0),
                    new Vector(-96.285128, 42.1234578181818, 0),
                    new Vector(-96.35216, 42.1681788181818, 0),
                    new Vector(-96.36350899999989, 42.2140428181818, 0),
                    new Vector(-96.33770599999998, 42.2295138181819, 0),
                    new Vector(-96.332657, 42.2603118181819, 0),
                    new Vector(-96.34288100000002, 42.2820828181819, 0),
                    new Vector(-96.368702, 42.2980308181819, 0),
                    new Vector(-96.38978, 42.3287928181819, 0),
                    new Vector(-96.42416900000001, 42.3492858181819, 0),
                    new Vector(-96.41176700000001, 42.3809208181819, 0),
                    new Vector(-96.41762599999998, 42.4147788181819, 0),
                    new Vector(-96.39788899999999, 42.4417878181818, 0),
                    new Vector(-96.39607100000002, 42.4674018181819, 0),
                    new Vector(-96.43938799999988, 42.4892358181819, 0),
                    new Vector(-96.494702, 42.4884618181818, 0),
                    new Vector(-96.54721699999999, 42.5205018181817, 0),
                    new Vector(-96.58475599999998, 42.5182878181819, 0),
                    new Vector(-96.605465, 42.5072358181819, 0),
                    new Vector(-96.62928800000002, 42.5226888181819, 0),
                    new Vector(-96.63667700000001, 42.550723818182, 0),
                    new Vector(-96.71406799999988, 42.6123018181818, 0),
                    new Vector(-96.71527399999989, 42.6219048181818, 0),
                    new Vector(-96.69460100000002, 42.6411648181818, 0),
                    new Vector(-96.699065, 42.6577158181818, 0),
                    new Vector(-96.722663, 42.6685878181818, 0),
                    new Vector(-96.79934299999999, 42.6700188181818, 0),
                    new Vector(-96.81044, 42.6813498181819, 0),
                    new Vector(-96.81013400000001, 42.7040838181818, 0),
                    new Vector(-96.90823399999989, 42.7316958181818, 0),
                    new Vector(-96.97077499999999, 42.7211478181818, 0),
                    new Vector(-96.97787599999991, 42.7273128181819, 0),
                    new Vector(-96.9700009999999, 42.7520628181818, 0),
                    new Vector(-96.979595, 42.7583088181818, 0),
                    new Vector(-97.0151359999999, 42.7595418181819, 0),
                    new Vector(-97.13047100000001, 42.7739238181819, 0),
                    new Vector(-97.16143099999999, 42.7986198181819, 0),
                    new Vector(-97.21184, 42.8125698181818, 0),
                    new Vector(-97.22444900000001, 42.8411988181819, 0),
                    new Vector(-97.24318700000001, 42.8518278181818, 0),
                    new Vector(-97.27145599999999, 42.8500188181819, 0),
                    new Vector(-97.31141600000001, 42.8617728181819, 0),
                    new Vector(-97.38931099999999, 42.8674338181818, 0),
                    new Vector(-97.457261, 42.8504418181819, 0),
                    new Vector(-97.483163, 42.8571558181818, 0),
                    new Vector(-97.50614, 42.8601348181818, 0),
                    new Vector(-97.570652, 42.8479938181819, 0),
                    new Vector(-97.63497499999988, 42.8612778181817, 0),
                    new Vector(-97.68575300000001, 42.8368338181818, 0),
                    new Vector(-97.72525400000001, 42.8580108181818, 0),
                    new Vector(-97.77218000000001, 42.8461668181819, 0),
                    new Vector(-97.79702900000001, 42.8495958181819, 0),
                    new Vector(-97.8186469999999, 42.8665878181818, 0),
                    new Vector(-97.88866699999998, 42.8558058181818, 0),
                    new Vector(-97.889945, 42.8312718181818, 0),
                    new Vector(-97.92947299999999, 42.7923288181818, 0),
                    new Vector(-97.96355599999998, 42.7736898181819, 0),
                    new Vector(-97.99514600000001, 42.7668048181819, 0),
                    new Vector(-98.033135, 42.7691898181819, 0),
                    new Vector(-98.12182099999998, 42.8083668181819, 0),
                    new Vector(-98.12311699999998, 42.8202288181819, 0),
                    new Vector(-98.1448699999999, 42.8357898181818, 0),
                    new Vector(-98.167829, 42.8395698181819, 0),
                    new Vector(-98.31033500000001, 42.8817888181819, 0),
                    new Vector(-98.391209, 42.9201378181818, 0),
                    new Vector(-98.45744899999988, 42.9371658181819, 0),
                    new Vector(-98.497652, 42.991777818182, 0),
                    new Vector(-99.25397599999998, 42.9923898181818, 0),
                    new Vector(-99.532787, 42.9923358181818, 0),
                    new Vector(-100.198148, 42.9910938181819, 0),
                    new Vector(-101.231735, 42.9868458181817, 0),
                    new Vector(-102.086699, 42.9898878181819, 0),
                    new Vector(-102.788384, 42.9952968181818, 0),
                    new Vector(-103.005869, 42.9993558181819, 0),
                    new Vector(-103.501454, 42.9986178181818, 0),
                    new Vector(-104.056196, 43.0030638181819, 0),
                    new Vector(-104.056223, 42.6146688181819, 0),
                    new Vector(-104.053505, 41.9998158181818, 0),
                    new Vector(-104.053622, 41.6982168181818, 0),
                    new Vector(-104.055503, 41.5642158181819, 0),
                    new Vector(-104.054009, 41.3880858181819, 0),
                    new Vector(-104.051705, 41.0032098181818, 0),
                    new Vector(-103.57232, 40.9996458181818, 0),
                    new Vector(-103.382951, 41.0003208181819, 0),
                    new Vector(-102.652277, 40.9981248181819, 0),
                    new Vector(-102.621254, 41.0002218181818, 0),
                    new Vector(-102.047738, 40.9980708181819, 0),
                    new Vector(-102.046991, 40.7431278181818, 0),
                    new Vector(-102.046028, 40.6973178181819, 0),
                    new Vector(-102.047621, 40.4310798181819, 0),
                    new Vector(-102.047549, 40.3426458181818, 0),
                    new Vector(-102.051536, 39.9989178181818, 0),
                    new Vector(-101.407388, 40.0009968181819, 0)
                })
            }
        };
    }
}