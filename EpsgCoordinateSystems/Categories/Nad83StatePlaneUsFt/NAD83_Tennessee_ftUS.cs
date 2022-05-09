using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_Tennessee_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2274;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Tennessee";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / Tennessee (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",36.41666666666666],PARAMETER[\"standard_parallel_2\",35.25],PARAMETER[\"latitude_of_origin\",34.33333333333334],PARAMETER[\"central_meridian\",-86],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"2274\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / Tennessee (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",36.41666666666666],PARAMETER[\"standard_parallel_2\",35.25],PARAMETER[\"latitude_of_origin\",34.33333333333334],PARAMETER[\"central_meridian\",-86],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(35.4555468181819, -83.954606),
                    new Vector(35.4765618181818, -83.90991200000001),
                    new Vector(35.5106718181818, -83.8811299999999),
                    new Vector(35.5191498181818, -83.8301),
                    new Vector(35.5526928181819, -83.77577599999999),
                    new Vector(35.5650678181819, -83.67276200000001),
                    new Vector(35.5718268181818, -83.613758),
                    new Vector(35.5552758181818, -83.560919),
                    new Vector(35.5596498181819, -83.505686),
                    new Vector(35.5973688181818, -83.4581749999999),
                    new Vector(35.6253048181819, -83.386976),
                    new Vector(35.6533578181819, -83.34290300000001),
                    new Vector(35.6564268181817, -83.29828999999999),
                    new Vector(35.6911128181818, -83.258996),
                    new Vector(35.7007968181819, -83.253173),
                    new Vector(35.7183108181819, -83.243723),
                    new Vector(35.7289848181819, -83.185214),
                    new Vector(35.7627798181819, -83.143535),
                    new Vector(35.7639048181819, -83.118056),
                    new Vector(35.7826698181818, -83.059826),
                    new Vector(35.7740928181818, -82.98687200000001),
                    new Vector(35.7919578181819, -82.96261699999999),
                    new Vector(35.8723188181819, -82.906691),
                    new Vector(35.9279748181818, -82.91393600000001),
                    new Vector(35.9484678181819, -82.89584600000001),
                    new Vector(35.9475228181819, -82.856138),
                    new Vector(35.920972818182, -82.808537),
                    new Vector(35.9566848181818, -82.776308),
                    new Vector(35.9876088181818, -82.773464),
                    new Vector(35.9996508181818, -82.763087),
                    new Vector(36.0518238181819, -82.643756),
                    new Vector(36.0544428181819, -82.62790699999989),
                    new Vector(36.0430938181818, -82.604264),
                    new Vector(36.0225558181818, -82.59208700000001),
                    new Vector(36.0036558181819, -82.60566799999999),
                    new Vector(35.9634078181819, -82.5991609999999),
                    new Vector(35.9562168181818, -82.554008),
                    new Vector(35.9726508181819, -82.506794),
                    new Vector(35.9932788181818, -82.47505099999999),
                    new Vector(36.0754308181819, -82.40828),
                    new Vector(36.0988128181818, -82.373711),
                    new Vector(36.1222668181818, -82.31178199999999),
                    new Vector(36.1204938181818, -82.262165),
                    new Vector(36.1471248181819, -82.20757999999999),
                    new Vector(36.1397358181819, -82.153904),
                    new Vector(36.0963738181819, -82.117931),
                    new Vector(36.1002618181818, -82.0776019999999),
                    new Vector(36.1298358181819, -82.02029),
                    new Vector(36.2634498181818, -81.9329539999999),
                    new Vector(36.2908728181819, -81.910994),
                    new Vector(36.3347838181819, -81.83040800000001),
                    new Vector(36.3294648181818, -81.730328),
                    new Vector(36.3338568181819, -81.7092949999999),
                    new Vector(36.3619818181818, -81.74021),
                    new Vector(36.3919068181819, -81.74091199999989),
                    new Vector(36.4718988181818, -81.698117),
                    new Vector(36.5194638181818, -81.702635),
                    new Vector(36.5897628181819, -81.669839),
                    new Vector(36.6076728181819, -81.652271),
                    new Vector(36.6115968181819, -81.828896),
                    new Vector(36.6136128181819, -81.91829300000001),
                    new Vector(36.5959548181819, -81.9293),
                    new Vector(36.5951538181819, -82.154183),
                    new Vector(36.5940738181819, -82.216661),
                    new Vector(36.5917968181819, -82.296851),
                    new Vector(36.5915448181819, -82.610834),
                    new Vector(36.5910498181819, -82.84981999999999),
                    new Vector(36.5912928181818, -82.986701),
                    new Vector(36.5880888181819, -83.210927),
                    new Vector(36.5899338181818, -83.248394),
                    new Vector(36.6004638181819, -83.275025),
                    new Vector(36.5988348181818, -83.46420500000001),
                    new Vector(36.5986998181818, -83.6751739999999),
                    new Vector(36.5842458181819, -83.6956129999999),
                    new Vector(36.5912928181818, -83.935598),
                    new Vector(36.5920938181818, -84.006743),
                    new Vector(36.5954508181817, -84.25449500000001),
                    new Vector(36.5954958181819, -84.256772),
                    new Vector(36.6050718181818, -84.78187699999999),
                    new Vector(36.6054408181818, -84.791057),
                    new Vector(36.6209838181819, -84.998462),
                    new Vector(36.6256188181819, -85.272503),
                    new Vector(36.6260958181818, -85.300088),
                    new Vector(36.6182028181819, -85.43737400000001),
                    new Vector(36.6266808181819, -85.785476),
                    new Vector(36.6331068181819, -85.9806049999999),
                    new Vector(36.6432948181818, -86.19898999999999),
                    new Vector(36.6509358181818, -86.4154489999999),
                    new Vector(36.6550758181818, -86.51066),
                    new Vector(36.6520968181819, -86.770535),
                    new Vector(36.6508098181819, -87.068183),
                    new Vector(36.6513048181818, -87.112697),
                    new Vector(36.6492798181819, -87.34660700000001),
                    new Vector(36.6452208181818, -87.640655),
                    new Vector(36.6444918181819, -87.69353),
                    new Vector(36.6415218181818, -87.853532),
                    new Vector(36.6694308181819, -87.87071299999999),
                    new Vector(36.6796818181819, -88.071341),
                    new Vector(36.5827158181818, -88.04109200000001),
                    new Vector(36.538201818182, -88.03507999999999),
                    new Vector(36.4965768181819, -88.042766),
                    new Vector(36.4982058181819, -88.49602400000001),
                    new Vector(36.4995468181818, -88.5126829999999),
                    new Vector(36.4990428181819, -88.81071799999999),
                    new Vector(36.4999068181819, -88.82635999999999),
                    new Vector(36.4998528181819, -88.83037400000001),
                    new Vector(36.5026068181818, -89.34666799999989),
                    new Vector(36.5026788181819, -89.41477999999999),
                    new Vector(36.4564458181818, -89.448593),
                    new Vector(36.4460148181819, -89.4709129999999),
                    new Vector(36.465526818182, -89.492063),
                    new Vector(36.4986108181818, -89.475899),
                    new Vector(36.4981698181819, -89.53327400000001),
                    new Vector(36.4718718181819, -89.516102),
                    new Vector(36.4410288181818, -89.545253),
                    new Vector(36.4011138181818, -89.52007999999999),
                    new Vector(36.3559968181818, -89.51940500000001),
                    new Vector(36.3457908181819, -89.54463199999999),
                    new Vector(36.3548178181818, -89.60576),
                    new Vector(36.3348468181818, -89.62286899999999),
                    new Vector(36.3080988181818, -89.606849),
                    new Vector(36.2809368181818, -89.54231),
                    new Vector(36.264610818182, -89.53545200000001),
                    new Vector(36.2573478181818, -89.541725),
                    new Vector(36.2409678181818, -89.618162),
                    new Vector(36.2549628181818, -89.67066800000001),
                    new Vector(36.2521998181818, -89.694626),
                    new Vector(36.2408598181818, -89.695733),
                    new Vector(36.2209338181819, -89.676869),
                    new Vector(36.1838088181819, -89.618639),
                    new Vector(36.1520928181819, -89.589533),
                    new Vector(36.1298628181818, -89.58949699999999),
                    new Vector(36.0993798181819, -89.667464),
                    new Vector(36.0830358181819, -89.678246),
                    new Vector(36.0258678181819, -89.68892),
                    new Vector(35.9999568181819, -89.721833),
                    new Vector(35.9663958181819, -89.71321999999989),
                    new Vector(35.9378928181818, -89.664269),
                    new Vector(35.9138718181819, -89.64548600000001),
                    new Vector(35.894359818182, -89.64941899999999),
                    new Vector(35.8857198181819, -89.6647279999999),
                    new Vector(35.9114958181819, -89.71476800000001),
                    new Vector(35.9150868181818, -89.738051),
                    new Vector(35.8968888181819, -89.76299),
                    new Vector(35.8841808181819, -89.766356),
                    new Vector(35.8714908181819, -89.75778800000001),
                    new Vector(35.8421058181819, -89.70152),
                    new Vector(35.8275888181819, -89.700908),
                    new Vector(35.807113818182, -89.736017),
                    new Vector(35.8174998181819, -89.75987600000001),
                    new Vector(35.8056288181818, -89.79046700000001),
                    new Vector(35.7742998181819, -89.79998000000001),
                    new Vector(35.7583428181818, -89.827124),
                    new Vector(35.7482718181818, -89.859956),
                    new Vector(35.7549138181819, -89.90986100000001),
                    new Vector(35.734348818182, -89.9511169999999),
                    new Vector(35.7125598181819, -89.952116),
                    new Vector(35.6763438181817, -89.929823),
                    new Vector(35.6560578181818, -89.89349),
                    new Vector(35.6733828181819, -89.86526600000001),
                    new Vector(35.6711418181819, -89.8573279999999),
                    new Vector(35.6453028181818, -89.849282),
                    new Vector(35.6298228181818, -89.863916),
                    new Vector(35.6334138181819, -89.87752399999989),
                    new Vector(35.6031828181819, -89.957138),
                    new Vector(35.5786758181819, -89.958119),
                    new Vector(35.5461408181818, -89.921741),
                    new Vector(35.5293108181818, -89.931263),
                    new Vector(35.5269798181818, -89.94763399999999),
                    new Vector(35.5323708181818, -89.962367),
                    new Vector(35.5617558181818, -89.989673),
                    new Vector(35.5524948181819, -90.03313400000002),
                    new Vector(35.5429278181819, -90.04099100000001),
                    new Vector(35.5125168181818, -90.041909),
                    new Vector(35.4455388181819, -89.99965400000001),
                    new Vector(35.4171888181818, -90.04687699999991),
                    new Vector(35.4134898181818, -90.06038599999999),
                    new Vector(35.4265938181819, -90.07402999999989),
                    new Vector(35.4724308181817, -90.074939),
                    new Vector(35.4782898181818, -90.0823189999999),
                    new Vector(35.4736548181818, -90.102056),
                    new Vector(35.4426048181818, -90.13736299999999),
                    new Vector(35.4238038181818, -90.172769),
                    new Vector(35.3843388181819, -90.16790899999998),
                    new Vector(35.383123818182, -90.140261),
                    new Vector(35.4076848181818, -90.132566),
                    new Vector(35.4177738181818, -90.11233400000002),
                    new Vector(35.4183678181818, -90.08525299999999),
                    new Vector(35.4066048181818, -90.07555999999991),
                    new Vector(35.3815938181818, -90.08722399999999),
                    new Vector(35.3660598181819, -90.10571),
                    new Vector(35.345683818182, -90.098789),
                    new Vector(35.314768818182, -90.10643899999998),
                    new Vector(35.3063268181817, -90.157082),
                    new Vector(35.2826568181819, -90.16983500000001),
                    new Vector(35.2641438181819, -90.15222199999999),
                    new Vector(35.2639368181818, -90.10603399999999),
                    new Vector(35.2544778181818, -90.0901939999999),
                    new Vector(35.2128258181818, -90.069053),
                    new Vector(35.1919188181818, -90.073391),
                    new Vector(35.1670068181818, -90.06252800000001),
                    new Vector(35.1474768181819, -90.06462500000001),
                    new Vector(35.1251388181819, -90.083021),
                    new Vector(35.1366228181819, -90.14382499999989),
                    new Vector(35.1297018181818, -90.16456100000001),
                    new Vector(35.1087408181818, -90.1784389999999),
                    new Vector(35.077915818182, -90.169169),
                    new Vector(35.0409888181817, -90.19580000000001),
                    new Vector(35.0485578181818, -90.291911),
                    new Vector(35.0007948181818, -90.305447),
                    new Vector(34.9992648181819, -89.71727),
                    new Vector(35.000740818182, -89.64656600000001),
                    new Vector(34.9998048181819, -89.342375),
                    new Vector(35.0008848181818, -89.198132),
                    new Vector(35.0002368181818, -89.006198),
                    new Vector(35.0024328181819, -88.812545),
                    new Vector(35.0031798181819, -88.78504100000001),
                    new Vector(35.0050428181819, -88.383146),
                    new Vector(35.0038368181818, -88.351727),
                    new Vector(35.0044578181818, -88.19399300000001),
                    new Vector(35.0135478181818, -88.194965),
                    new Vector(35.0160408181819, -87.98608400000001),
                    new Vector(35.0105418181818, -87.607805),
                    new Vector(35.0073468181819, -87.222767),
                    new Vector(35.0079678181818, -87.207593),
                    new Vector(34.9982478181819, -86.83341799999999),
                    new Vector(34.9970688181819, -86.78237),
                    new Vector(34.9952688181818, -86.313056),
                    new Vector(34.9954668181819, -86.303498),
                    new Vector(34.9923798181819, -85.869563),
                    new Vector(34.9901658181818, -85.608968),
                    new Vector(34.9901298181819, -85.46738000000001),
                    new Vector(34.9899858181818, -85.35994700000001),
                    new Vector(34.9891488181819, -85.267715),
                    new Vector(34.9926228181819, -84.97279399999999),
                    new Vector(34.9926858181819, -84.96785300000001),
                    new Vector(34.9928388181818, -84.800417),
                    new Vector(34.9907508181819, -84.77114),
                    new Vector(34.9887618181818, -84.6186799999999),
                    new Vector(34.9890948181819, -84.32377700000001),
                    new Vector(35.2106208181818, -84.290963),
                    new Vector(35.2616778181818, -84.225866),
                    new Vector(35.2410768181819, -84.179642),
                    new Vector(35.2456398181819, -84.101567),
                    new Vector(35.2726578181818, -84.0426889999999),
                    new Vector(35.2926108181818, -84.030773),
                    new Vector(35.3253708181819, -84.029117),
                    new Vector(35.3729448181819, -84.006221),
                    new Vector(35.4077118181819, -84.012557),
                    new Vector(35.4555468181819, -83.954606)
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