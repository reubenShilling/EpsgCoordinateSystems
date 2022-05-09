using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Texas_South_Central_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2278;
        private readonly BoundingBox _boundingBox = new BoundingBox();

public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Texas South Central";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt => "PROJCS[\"NAD83 / Texas South Central (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",30.28333333333333],PARAMETER[\"standard_parallel_2\",28.38333333333333],PARAMETER[\"latitude_of_origin\",27.83333333333333],PARAMETER[\"central_meridian\",-99],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",13123333.333],AUTHORITY[\"EPSG\",\"2278\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt => "PROJCS[\"NAD83 / Texas South Central (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",30.28333333333333],PARAMETER[\"standard_parallel_2\",28.38333333333333],PARAMETER[\"latitude_of_origin\",27.83333333333333],PARAMETER[\"central_meridian\",-99],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",13123333.333],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(28.8035028181819, -95.52680599999999),
                    new Vector(28.9786338181819, -95.248616),
                    new Vector(29.1054618181818, -95.197559),
                    new Vector(29.1177918181818, -95.16498799999999),
                    new Vector(29.2002768181819, -95.1607309999999),
                    new Vector(29.1961188181818, -95.06657300000001),
                    new Vector(29.3261508181818, -94.95133699999998),
                    new Vector(29.3090058181818, -94.898993),
                    new Vector(29.3940648181819, -94.891676),
                    new Vector(29.3711598181818, -94.81555400000001),
                    new Vector(29.3995548181818, -94.891334),
                    new Vector(29.448055818182, -94.91719099999999),
                    new Vector(29.4203448181819, -94.913645),
                    new Vector(29.4244668181819, -94.95270499999998),
                    new Vector(29.4649128181819, -94.943966),
                    new Vector(29.4607548181818, -94.983017),
                    new Vector(29.5005618181819, -94.911359),
                    new Vector(29.5594938181819, -95.01432800000002),
                    new Vector(29.6799228181819, -94.98953299999998),
                    new Vector(29.71180981818179, -95.040599),
                    new Vector(29.8042128181818, -95.08847),
                    new Vector(29.6824338181818, -94.932788),
                    new Vector(29.6687628181818, -94.887365),
                    new Vector(29.7600858181819, -94.829621),
                    new Vector(29.7932058181818, -94.73593099999999),
                    new Vector(29.7547938181819, -94.70047099999989),
                    new Vector(29.6587458181819, -94.70661800000001),
                    new Vector(29.5387848181819, -94.788284),
                    new Vector(29.5792308181819, -94.56462499999999),
                    new Vector(29.5542108181819, -94.53389),
                    new Vector(29.5453818181819, -94.511003),
                    new Vector(29.5570098181819, -94.46998100000002),
                    new Vector(29.5177518181819, -94.50147199999989),
                    new Vector(29.5332858181818, -94.572878),
                    new Vector(29.47534381818179, -94.68211100000001),
                    new Vector(29.3834898181818, -94.785449),
                    new Vector(29.36422981818181, -94.76674700000001),
                    new Vector(29.4331338181819, -94.682705),
                    new Vector(29.5522038181817, -94.3771909999999),
                    new Vector(29.5601238181819, -94.357184),
                    new Vector(29.6742978181819, -94.06558400000002),
                    new Vector(29.6747928181818, -93.83512999999989),
                    new Vector(29.8185858181818, -93.951932),
                    new Vector(29.9648178181818, -93.85649599999989),
                    new Vector(29.9970378181819, -93.91032500000001),
                    new Vector(29.9945268181818, -93.93110599999999),
                    new Vector(30.0104568181818, -93.953705),
                    new Vector(30.0135798181819, -94.002071),
                    new Vector(30.0357288181818, -94.037972),
                    new Vector(30.0590838181819, -94.037333),
                    new Vector(30.0738168181819, -94.06376600000002),
                    new Vector(30.0735378181819, -94.09232299999999),
                    new Vector(30.1008258181819, -94.096706),
                    new Vector(30.1156488181818, -94.08242300000001),
                    new Vector(30.1264398181818, -94.086932),
                    new Vector(30.1304808181819, -94.11098),
                    new Vector(30.151720818182, -94.11368899999999),
                    new Vector(30.1626018181818, -94.10285299999988),
                    new Vector(30.1747788181818, -94.159139),
                    new Vector(30.1848588181819, -94.167419),
                    new Vector(30.1877028181819, -94.203734),
                    new Vector(30.166804818182, -94.242254),
                    new Vector(30.1716108181819, -94.27260199999999),
                    new Vector(30.1519638181818, -94.29143000000001),
                    new Vector(30.1244778181819, -94.300736),
                    new Vector(30.1078278181818, -94.342073),
                    new Vector(30.1061268181818, -94.398224),
                    new Vector(30.0978018181818, -94.42364000000002),
                    new Vector(30.1102398181819, -94.45187300000001),
                    new Vector(29.8960218181819, -94.450451),
                    new Vector(29.8869498181818, -94.98297200000002),
                    new Vector(29.91722581818191, -95.003276),
                    new Vector(29.9646558181819, -94.98773300000002),
                    new Vector(29.9954988181819, -95.0106739999999),
                    new Vector(30.0002778181819, -95.04521600000001),
                    new Vector(30.0147588181817, -95.06124499999999),
                    new Vector(30.0514518181818, -95.051642),
                    new Vector(30.1689108181819, -95.095355),
                    new Vector(30.0431088181818, -95.256491),
                    new Vector(30.0410928181819, -95.28406699999999),
                    new Vector(30.0298878181819, -95.28998000000001),
                    new Vector(30.0344058181818, -95.30978900000001),
                    new Vector(30.0590388181819, -95.32845500000001),
                    new Vector(30.0752298181819, -95.353421),
                    new Vector(30.0889998181818, -95.3975389999999),
                    new Vector(30.1145958181819, -95.42887700000001),
                    new Vector(30.1045068181818, -95.47276100000002),
                    new Vector(30.1089528181818, -95.491535),
                    new Vector(30.1445838181819, -95.51125399999998),
                    new Vector(30.1633308181819, -95.5440679999999),
                    new Vector(30.1588938181818, -95.5702129999999),
                    new Vector(30.1425228181819, -95.584838),
                    new Vector(30.1016538181819, -95.674199),
                    new Vector(30.10238281818179, -95.715887),
                    new Vector(30.08767681818181, -95.77369399999999),
                    new Vector(30.0887028181818, -95.812196),
                    new Vector(30.2469588181819, -95.806256),
                    new Vector(30.2239548181819, -96.10153699999999),
                    new Vector(30.2115888181819, -96.11429),
                    new Vector(30.2210118181819, -96.12177800000002),
                    new Vector(30.2098158181819, -96.141875),
                    new Vector(30.2140278181819, -96.157535),
                    new Vector(30.1939758181819, -96.1732939999999),
                    new Vector(30.1434228181819, -96.15555499999989),
                    new Vector(30.1410018181818, -96.16465399999998),
                    new Vector(30.1511358181819, -96.17951299999999),
                    new Vector(30.137986818182, -96.183284),
                    new Vector(30.1344678181819, -96.200357),
                    new Vector(30.1180878181818, -96.190547),
                    new Vector(30.1073868181819, -96.1989619999999),
                    new Vector(30.1041108181819, -96.17059399999989),
                    new Vector(30.0970098181818, -96.164051),
                    new Vector(30.0833838181819, -96.16732699999999),
                    new Vector(30.0853368181818, -96.15773299999998),
                    new Vector(30.0738078181818, -96.14243299999991),
                    new Vector(30.0665538181818, -96.15755300000001),
                    new Vector(30.0576438181818, -96.178037),
                    new Vector(30.0741858181818, -96.245375),
                    new Vector(30.0710628181819, -96.261341),
                    new Vector(30.0784248181819, -96.27580399999989),
                    new Vector(30.0977208181819, -96.27757699999999),
                    new Vector(30.0945258181819, -96.29143699999999),
                    new Vector(30.1003038181819, -96.29963600000001),
                    new Vector(30.058759818182, -96.57121100000002),
                    new Vector(30.0586788181818, -96.583352),
                    new Vector(30.0729798181819, -96.60124400000001),
                    new Vector(30.0531888181818, -96.62792000000002),
                    new Vector(30.0725208181819, -96.645596),
                    new Vector(30.1107618181819, -96.63822500000002),
                    new Vector(30.1247388181818, -96.66089599999999),
                    new Vector(30.149425818182, -96.659897),
                    new Vector(30.1456728181819, -96.68699599999989),
                    new Vector(30.1706928181817, -96.69655399999999),
                    new Vector(30.1551498181818, -96.712502),
                    new Vector(30.1437918181819, -96.77741),
                    new Vector(30.1548618181818, -96.780146),
                    new Vector(30.1645908181819, -96.799847),
                    new Vector(30.1240638181819, -96.854765),
                    new Vector(30.0383568181819, -97.032668),
                    new Vector(30.0581568181818, -97.0367),
                    new Vector(29.8925388181818, -97.200104),
                    new Vector(29.7834408181818, -97.32528499999998),
                    new Vector(30.0741678181819, -97.65992300000001),
                    new Vector(30.0224808181819, -97.727846),
                    new Vector(30.3493248181819, -98.171465),
                    new Vector(30.2922648181819, -98.207114),
                    new Vector(30.0393108181819, -98.30281100000001),
                    new Vector(29.9481048181818, -98.41900099999989),
                    new Vector(30.1400208181818, -98.593799),
                    new Vector(30.1377978181819, -98.922785),
                    new Vector(30.1431978181818, -99.30974000000001),
                    new Vector(30.2845968181817, -99.310667),
                    new Vector(30.2864868181818, -99.759173),
                    new Vector(30.2889798181819, -100.120415),
                    new Vector(30.2877828181819, -100.691123),
                    new Vector(30.2876478181818, -100.954004),
                    new Vector(30.2860728181819, -101.750594),
                    new Vector(30.3187608181818, -101.737526),
                    new Vector(30.3439698181818, -101.705765),
                    new Vector(30.3489198181819, -101.651342),
                    new Vector(30.3571188181819, -101.653628),
                    new Vector(30.3812478181819, -101.691707),
                    new Vector(30.4022808181819, -101.692148),
                    new Vector(30.42127981818181, -101.734925),
                    new Vector(30.4458588181819, -101.714252),
                    new Vector(30.4634898181819, -101.726807),
                    new Vector(30.46819681818191, -101.718437),
                    new Vector(30.4594308181818, -101.693858),
                    new Vector(30.4888158181819, -101.685992),
                    new Vector(30.5032518181819, -101.669306),
                    new Vector(30.5205678181818, -101.673905),
                    new Vector(30.5415108181818, -101.64938),
                    new Vector(30.5640288181819, -101.642405),
                    new Vector(30.5885358181819, -101.654591),
                    new Vector(30.6265608181818, -101.649515),
                    new Vector(30.6488358181819, -101.688215),
                    new Vector(30.6525078181818, -101.746211),
                    new Vector(30.66465781818191, -101.758694),
                    new Vector(30.6619398181819, -102.144992),
                    new Vector(30.6038358181818, -102.146666),
                    new Vector(30.6042048181818, -102.373988),
                    new Vector(30.2849658181819, -102.370586),
                    new Vector(30.27810781818191, -102.573527),
                    new Vector(30.0601278181818, -102.577271),
                    new Vector(30.6679518181819, -103.443332),
                    new Vector(30.4052688181819, -103.792748),
                    new Vector(30.4062138181819, -103.896689),
                    new Vector(30.6414648181818, -104.987426),
                    new Vector(30.5706978181819, -104.891171),
                    new Vector(30.3924078181819, -104.853479),
                    new Vector(30.3766038181819, -104.806967),
                    new Vector(30.3506208181818, -104.814446),
                    new Vector(30.2386428181818, -104.703089),
                    new Vector(30.1491198181819, -104.675243),
                    new Vector(30.05746381818181, -104.696978),
                    new Vector(29.9094498181818, -104.674856),
                    new Vector(29.8081098181819, -104.578043),
                    new Vector(29.6796438181819, -104.535725),
                    new Vector(29.5507908181819, -104.378063),
                    new Vector(29.4842268181818, -104.2052),
                    new Vector(29.4009048181819, -104.164862),
                    new Vector(29.3283108181819, -104.046107),
                    new Vector(29.26745281818191, -103.787456),
                    new Vector(29.2814388181818, -103.768223),
                    new Vector(29.2299948181818, -103.782623),
                    new Vector(29.2305438181817, -103.740314),
                    new Vector(29.1908358181818, -103.720775),
                    new Vector(29.1468438181819, -103.526699),
                    new Vector(29.0723328181818, -103.474535),
                    new Vector(29.0323188181818, -103.375904),
                    new Vector(29.0505438181818, -103.335971),
                    new Vector(28.9865808181818, -103.280801),
                    new Vector(29.0076678181818, -103.26704),
                    new Vector(28.9788948181818, -103.153919),
                    new Vector(29.1910608181818, -102.988535),
                    new Vector(29.2292478181818, -102.866612),
                    new Vector(29.2694058181818, -102.908777),
                    new Vector(29.3535738181819, -102.883442),
                    new Vector(29.4120468181819, -102.822638),
                    new Vector(29.5303428181819, -102.80516),
                    new Vector(29.7444168181818, -102.676793),
                    new Vector(29.7325368181819, -102.638039),
                    new Vector(29.7784458181819, -102.576929),
                    new Vector(29.7496908181819, -102.552377),
                    new Vector(29.78564581818179, -102.503516),
                    new Vector(29.7681498181819, -102.385229),
                    new Vector(29.8454778181818, -102.367985),
                    new Vector(29.8803078181818, -102.324758),
                    new Vector(29.7847728181819, -102.064406),
                    new Vector(29.8189728181819, -101.973731),
                    new Vector(29.7886968181818, -101.924618),
                    new Vector(29.8143288181818, -101.819498),
                    new Vector(29.7802008181819, -101.805611),
                    new Vector(29.7873648181819, -101.759486),
                    new Vector(29.7571608181818, -101.640065),
                    new Vector(29.7653508181818, -101.58188),
                    new Vector(29.8103148181819, -101.544341),
                    new Vector(29.7632178181818, -101.538743),
                    new Vector(29.7888948181819, -101.470856),
                    new Vector(29.7607878181819, -101.448815),
                    new Vector(29.7701118181819, -101.401673),
                    new Vector(29.7456498181818, -101.416487),
                    new Vector(29.6573688181819, -101.368787),
                    new Vector(29.6526438181818, -101.306246),
                    new Vector(29.5811298181818, -101.309315),
                    new Vector(29.6289648181818, -101.254973),
                    new Vector(29.5266888181818, -101.261813),
                    new Vector(29.473768818182, -101.067737),
                    new Vector(29.3734818181819, -101.009435),
                    new Vector(29.2427388181818, -100.797359),
                    new Vector(29.1668058181819, -100.768973),
                    new Vector(29.0803068181818, -100.669136),
                    new Vector(28.9225908181818, -100.647572),
                    new Vector(28.8944748181818, -100.590143),
                    new Vector(28.6612488181819, -100.498262),
                    new Vector(28.5899868181819, -100.403537),
                    new Vector(28.5444558181818, -100.419881),
                    new Vector(28.5010758181818, -100.346153),
                    new Vector(28.4789088181818, -100.377122),
                    new Vector(28.3944438181819, -100.351922),
                    new Vector(28.320625818182, -100.293233),
                    new Vector(28.2806208181818, -100.298264),
                    new Vector(28.2417228181818, -100.223798),
                    new Vector(28.2022128181819, -100.21442),
                    new Vector(28.2032838181819, -100.110731),
                    new Vector(28.2039048181817, -99.39263900000002),
                    new Vector(28.0360368181818, -99.390227),
                    new Vector(28.0610028181818, -98.807045),
                    new Vector(28.0616238181818, -98.33936),
                    new Vector(28.0609398181819, -98.238938),
                    new Vector(28.0588788181819, -97.89799099999999),
                    new Vector(28.1108538181818, -97.89721700000001),
                    new Vector(28.1698848181819, -97.81322900000001),
                    new Vector(28.1215368181819, -97.557233),
                    new Vector(28.1563668181818, -97.53147500000001),
                    new Vector(28.1546298181818, -97.516058),
                    new Vector(28.1443158181818, -97.508111),
                    new Vector(28.1592288181819, -97.49632099999999),
                    new Vector(28.1705418181819, -97.469168),
                    new Vector(28.1544408181818, -97.469123),
                    new Vector(28.1441628181819, -97.44314),
                    new Vector(28.1313288181819, -97.445066),
                    new Vector(28.1321388181818, -97.42131499999989),
                    new Vector(28.1100618181818, -97.42198999999999),
                    new Vector(28.1020788181819, -97.396466),
                    new Vector(28.1125368181819, -97.39099400000001),
                    new Vector(28.124164818182, -97.39631300000001),
                    new Vector(28.1192238181819, -97.38253399999999),
                    new Vector(28.1313648181819, -97.3708249999999),
                    new Vector(28.11358081818179, -97.340441),
                    new Vector(28.1234988181819, -97.33239500000001),
                    new Vector(28.1134818181818, -97.31828299999999),
                    new Vector(28.1342358181819, -97.3202),
                    new Vector(28.1358558181819, -97.31138),
                    new Vector(28.1163618181819, -97.304783),
                    new Vector(28.1063718181819, -97.309742),
                    new Vector(28.0981998181817, -97.29608),
                    new Vector(28.1034468181817, -97.28509099999999),
                    new Vector(28.0895148181819, -97.28038399999998),
                    new Vector(28.0803348181819, -97.263158),
                    new Vector(28.0650168181819, -97.26055700000001),
                    new Vector(28.1166768181818, -97.15732700000001),
                    new Vector(28.1597418181818, -97.168262),
                    new Vector(28.1620998181819, -97.13568199999999),
                    new Vector(28.130716818182, -97.132109),
                    new Vector(28.2000798181818, -97.023839),
                    new Vector(28.1376918181819, -97.033883),
                    new Vector(28.1153358181819, -96.975374),
                    new Vector(28.1870658181819, -96.94133599999989),
                    new Vector(28.2110328181818, -96.975572),
                    new Vector(28.2570858181817, -96.912986),
                    new Vector(28.1146428181819, -96.9511729999999),
                    new Vector(28.2117348181818, -96.8039509999999),
                    new Vector(28.2296358181818, -96.778193),
                    new Vector(28.271656818182, -96.79360099999991),
                    new Vector(28.3131468181818, -96.786536),
                    new Vector(28.3527558181819, -96.788489),
                    new Vector(28.4052798181819, -96.853757),
                    new Vector(28.3919058181818, -96.77561899999999),
                    new Vector(28.4111928181817, -96.759365),
                    new Vector(28.4465358181818, -96.788597),
                    new Vector(28.4499198181819, -96.824138),
                    new Vector(28.4777838181818, -96.78735500000002),
                    new Vector(28.4037408181819, -96.741023),
                    new Vector(28.3961628181818, -96.704069),
                    new Vector(28.3404798181819, -96.70262),
                    new Vector(28.3065498181819, -96.661562),
                    new Vector(28.4343408181818, -96.39097699999999),
                    new Vector(28.4997348181819, -96.47675599999999),
                    new Vector(28.4611068181818, -96.518759),
                    new Vector(28.4699088181818, -96.56344399999999),
                    new Vector(28.506502818182, -96.4868359999999),
                    new Vector(28.5743718181819, -96.56695399999998),
                    new Vector(28.5592158181818, -96.610604),
                    new Vector(28.6239078181819, -96.60696799999999),
                    new Vector(28.679347818182, -96.66026599999999),
                    new Vector(28.7144118181818, -96.64677500000001),
                    new Vector(28.7176248181819, -96.591758),
                    new Vector(28.6909668181819, -96.57673700000001),
                    new Vector(28.8084438181818, -96.572462),
                    new Vector(28.6921098181818, -96.570806),
                    new Vector(28.6365348181818, -96.57065299999999),
                    new Vector(28.6498188181819, -96.511982),
                    new Vector(28.6084548181819, -96.51214400000001),
                    new Vector(28.5983298181819, -96.483515),
                    new Vector(28.6562088181818, -96.4546339999999),
                    new Vector(28.59726781818179, -96.437408),
                    new Vector(28.5572178181819, -96.49145299999989),
                    new Vector(28.61036281818191, -96.375641),
                    new Vector(28.6389378181819, -96.419039),
                    new Vector(28.7197668181819, -96.403649),
                    new Vector(28.6975188181819, -96.432512),
                    new Vector(28.7552988181818, -96.449927),
                    new Vector(28.7122788181819, -96.42733700000001),
                    new Vector(28.7263008181818, -96.39298399999998),
                    new Vector(28.6705278181819, -96.39203000000002),
                    new Vector(28.6182558181818, -96.36440899999999),
                    new Vector(28.63436581818191, -96.32641099999999),
                    new Vector(28.70924581818201, -96.270629),
                    new Vector(28.6619868181818, -96.28621700000001),
                    new Vector(28.6869888181818, -96.212417),
                    new Vector(28.7629398181818, -96.15130700000002),
                    new Vector(28.6351308181818, -96.24070399999999),
                    new Vector(28.6114968181819, -96.1577149999999),
                    new Vector(28.597393818182, -96.239273),
                    new Vector(28.5715908181818, -96.23783299999999),
                    new Vector(28.6534008181818, -95.983988),
                    new Vector(28.5966918181817, -95.99189),
                    new Vector(28.4886648181819, -96.20682799999999),
                    new Vector(28.7192448181819, -95.70237800000001),
                    new Vector(28.6229448181818, -95.95639399999999),
                    new Vector(28.6907148181819, -95.93754800000001),
                    new Vector(28.7391348181818, -95.78659099999999),
                    new Vector(28.7529498181819, -95.67155299999999),
                    new Vector(28.7272188181819, -95.683262),
                    new Vector(28.8035028181819, -95.52680599999999)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(28.3461228181818, -96.398132),
                    new Vector(28.3917168181818, -96.42281),
                    new Vector(28.32611581818181, -96.46331000000001),
                    new Vector(28.3185288181818, -96.532394),
                    new Vector(28.1838258181818, -96.739169),
                    new Vector(28.1724588181819, -96.8041039999999),
                    new Vector(28.066618818182, -96.83489299999999),
                    new Vector(28.3461228181818, -96.398132)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(27.91568881818189, -97.11489199999991),
                    new Vector(28.0205388181819, -97.024073),
                    new Vector(28.1080458181819, -97.026674),
                    new Vector(28.0545678181819, -97.12334300000001),
                    new Vector(28.0408158181818, -97.236482),
                    new Vector(27.8974998181819, -97.136366),
                    new Vector(27.91568881818189, -97.11489199999991)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(28.0462248181819, -96.940229),
                    new Vector(28.0011438181818, -96.973268),
                    new Vector(27.9848178181818, -96.94965199999999),
                    new Vector(27.9146808181818, -97.024694),
                    new Vector(27.8412588181818, -97.0498759999999),
                    new Vector(28.0496988181819, -96.854072),
                    new Vector(28.1021328181819, -96.837692),
                    new Vector(28.1316888181819, -96.87268400000002),
                    new Vector(28.0462248181819, -96.940229)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(29.2578048181819, -94.91362700000001),
                    new Vector(29.0971998181819, -95.105615),
                    new Vector(29.3197248181818, -94.748603),
                    new Vector(29.3426838181818, -94.76757499999999),
                    new Vector(29.2578048181819, -94.91362700000001)
                })
            }
        };

        public BoundingBox BoundingBox => CalculateBoundingBox();

        private BoundingBox CalculateBoundingBox()
        {
            foreach (var linearRing in Wgs84Boundaries)
            {
                _boundingBox.Expand(linearRing.CalculateBounds());
            }

            return _boundingBox;
        }
    }
}