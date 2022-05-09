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
    internal class NAD83_Virginia_South_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2284;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Virginia South";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Virginia South (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,37.96666666666667],PARAMETER[standard_parallel_2,36.76666666666667],PARAMETER[latitude_of_origin,36.33333333333334],PARAMETER[central_meridian,-78.5],PARAMETER[false_easting,11482916.667],PARAMETER[false_northing,3280833.333],AUTHORITY[EPSG,2284],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Virginia South (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,37.96666666666667],PARAMETER[standard_parallel_2,36.76666666666667],PARAMETER[latitude_of_origin,36.33333333333334],PARAMETER[central_meridian,-78.5],PARAMETER[false_easting,11482916.667],PARAMETER[false_northing,3280833.333],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(36.5988438181818, -83.46420500000001),
                    new Vector(36.6004458181819, -83.275025),
                    new Vector(36.5899338181818, -83.248394),
                    new Vector(36.5880888181819, -83.210927),
                    new Vector(36.5912928181818, -82.986701),
                    new Vector(36.5910228181818, -82.84981999999999),
                    new Vector(36.5915268181818, -82.610834),
                    new Vector(36.5917788181819, -82.296851),
                    new Vector(36.5940738181819, -82.216661),
                    new Vector(36.5951358181818, -82.154183),
                    new Vector(36.5959548181819, -81.9293),
                    new Vector(36.6136128181819, -81.91829300000001),
                    new Vector(36.6115878181818, -81.828896),
                    new Vector(36.6076728181819, -81.652271),
                    new Vector(36.5897718181819, -81.669839),
                    new Vector(36.5729688181818, -81.345119),
                    new Vector(36.5653368181818, -80.903237),
                    new Vector(36.5635638181818, -80.837951),
                    new Vector(36.5574168181818, -80.6108449999999),
                    new Vector(36.5511798181818, -80.4350929999999),
                    new Vector(36.5472558181818, -80.04786799999999),
                    new Vector(36.5451498181819, -80.02382),
                    new Vector(36.5480298181819, -79.71719899999989),
                    new Vector(36.5477688181819, -79.510046),
                    new Vector(36.5499198181818, -79.21679899999999),
                    new Vector(36.5461938181819, -79.14406099999999),
                    new Vector(36.5436648181819, -78.79642699999989),
                    new Vector(36.5462208181818, -78.737117),
                    new Vector(36.5416218181818, -78.45853099999999),
                    new Vector(36.5456718181819, -78.320975),
                    new Vector(36.5526108181819, -78.05137999999999),
                    new Vector(36.5530878181819, -77.89856899999999),
                    new Vector(36.5535738181818, -77.763632),
                    new Vector(36.5540508181819, -77.319743),
                    new Vector(36.5564358181818, -77.177048),
                    new Vector(36.5542938181819, -76.923815),
                    new Vector(36.5543118181819, -76.921322),
                    new Vector(36.5553918181819, -76.56325699999999),
                    new Vector(36.5559678181818, -76.497224),
                    new Vector(36.5562018181818, -76.329914),
                    new Vector(36.5573088181819, -76.127054),
                    new Vector(36.5570928181818, -76.045613),
                    new Vector(36.6037398181819, -76.06150700000001),
                    new Vector(36.5568588181818, -76.026821),
                    new Vector(36.5568048181818, -75.9983179999999),
                    new Vector(36.7217298181818, -75.950447),
                    new Vector(36.5991768181818, -75.89249599999989),
                    new Vector(36.5563458181819, -75.90163099999999),
                    new Vector(36.5560218181819, -75.877808),
                    new Vector(36.9232938181819, -75.995015),
                    new Vector(36.9317628181819, -76.11809),
                    new Vector(36.9045918181819, -76.191323),
                    new Vector(36.9352188181819, -76.201988),
                    new Vector(36.9628758181819, -76.283888),
                    new Vector(36.9421488181818, -76.30727899999989),
                    new Vector(36.8284788181819, -76.292366),
                    new Vector(36.8459838181819, -76.317098),
                    new Vector(36.8262828181819, -76.400852),
                    new Vector(36.8360748181818, -76.39375099999999),
                    new Vector(36.8603298181818, -76.341578),
                    new Vector(36.9134838181819, -76.34780600000001),
                    new Vector(36.9015678181818, -76.410473),
                    new Vector(36.8696088181818, -76.506863),
                    new Vector(36.7957548181819, -76.56152899999999),
                    new Vector(36.8419338181819, -76.560188),
                    new Vector(36.8957178181818, -76.486289),
                    new Vector(36.9192348181818, -76.481843),
                    new Vector(36.9123138181819, -76.51684400000001),
                    new Vector(36.9618858181819, -76.489178),
                    new Vector(37.0063368181818, -76.554716),
                    new Vector(36.9949878181818, -76.613045),
                    new Vector(37.0246338181819, -76.577504),
                    new Vector(37.0542798181818, -76.665317),
                    new Vector(37.1478528181819, -76.671221),
                    new Vector(37.1981358181819, -76.685648),
                    new Vector(37.1508138181819, -76.728893),
                    new Vector(37.2074508181819, -76.797077),
                    new Vector(37.2012048181818, -76.900541),
                    new Vector(37.2367728181818, -76.941176),
                    new Vector(37.2595608181819, -76.878113),
                    new Vector(37.3230828181818, -76.87517),
                    new Vector(37.2440538181819, -76.856855),
                    new Vector(37.2405348181819, -76.79561),
                    new Vector(37.1935368181819, -76.745786),
                    new Vector(37.2326598181818, -76.696826),
                    new Vector(37.2259818181819, -76.64777599999999),
                    new Vector(37.1787138181818, -76.609706),
                    new Vector(37.1324178181818, -76.62459199999989),
                    new Vector(37.080307818182, -76.568117),
                    new Vector(37.1179098181819, -76.564166),
                    new Vector(37.0884978181819, -76.51493600000001),
                    new Vector(37.0677798181819, -76.530794),
                    new Vector(36.9654048181819, -76.425782),
                    new Vector(36.9905598181819, -76.38422),
                    new Vector(37.0206198181818, -76.29300499999999),
                    new Vector(37.0744758181818, -76.278587),
                    new Vector(37.1078478181819, -76.39536200000001),
                    new Vector(37.1222298181819, -76.285337),
                    new Vector(37.1771478181819, -76.336979),
                    new Vector(37.1465658181818, -76.3634569999999),
                    new Vector(37.1731698181819, -76.396541),
                    new Vector(37.1525328181818, -76.41266),
                    new Vector(37.2074418181818, -76.424333),
                    new Vector(37.2914388181818, -76.59472100000001),
                    new Vector(37.3717908181819, -76.669664),
                    new Vector(37.4186358181819, -76.704368),
                    new Vector(37.4123448181819, -76.6531669999999),
                    new Vector(37.2555738181819, -76.46081),
                    new Vector(37.2935628181818, -76.39241),
                    new Vector(37.3776408181819, -76.45522099999999),
                    new Vector(37.3731768181819, -76.4034259999999),
                    new Vector(37.412281818182, -76.4167549999999),
                    new Vector(37.4190408181818, -76.46360900000001),
                    new Vector(37.4581098181818, -76.44653599999999),
                    new Vector(37.3936788181818, -76.33868),
                    new Vector(37.3347108181819, -76.30063699999999),
                    new Vector(37.3304538181819, -76.274852),
                    new Vector(37.3903218181819, -76.2542509999999),
                    new Vector(37.5158808181818, -76.355339),
                    new Vector(37.5153408181819, -76.43385499999999),
                    new Vector(37.5527088181818, -76.512524),
                    new Vector(37.5252858181819, -76.34831),
                    new Vector(37.5513228181819, -76.3143079999999),
                    new Vector(37.6420428181819, -76.56917),
                    new Vector(37.7748918181818, -76.681409),
                    new Vector(37.7986158181819, -76.732034),
                    new Vector(37.9196388181819, -76.818191),
                    new Vector(37.9168038181819, -76.771535),
                    new Vector(37.7964828181819, -76.63145900000001),
                    new Vector(37.7702478181819, -76.58013200000001),
                    new Vector(37.6565148181819, -76.506764),
                    new Vector(37.6230528181819, -76.344539),
                    new Vector(37.6779438181817, -76.3227229999999),
                    new Vector(37.7002638181818, -76.35667100000001),
                    new Vector(37.7192448181818, -76.30961000000001),
                    new Vector(37.7989488181819, -76.324208),
                    new Vector(37.8503118181819, -76.251587),
                    new Vector(37.8901638181818, -76.25886800000001),
                    new Vector(37.9570968181819, -76.367417),
                    new Vector(38.0128698181818, -76.524215),
                    new Vector(38.003302818182, -76.573373),
                    new Vector(38.0254608181819, -76.557722),
                    new Vector(38.0242098181818, -76.581293),
                    new Vector(38.0030058181819, -76.594982),
                    new Vector(37.9995768181818, -76.619561),
                    new Vector(37.9688868181818, -76.63919),
                    new Vector(37.9830798181818, -76.65946700000001),
                    new Vector(37.9829088181819, -76.702091),
                    new Vector(37.9966248181818, -76.719461),
                    new Vector(38.0004948181819, -76.763228),
                    new Vector(38.0276838181818, -76.762373),
                    new Vector(38.0551158181819, -76.801253),
                    new Vector(38.0597508181819, -76.819334),
                    new Vector(38.1090168181818, -76.878545),
                    new Vector(38.0965698181819, -76.92776600000001),
                    new Vector(38.0786598181818, -76.94976200000001),
                    new Vector(38.0882088181818, -76.98280099999999),
                    new Vector(38.1054978181818, -77.00198),
                    new Vector(38.0942478181819, -77.02018700000001),
                    new Vector(38.0961288181818, -77.037719),
                    new Vector(38.1088728181818, -77.05342400000001),
                    new Vector(38.1433248181818, -77.05555699999999),
                    new Vector(38.1556278181819, -77.07245899999999),
                    new Vector(38.1488778181819, -77.086544),
                    new Vector(38.1616218181819, -77.101106),
                    new Vector(38.1449088181818, -77.1205099999999),
                    new Vector(38.1254058181819, -77.1170989999999),
                    new Vector(38.1196008181819, -77.145206),
                    new Vector(38.0734398181819, -77.16882200000001),
                    new Vector(38.0366118181819, -77.129249),
                    new Vector(38.0230218181819, -77.133398),
                    new Vector(38.0065338181819, -77.081504),
                    new Vector(37.9707138181818, -77.074106),
                    new Vector(37.9658088181819, -77.096912),
                    new Vector(37.9717398181818, -77.107973),
                    new Vector(37.9700658181819, -77.152343),
                    new Vector(37.9637658181818, -77.16871399999999),
                    new Vector(37.9361538181819, -77.18459900000001),
                    new Vector(37.9057698181819, -77.17890199999989),
                    new Vector(37.8967248181818, -77.187686),
                    new Vector(37.8894888181819, -77.19296),
                    new Vector(37.8877248181818, -77.21278700000001),
                    new Vector(37.9022238181819, -77.210987),
                    new Vector(37.9118178181819, -77.2436299999999),
                    new Vector(37.8760158181818, -77.247248),
                    new Vector(37.8538758181819, -77.28404),
                    new Vector(37.8339498181819, -77.294012),
                    new Vector(37.8013788181818, -77.34418700000001),
                    new Vector(37.7909658181818, -77.34654500000001),
                    new Vector(37.7882568181818, -77.35586000000001),
                    new Vector(37.7959698181818, -77.365166),
                    new Vector(37.7765118181819, -77.38790899999999),
                    new Vector(37.7783388181819, -77.404217),
                    new Vector(37.804168818182, -77.40651200000001),
                    new Vector(37.8023598181819, -77.4175819999999),
                    new Vector(37.8109818181819, -77.42805799999999),
                    new Vector(37.8205038181819, -77.42105599999999),
                    new Vector(37.8477018181818, -77.43326),
                    new Vector(37.8644598181819, -77.42101099999999),
                    new Vector(37.8912168181819, -77.440811),
                    new Vector(37.8817218181818, -77.483966),
                    new Vector(37.9179648181819, -77.52595100000001),
                    new Vector(37.9143378181818, -77.5387939999999),
                    new Vector(37.9229418181819, -77.55221299999999),
                    new Vector(37.9338228181818, -77.548721),
                    new Vector(37.9623618181818, -77.57501000000001),
                    new Vector(37.9505718181819, -77.587259),
                    new Vector(37.9573668181819, -77.603027),
                    new Vector(37.9532628181819, -77.61760700000001),
                    new Vector(37.9958418181819, -77.64687499999999),
                    new Vector(37.9967328181819, -77.663813),
                    new Vector(38.0107548181818, -77.67670099999999),
                    new Vector(38.0111868181818, -77.689544),
                    new Vector(38.0156778181818, -77.716436),
                    new Vector(38.0306088181819, -77.732834),
                    new Vector(38.0246868181818, -77.74799899999989),
                    new Vector(38.0477898181819, -77.749835),
                    new Vector(38.0644848181819, -77.787887),
                    new Vector(38.0717388181819, -77.78733800000001),
                    new Vector(38.0780208181819, -77.811323),
                    new Vector(38.1015288181818, -77.83657700000001),
                    new Vector(38.1051108181819, -77.853551),
                    new Vector(38.0987388181819, -77.86112900000001),
                    new Vector(38.1108978181818, -77.8851769999999),
                    new Vector(38.1210858181819, -77.958347),
                    new Vector(38.1209958181819, -77.979992),
                    new Vector(38.138572818182, -78.001169),
                    new Vector(38.1412098181818, -78.02283199999989),
                    new Vector(38.1324708181819, -78.05202800000001),
                    new Vector(38.1499308181818, -78.100151),
                    new Vector(38.1398328181819, -78.123479),
                    new Vector(38.142937818182, -78.138716),
                    new Vector(38.126818818182, -78.18538100000001),
                    new Vector(38.1271428181819, -78.207035),
                    new Vector(38.184121818182, -78.370358),
                    new Vector(38.2741848181818, -78.6580969999999),
                    new Vector(38.2509738181819, -78.66887),
                    new Vector(38.2350438181819, -78.72427399999999),
                    new Vector(38.2071078181819, -78.75194),
                    new Vector(38.1775788181819, -78.75728599999999),
                    new Vector(38.1333528181819, -78.782855),
                    new Vector(38.0812608181819, -78.77903000000001),
                    new Vector(38.0425428181819, -78.83913200000001),
                    new Vector(38.0302668181819, -78.88332200000001),
                    new Vector(37.9906668181818, -78.898343),
                    new Vector(37.9521558181818, -78.89645299999999),
                    new Vector(37.9332198181818, -78.92701700000001),
                    new Vector(37.9324818181818, -78.95093900000001),
                    new Vector(37.8871398181819, -78.990278),
                    new Vector(37.8892728181818, -79.03523300000001),
                    new Vector(37.9125108181818, -79.0625569999999),
                    new Vector(37.9007028181818, -79.099052),
                    new Vector(37.9021338181819, -79.127672),
                    new Vector(37.8896058181818, -79.149551),
                    new Vector(37.9137078181819, -79.178099),
                    new Vector(38.0854908181819, -79.48260500000001),
                    new Vector(38.0453418181818, -79.524788),
                    new Vector(38.0259648181819, -79.518407),
                    new Vector(37.9878948181818, -79.54539800000001),
                    new Vector(37.9350468181818, -79.613978),
                    new Vector(37.8773658181818, -79.646162),
                    new Vector(37.842643818182, -79.686536),
                    new Vector(37.8889218181819, -79.75849100000001),
                    new Vector(37.8850698181819, -79.819034),
                    new Vector(37.8977958181818, -79.88827999999999),
                    new Vector(37.9563048181819, -79.933379),
                    new Vector(37.9621188181818, -80.004227),
                    new Vector(37.9461258181819, -80.03228900000001),
                    new Vector(37.9556388181819, -80.054807),
                    new Vector(37.9146438181819, -80.1064939999999),
                    new Vector(37.8912708181817, -80.118509),
                    new Vector(37.8772218181818, -80.160008),
                    new Vector(37.8601848181818, -80.17222099999999),
                    new Vector(37.8429678181819, -80.17159100000001),
                    new Vector(37.8023598181819, -80.223737),
                    new Vector(37.7788518181819, -80.22054199999999),
                    new Vector(37.7572158181819, -80.254688),
                    new Vector(37.7260668181819, -80.250035),
                    new Vector(37.6826778181818, -80.3031079999999),
                    new Vector(37.6715088181819, -80.29570099999999),
                    new Vector(37.6522488181819, -80.304863),
                    new Vector(37.6405488181819, -80.300939),
                    new Vector(37.6407018181818, -80.254418),
                    new Vector(37.6242858181819, -80.2189309999999),
                    new Vector(37.5969078181819, -80.24639000000001),
                    new Vector(37.5667128181819, -80.316716),
                    new Vector(37.5333948181819, -80.32590500000001),
                    new Vector(37.5283548181819, -80.308301),
                    new Vector(37.5362478181819, -80.280725),
                    new Vector(37.5111288181819, -80.2879159999999),
                    new Vector(37.4911848181818, -80.3475049999999),
                    new Vector(37.4761098181818, -80.352158),
                    new Vector(37.4657328181819, -80.388311),
                    new Vector(37.4349168181818, -80.425382),
                    new Vector(37.4228388181818, -80.474765),
                    new Vector(37.433872818182, -80.48679799999999),
                    new Vector(37.4606208181819, -80.48787799999999),
                    new Vector(37.4750298181818, -80.50876700000001),
                    new Vector(37.4691888181819, -80.542751),
                    new Vector(37.4460498181819, -80.5974889999999),
                    new Vector(37.3883778181819, -80.70520999999999),
                    new Vector(37.3927248181819, -80.72973500000001),
                    new Vector(37.3877478181819, -80.7463309999999),
                    new Vector(37.3790898181819, -80.74769000000001),
                    new Vector(37.3713948181818, -80.76299),
                    new Vector(37.3861728181819, -80.770019),
                    new Vector(37.3917348181819, -80.79924200000001),
                    new Vector(37.4130468181818, -80.799611),
                    new Vector(37.4234418181818, -80.85052399999999),
                    new Vector(37.3886838181818, -80.877353),
                    new Vector(37.3509288181819, -80.8484179999999),
                    new Vector(37.3393908181819, -80.855429),
                    new Vector(37.3013658181819, -80.934179),
                    new Vector(37.2917898181819, -80.967893),
                    new Vector(37.2964698181818, -80.97854),
                    new Vector(37.3062438181819, -80.985938),
                    new Vector(37.2860388181819, -81.024935),
                    new Vector(37.2749058181818, -81.140738),
                    new Vector(37.2402108181819, -81.22293500000001),
                    new Vector(37.2936888181818, -81.31187300000001),
                    new Vector(37.338949818182, -81.35879),
                    new Vector(37.3111488181819, -81.390947),
                    new Vector(37.2826188181819, -81.40334900000001),
                    new Vector(37.2544218181818, -81.47536700000001),
                    new Vector(37.2528558181819, -81.495536),
                    new Vector(37.2343518181819, -81.50553499999999),
                    new Vector(37.2063348181819, -81.55665500000001),
                    new Vector(37.2049038181818, -81.665879),
                    new Vector(37.2354228181819, -81.70172599999999),
                    new Vector(37.2504888181818, -81.738455),
                    new Vector(37.2722148181819, -81.751856),
                    new Vector(37.2871188181819, -81.79266200000001),
                    new Vector(37.2795048181818, -81.8153779999999),
                    new Vector(37.285480818182, -81.83889499999999),
                    new Vector(37.3070088181818, -81.85868600000001),
                    new Vector(37.3254408181819, -81.863816),
                    new Vector(37.3405698181819, -81.89715200000001),
                    new Vector(37.3717098181818, -81.926816),
                    new Vector(37.4155038181819, -81.920732),
                    new Vector(37.4665788181817, -81.988196),
                    new Vector(37.482886818182, -81.976415),
                    new Vector(37.4930118181818, -81.9479929999999),
                    new Vector(37.506637818182, -81.935456),
                    new Vector(37.5311718181819, -81.959576),
                    new Vector(37.3048398181818, -82.28895799999999),
                    new Vector(37.2604968181819, -82.353848),
                    new Vector(37.2506868181818, -82.405886),
                    new Vector(37.1993418181818, -82.550039),
                    new Vector(37.1938878181818, -82.56802999999999),
                    new Vector(37.1100078181819, -82.719104),
                    new Vector(37.0931058181818, -82.721372),
                    new Vector(37.0754748181819, -82.709177),
                    new Vector(37.0659168181819, -82.72005799999999),
                    new Vector(37.0339938181818, -82.72360399999999),
                    new Vector(37.0055898181818, -82.81222699999999),
                    new Vector(36.9745668181818, -82.86655999999989),
                    new Vector(36.9321498181819, -82.86063799999989),
                    new Vector(36.8936748181819, -82.878044),
                    new Vector(36.8640648181819, -82.95080899999989),
                    new Vector(36.8587638181819, -83.046632),
                    new Vector(36.8509698181819, -83.067953),
                    new Vector(36.7791408181818, -83.12821700000001),
                    new Vector(36.7511508181819, -83.124392),
                    new Vector(36.7400538181818, -83.138513),
                    new Vector(36.7342668181819, -83.203655),
                    new Vector(36.7095258181819, -83.32138399999999),
                    new Vector(36.6882138181819, -83.385851),
                    new Vector(36.6723288181819, -83.4041569999999),
                    new Vector(36.6618348181819, -83.4602179999999),
                    new Vector(36.6614658181819, -83.530895),
                    new Vector(36.616960818182, -83.64679700000001),
                    new Vector(36.5986908181818, -83.6751739999999),
                    new Vector(36.5988438181818, -83.46420500000001)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(37.9702638181819, -75.64786700000001),
                    new Vector(37.9413108181819, -75.6581),
                    new Vector(37.9306998181818, -75.733628),
                    new Vector(37.8582588181818, -75.686351),
                    new Vector(37.8246438181819, -75.69573800000001),
                    new Vector(37.7899488181819, -75.78225500000001),
                    new Vector(37.7119188181818, -75.799373),
                    new Vector(37.5923088181818, -75.90564499999989),
                    new Vector(37.5804738181819, -75.88692500000001),
                    new Vector(37.5860178181818, -75.929216),
                    new Vector(37.5616818181819, -75.9407539999999),
                    new Vector(37.5523128181819, -75.867026),
                    new Vector(37.5570198181818, -75.930413),
                    new Vector(37.5219648181818, -75.954362),
                    new Vector(37.4795028181819, -75.965099),
                    new Vector(37.4847858181819, -75.93410299999989),
                    new Vector(37.3089078181819, -76.01812700000001),
                    new Vector(37.1263788181818, -75.970634),
                    new Vector(37.1426418181819, -75.931034),
                    new Vector(37.3675248181819, -75.896762),
                    new Vector(37.4182848181818, -75.826328),
                    new Vector(37.4082408181819, -75.790418),
                    new Vector(37.4263398181818, -75.82013600000001),
                    new Vector(37.4691798181818, -75.812684),
                    new Vector(37.493623818182, -75.70491800000001),
                    new Vector(37.5106518181819, -75.75615500000001),
                    new Vector(37.5583158181819, -75.727175),
                    new Vector(37.5598908181818, -75.649919),
                    new Vector(37.5896448181819, -75.69914900000001),
                    new Vector(37.6773228181819, -75.589556),
                    new Vector(37.6972758181819, -75.61757299999989),
                    new Vector(38.0168298181819, -75.372422),
                    new Vector(37.9965438181819, -75.62607800000001),
                    new Vector(37.9702638181819, -75.64786700000001)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(38.0276928181818, -75.270353),
                    new Vector(37.9189098181819, -75.34633100000001),
                    new Vector(37.9010898181818, -75.3782089999999),
                    new Vector(37.9020258181819, -75.344459),
                    new Vector(37.8757728181818, -75.385715),
                    new Vector(37.8889038181819, -75.33881599999999),
                    new Vector(37.9629828181818, -75.298496),
                    new Vector(38.0286468181819, -75.24221900000001),
                    new Vector(38.0276928181818, -75.270353)
                })
            }
        };
    }
}