using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_South_Dakota_South_ftUS : INad83UsFtCrs
    {
        private const int _srid = 3455;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "South Dakota South";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / South Dakota South (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",44.4],PARAMETER[\"standard_parallel_2\",42.83333333333334],PARAMETER[\"latitude_of_origin\",42.33333333333334],PARAMETER[\"central_meridian\",-100.3333333333333],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"3455\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / South Dakota South (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",44.4],PARAMETER[\"standard_parallel_2\",42.83333333333334],PARAMETER[\"latitude_of_origin\",42.33333333333334],PARAMETER[\"central_meridian\",-100.3333333333333],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(42.9923358181818, -99.532787),
                    new Vector(42.9923898181818, -99.25397599999998),
                    new Vector(42.991777818182, -98.497652),
                    new Vector(42.9371658181819, -98.45744899999988),
                    new Vector(42.9201378181818, -98.391209),
                    new Vector(42.8817888181819, -98.31033500000001),
                    new Vector(42.8395698181819, -98.167829),
                    new Vector(42.8357898181818, -98.1448699999999),
                    new Vector(42.8202288181819, -98.12311699999998),
                    new Vector(42.8083668181819, -98.12182099999998),
                    new Vector(42.7691898181819, -98.033135),
                    new Vector(42.7668048181819, -97.99514600000001),
                    new Vector(42.7736898181819, -97.96355599999998),
                    new Vector(42.7923288181818, -97.92947299999999),
                    new Vector(42.8312718181818, -97.889945),
                    new Vector(42.8558058181818, -97.88866699999998),
                    new Vector(42.8665878181818, -97.8186469999999),
                    new Vector(42.8495958181819, -97.79702900000001),
                    new Vector(42.8461668181819, -97.77218000000001),
                    new Vector(42.8580108181818, -97.72525400000001),
                    new Vector(42.8368338181818, -97.68575300000001),
                    new Vector(42.8612778181817, -97.63497499999988),
                    new Vector(42.8479938181819, -97.570652),
                    new Vector(42.8601348181818, -97.50614),
                    new Vector(42.8571558181818, -97.483163),
                    new Vector(42.8504418181819, -97.457261),
                    new Vector(42.8674338181818, -97.38931099999999),
                    new Vector(42.8617728181819, -97.31141600000001),
                    new Vector(42.8500188181819, -97.27145599999999),
                    new Vector(42.8518278181818, -97.24318700000001),
                    new Vector(42.8411988181819, -97.22444900000001),
                    new Vector(42.8125698181818, -97.21184),
                    new Vector(42.7986198181819, -97.16143099999999),
                    new Vector(42.7739238181819, -97.13047100000001),
                    new Vector(42.7595418181819, -97.0151359999999),
                    new Vector(42.7583088181818, -96.979595),
                    new Vector(42.7520628181818, -96.9700009999999),
                    new Vector(42.7273128181819, -96.97787599999991),
                    new Vector(42.7211478181818, -96.97077499999999),
                    new Vector(42.7316958181818, -96.90823399999989),
                    new Vector(42.7040838181818, -96.81013400000001),
                    new Vector(42.6813498181819, -96.81044),
                    new Vector(42.6700188181818, -96.79934299999999),
                    new Vector(42.6685878181818, -96.722663),
                    new Vector(42.6577158181818, -96.699065),
                    new Vector(42.6411648181818, -96.69460100000002),
                    new Vector(42.6219048181818, -96.71527399999989),
                    new Vector(42.6123018181818, -96.71406799999988),
                    new Vector(42.550723818182, -96.63667700000001),
                    new Vector(42.5226888181819, -96.62928800000002),
                    new Vector(42.5072358181819, -96.605465),
                    new Vector(42.5182878181819, -96.58475599999998),
                    new Vector(42.5205018181817, -96.54721699999999),
                    new Vector(42.4884618181818, -96.494702),
                    new Vector(42.4892358181819, -96.43938799999988),
                    new Vector(42.517126818182, -96.480248),
                    new Vector(42.5640258181817, -96.48933800000002),
                    new Vector(42.5738808181818, -96.50094799999989),
                    new Vector(42.5804778181817, -96.488501),
                    new Vector(42.6297528181819, -96.5128459999999),
                    new Vector(42.6624048181819, -96.54116000000002),
                    new Vector(42.6685068181819, -96.563039),
                    new Vector(42.7083588181818, -96.62654300000001),
                    new Vector(42.7485978181818, -96.640709),
                    new Vector(42.7768398181819, -96.63297799999988),
                    new Vector(42.7995558181819, -96.600875),
                    new Vector(42.8353848181818, -96.58764499999999),
                    new Vector(42.8343498181818, -96.5731279999999),
                    new Vector(42.8466618181818, -96.55620799999991),
                    new Vector(42.8969088181818, -96.53750599999999),
                    new Vector(42.9138648181818, -96.54426499999988),
                    new Vector(42.9523848181818, -96.5149339999999),
                    new Vector(42.9864588181819, -96.51714800000001),
                    new Vector(43.0120548181819, -96.4990219999999),
                    new Vector(43.051510818182, -96.52001),
                    new Vector(43.0618788181818, -96.479573),
                    new Vector(43.0755858181819, -96.46209500000002),
                    new Vector(43.087870818182, -96.460808),
                    new Vector(43.1263098181818, -96.4515109999999),
                    new Vector(43.2090828181817, -96.47311999999989),
                    new Vector(43.2179118181818, -96.48724099999988),
                    new Vector(43.2254898181818, -96.55861099999998),
                    new Vector(43.2396378181818, -96.56699),
                    new Vector(43.2532638181819, -96.55956500000001),
                    new Vector(43.2636048181819, -96.570716),
                    new Vector(43.2900738181818, -96.579131),
                    new Vector(43.3076598181819, -96.54056600000001),
                    new Vector(43.356961818182, -96.52289),
                    new Vector(43.3842228181819, -96.52505899999991),
                    new Vector(43.400728818182, -96.55771099999991),
                    new Vector(43.4355408181818, -96.589112),
                    new Vector(43.481917818182, -96.58380200000001),
                    new Vector(43.4998458181819, -96.59831899999999),
                    new Vector(43.4997198181819, -96.46045699999999),
                    new Vector(43.8487488181819, -96.456596),
                    new Vector(44.1990648181819, -96.45739700000001),
                    new Vector(44.1946368181819, -96.89157499999999),
                    new Vector(44.1936288181819, -97.1326669999999),
                    new Vector(44.1954288181819, -97.37471300000001),
                    new Vector(44.1953118181818, -97.856483),
                    new Vector(44.1980028181819, -98.33786600000001),
                    new Vector(44.1994248181818, -98.70429199999998),
                    new Vector(44.1995508181819, -98.9296609999999),
                    new Vector(44.1994788181818, -99.29993),
                    new Vector(44.1967158181819, -99.57839899999999),
                    new Vector(44.2146978181818, -99.611699),
                    new Vector(44.2213758181819, -99.66170299999999),
                    new Vector(44.5500828181818, -99.665609),
                    new Vector(44.5505778181819, -99.6809719999999),
                    new Vector(44.5486698181818, -100.521932),
                    new Vector(44.5576428181819, -100.533668),
                    new Vector(44.5635378181818, -100.567355),
                    new Vector(44.5597848181818, -100.598963),
                    new Vector(44.5752918181818, -100.634756),
                    new Vector(44.6216778181818, -100.646573),
                    new Vector(44.6871168181819, -100.616963),
                    new Vector(44.7368328181819, -100.633136),
                    new Vector(44.7709248181819, -100.718915),
                    new Vector(44.7672708181819, -100.737752),
                    new Vector(44.7748218181819, -100.747679),
                    new Vector(44.7624558181819, -100.765004),
                    new Vector(44.7749838181818, -100.792058),
                    new Vector(44.7705288181818, -100.81607),
                    new Vector(44.7816708181819, -100.862519),
                    new Vector(44.7714288181818, -100.893227),
                    new Vector(44.7788628181819, -100.918616),
                    new Vector(44.7669648181817, -100.937165),
                    new Vector(44.766163818182, -100.962293),
                    new Vector(44.7535998181819, -100.971869),
                    new Vector(44.7303978181819, -101.015969),
                    new Vector(44.7452028181818, -101.066117),
                    new Vector(44.7494418181819, -101.135381),
                    new Vector(44.7031098181818, -101.210594),
                    new Vector(44.6840298181818, -101.32637),
                    new Vector(44.6933718181818, -101.337575),
                    new Vector(44.6893758181818, -101.365988),
                    new Vector(44.6602608181819, -101.370983),
                    new Vector(44.6582178181818, -101.406362),
                    new Vector(44.6448708181818, -101.424218),
                    new Vector(44.6462478181818, -101.447906),
                    new Vector(44.6104908181819, -101.463386),
                    new Vector(44.6086188181819, -101.485265),
                    new Vector(44.5888548181819, -101.501393),
                    new Vector(44.5770468181819, -101.529401),
                    new Vector(44.5896468181818, -101.671988),
                    new Vector(44.5799088181819, -101.688989),
                    new Vector(44.5744098181818, -101.741126),
                    new Vector(44.5591728181818, -101.75702),
                    new Vector(44.5436928181819, -101.786369),
                    new Vector(44.5426218181819, -101.803721),
                    new Vector(44.5300578181819, -101.816933),
                    new Vector(44.5366458181819, -101.828912),
                    new Vector(44.5389858181819, -101.948036),
                    new Vector(44.5277448181819, -101.989382),
                    new Vector(44.5165308181818, -102.001244),
                    new Vector(44.5075308181817, -102.040592),
                    new Vector(44.4908718181819, -102.055802),
                    new Vector(44.4843378181818, -102.076484),
                    new Vector(44.4402198181818, -102.116777),
                    new Vector(44.4469518181818, -102.142184),
                    new Vector(44.4444228181818, -102.156971),
                    new Vector(44.4304368181819, -102.1676),
                    new Vector(44.4330738181819, -102.193754),
                    new Vector(44.4471498181819, -102.222815),
                    new Vector(44.4576978181818, -102.227666),
                    new Vector(44.4543138181818, -102.2828),
                    new Vector(44.4431988181819, -102.304832),
                    new Vector(44.3820798181819, -102.303806),
                    new Vector(44.3556738181818, -102.342821),
                    new Vector(44.2653048181818, -102.371828),
                    new Vector(44.2356408181818, -102.368705),
                    new Vector(44.2149858181818, -102.394715),
                    new Vector(44.1936648181818, -102.402869),
                    new Vector(44.1840978181818, -102.403733),
                    new Vector(44.1844038181819, -102.390341),
                    new Vector(44.1608598181818, -102.404282),
                    new Vector(44.1470898181818, -102.395678),
                    new Vector(44.1456408181818, -103.455815),
                    new Vector(44.1458298181818, -104.059724),
                    new Vector(43.8529068181819, -104.059481),
                    new Vector(43.5037068181817, -104.057915),
                    new Vector(43.4791368181819, -104.059157),
                    new Vector(43.0030638181819, -104.056196),
                    new Vector(42.9986178181818, -103.501454),
                    new Vector(42.9993558181819, -103.005869),
                    new Vector(42.9952968181818, -102.788384),
                    new Vector(42.9898878181819, -102.086699),
                    new Vector(42.9868458181817, -101.231735),
                    new Vector(42.9910938181819, -100.198148),
                    new Vector(42.9923358181818, -99.532787)
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