using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_Nebraska_ftUS : INad83UsFtCrs
    {
        private const int _srid = 26852;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Nebraska";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / Nebraska (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",43],PARAMETER[\"standard_parallel_2\",40],PARAMETER[\"latitude_of_origin\",39.83333333333334],PARAMETER[\"central_meridian\",-100],PARAMETER[\"false_easting\",1640416.6667],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"26852\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / Nebraska (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",43],PARAMETER[\"standard_parallel_2\",40],PARAMETER[\"latitude_of_origin\",39.83333333333334],PARAMETER[\"central_meridian\",-100],PARAMETER[\"false_easting\",1640416.6667],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(40.0009968181819, -101.407388),
                    new Vector(40.0018158181818, -101.322149),
                    new Vector(40.0001958181819, -100.754861),
                    new Vector(39.9991698181819, -100.735043),
                    new Vector(40.0005828181819, -100.19111),
                    new Vector(40.0004838181819, -100.180913),
                    new Vector(40.0029948181818, -99.627863),
                    new Vector(39.9995838181819, -99.178196),
                    new Vector(39.9983328181819, -99.064742),
                    new Vector(39.9984678181819, -98.720636),
                    new Vector(39.9971268181818, -98.50448299999999),
                    new Vector(39.998440818182, -98.26416500000001),
                    new Vector(39.9984588181819, -97.92959),
                    new Vector(39.9997278181818, -97.81659500000002),
                    new Vector(39.9973788181819, -97.361906),
                    new Vector(39.9961548181818, -96.908288),
                    new Vector(39.9944718181818, -96.80142199999999),
                    new Vector(39.9941748181819, -96.45404000000001),
                    new Vector(39.9944988181817, -96.24059599999991),
                    new Vector(39.9951648181818, -96.00125900000002),
                    new Vector(39.9934908181818, -95.78069600000001),
                    new Vector(39.9925908181818, -95.3296969999999),
                    new Vector(39.9994128181819, -95.3087),
                    new Vector(40.0249728181818, -95.34506000000002),
                    new Vector(40.0287528181819, -95.371241),
                    new Vector(40.0437558181818, -95.39053699999998),
                    new Vector(40.0481118181818, -95.413766),
                    new Vector(40.0803858181819, -95.40378500000001),
                    new Vector(40.0953618181819, -95.38454299999998),
                    new Vector(40.1154138181819, -95.392805),
                    new Vector(40.1317488181818, -95.42246900000001),
                    new Vector(40.1739948181819, -95.46095300000002),
                    new Vector(40.2132528181819, -95.466632),
                    new Vector(40.2268518181817, -95.47682),
                    new Vector(40.2662178181818, -95.54713700000001),
                    new Vector(40.3097688181819, -95.595539),
                    new Vector(40.3091118181819, -95.64682999999999),
                    new Vector(40.3223418181819, -95.645552),
                    new Vector(40.3314138181819, -95.61794),
                    new Vector(40.3464978181818, -95.61620299999989),
                    new Vector(40.3588008181817, -95.634185),
                    new Vector(40.3963938181818, -95.6368219999999),
                    new Vector(40.4853408181819, -95.695367),
                    new Vector(40.5122058181819, -95.68497199999999),
                    new Vector(40.5303408181818, -95.65806200000002),
                    new Vector(40.5587268181819, -95.66294900000001),
                    new Vector(40.5658368181819, -95.675693),
                    new Vector(40.5611748181818, -95.687411),
                    new Vector(40.5241308181818, -95.692064),
                    new Vector(40.5323748181818, -95.737037),
                    new Vector(40.5497088181818, -95.763407),
                    new Vector(40.5890478181819, -95.767484),
                    new Vector(40.6208988181819, -95.757548),
                    new Vector(40.643119818182, -95.76799699999999),
                    new Vector(40.7304378181819, -95.87661799999999),
                    new Vector(40.7926008181818, -95.85178700000002),
                    new Vector(40.8483378181817, -95.84643199999991),
                    new Vector(40.8702978181819, -95.834399),
                    new Vector(40.9011048181818, -95.836541),
                    new Vector(40.9742568181819, -95.837603),
                    new Vector(41.0026518181818, -95.860904),
                    new Vector(41.0349978181819, -95.85953599999999),
                    new Vector(41.0658768181819, -95.878805),
                    new Vector(41.1091938181818, -95.858276),
                    new Vector(41.1642018181818, -95.87668099999999),
                    new Vector(41.1668658181818, -95.85979699999999),
                    new Vector(41.1805368181819, -95.85920299999998),
                    new Vector(41.1940638181819, -95.916101),
                    new Vector(41.2078518181819, -95.922257),
                    new Vector(41.2252488181818, -95.91098),
                    new Vector(41.3020548181818, -95.93023100000001),
                    new Vector(41.3084718181818, -95.911196),
                    new Vector(41.2868628181818, -95.8975879999999),
                    new Vector(41.3013888181818, -95.88911),
                    new Vector(41.3400798181819, -95.94289399999998),
                    new Vector(41.3948088181818, -95.94005900000001),
                    new Vector(41.4623808181818, -95.9350639999999),
                    new Vector(41.4723888181819, -95.953181),
                    new Vector(41.4819558181819, -96.00690199999988),
                    new Vector(41.4929898181819, -96.013454),
                    new Vector(41.5115208181819, -95.99668699999999),
                    new Vector(41.5280988181819, -95.99396),
                    new Vector(41.5366668181819, -96.004589),
                    new Vector(41.5243368181818, -96.0501739999999),
                    new Vector(41.5375218181819, -96.0858319999999),
                    new Vector(41.5631448181819, -96.09193399999999),
                    new Vector(41.5759968181819, -96.08083700000002),
                    new Vector(41.5990098181818, -96.111311),
                    new Vector(41.6546838181818, -96.099305),
                    new Vector(41.6840868181819, -96.12026599999999),
                    new Vector(41.6949048181819, -96.122201),
                    new Vector(41.7049938181819, -96.085553),
                    new Vector(41.7315618181819, -96.099773),
                    new Vector(41.7529728181819, -96.09931400000001),
                    new Vector(41.7914748181819, -96.076418),
                    new Vector(41.8626198181818, -96.13562899999999),
                    new Vector(41.9041548181819, -96.15997400000002),
                    new Vector(41.9249088181818, -96.145871),
                    new Vector(41.9662548181819, -96.147329),
                    new Vector(41.9806818181819, -96.185219),
                    new Vector(41.996620818182, -96.20284100000001),
                    new Vector(42.0012558181818, -96.23608699999998),
                    new Vector(42.0284358181819, -96.238724),
                    new Vector(42.0489018181819, -96.26548099999998),
                    new Vector(42.1234578181818, -96.285128),
                    new Vector(42.1681788181818, -96.35216),
                    new Vector(42.2140428181818, -96.36350899999989),
                    new Vector(42.2295138181819, -96.33770599999998),
                    new Vector(42.2603118181819, -96.332657),
                    new Vector(42.2820828181819, -96.34288100000002),
                    new Vector(42.2980308181819, -96.368702),
                    new Vector(42.3287928181819, -96.38978),
                    new Vector(42.3492858181819, -96.42416900000001),
                    new Vector(42.3809208181819, -96.41176700000001),
                    new Vector(42.4147788181819, -96.41762599999998),
                    new Vector(42.4417878181818, -96.39788899999999),
                    new Vector(42.4674018181819, -96.39607100000002),
                    new Vector(42.4892358181819, -96.43938799999988),
                    new Vector(42.4884618181818, -96.494702),
                    new Vector(42.5205018181817, -96.54721699999999),
                    new Vector(42.5182878181819, -96.58475599999998),
                    new Vector(42.5072358181819, -96.605465),
                    new Vector(42.5226888181819, -96.62928800000002),
                    new Vector(42.550723818182, -96.63667700000001),
                    new Vector(42.6123018181818, -96.71406799999988),
                    new Vector(42.6219048181818, -96.71527399999989),
                    new Vector(42.6411648181818, -96.69460100000002),
                    new Vector(42.6577158181818, -96.699065),
                    new Vector(42.6685878181818, -96.722663),
                    new Vector(42.6700188181818, -96.79934299999999),
                    new Vector(42.6813498181819, -96.81044),
                    new Vector(42.7040838181818, -96.81013400000001),
                    new Vector(42.7316958181818, -96.90823399999989),
                    new Vector(42.7211478181818, -96.97077499999999),
                    new Vector(42.7273128181819, -96.97787599999991),
                    new Vector(42.7520628181818, -96.9700009999999),
                    new Vector(42.7583088181818, -96.979595),
                    new Vector(42.7595418181819, -97.0151359999999),
                    new Vector(42.7739238181819, -97.13047100000001),
                    new Vector(42.7986198181819, -97.16143099999999),
                    new Vector(42.8125698181818, -97.21184),
                    new Vector(42.8411988181819, -97.22444900000001),
                    new Vector(42.8518278181818, -97.24318700000001),
                    new Vector(42.8500188181819, -97.27145599999999),
                    new Vector(42.8617728181819, -97.31141600000001),
                    new Vector(42.8674338181818, -97.38931099999999),
                    new Vector(42.8504418181819, -97.457261),
                    new Vector(42.8571558181818, -97.483163),
                    new Vector(42.8601348181818, -97.50614),
                    new Vector(42.8479938181819, -97.570652),
                    new Vector(42.8612778181817, -97.63497499999988),
                    new Vector(42.8368338181818, -97.68575300000001),
                    new Vector(42.8580108181818, -97.72525400000001),
                    new Vector(42.8461668181819, -97.77218000000001),
                    new Vector(42.8495958181819, -97.79702900000001),
                    new Vector(42.8665878181818, -97.8186469999999),
                    new Vector(42.8558058181818, -97.88866699999998),
                    new Vector(42.8312718181818, -97.889945),
                    new Vector(42.7923288181818, -97.92947299999999),
                    new Vector(42.7736898181819, -97.96355599999998),
                    new Vector(42.7668048181819, -97.99514600000001),
                    new Vector(42.7691898181819, -98.033135),
                    new Vector(42.8083668181819, -98.12182099999998),
                    new Vector(42.8202288181819, -98.12311699999998),
                    new Vector(42.8357898181818, -98.1448699999999),
                    new Vector(42.8395698181819, -98.167829),
                    new Vector(42.8817888181819, -98.31033500000001),
                    new Vector(42.9201378181818, -98.391209),
                    new Vector(42.9371658181819, -98.45744899999988),
                    new Vector(42.991777818182, -98.497652),
                    new Vector(42.9923898181818, -99.25397599999998),
                    new Vector(42.9923358181818, -99.532787),
                    new Vector(42.9910938181819, -100.198148),
                    new Vector(42.9868458181817, -101.231735),
                    new Vector(42.9898878181819, -102.086699),
                    new Vector(42.9952968181818, -102.788384),
                    new Vector(42.9993558181819, -103.005869),
                    new Vector(42.9986178181818, -103.501454),
                    new Vector(43.0030638181819, -104.056196),
                    new Vector(42.6146688181819, -104.056223),
                    new Vector(41.9998158181818, -104.053505),
                    new Vector(41.6982168181818, -104.053622),
                    new Vector(41.5642158181819, -104.055503),
                    new Vector(41.3880858181819, -104.054009),
                    new Vector(41.0032098181818, -104.051705),
                    new Vector(40.9996458181818, -103.57232),
                    new Vector(41.0003208181819, -103.382951),
                    new Vector(40.9981248181819, -102.652277),
                    new Vector(41.0002218181818, -102.621254),
                    new Vector(40.9980708181819, -102.047738),
                    new Vector(40.7431278181818, -102.046991),
                    new Vector(40.6973178181819, -102.046028),
                    new Vector(40.4310798181819, -102.047621),
                    new Vector(40.3426458181818, -102.047549),
                    new Vector(39.9989178181818, -102.051536),
                    new Vector(40.0009968181819, -101.407388)
                })
            }
        };

        public BoundingBox BoundingBox => CalculateBoundingBox();

        private BoundingBox CalculateBoundingBox()
        {
            foreach (var linearRing in Wgs84Boundaries) _boundingBox.Expand(linearRing.CalculateBounds());

            return _boundingBox;
        }
    }
}