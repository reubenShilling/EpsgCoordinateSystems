using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Virginia_South_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2284;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Virginia South";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Virginia South (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,37.96666666666667],PARAMETER[standard_parallel_2,36.76666666666667],PARAMETER[latitude_of_origin,36.33333333333334],PARAMETER[central_meridian,-78.5],PARAMETER[false_easting,11482916.667],PARAMETER[false_northing,3280833.333],AUTHORITY[EPSG,2284],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Virginia South (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,37.96666666666667],PARAMETER[standard_parallel_2,36.76666666666667],PARAMETER[latitude_of_origin,36.33333333333334],PARAMETER[central_meridian,-78.5],PARAMETER[false_easting,11482916.667],PARAMETER[false_northing,3280833.333],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-83.46420500000001, 36.5988438181818, 0),
                    new Vector(-83.275025, 36.6004458181819, 0),
                    new Vector(-83.248394, 36.5899338181818, 0),
                    new Vector(-83.210927, 36.5880888181819, 0),
                    new Vector(-82.986701, 36.5912928181818, 0),
                    new Vector(-82.84981999999999, 36.5910228181818, 0),
                    new Vector(-82.610834, 36.5915268181818, 0),
                    new Vector(-82.296851, 36.5917788181819, 0),
                    new Vector(-82.216661, 36.5940738181819, 0),
                    new Vector(-82.154183, 36.5951358181818, 0),
                    new Vector(-81.9293, 36.5959548181819, 0),
                    new Vector(-81.91829300000001, 36.6136128181819, 0),
                    new Vector(-81.828896, 36.6115878181818, 0),
                    new Vector(-81.652271, 36.6076728181819, 0),
                    new Vector(-81.669839, 36.5897718181819, 0),
                    new Vector(-81.345119, 36.5729688181818, 0),
                    new Vector(-80.903237, 36.5653368181818, 0),
                    new Vector(-80.837951, 36.5635638181818, 0),
                    new Vector(-80.6108449999999, 36.5574168181818, 0),
                    new Vector(-80.4350929999999, 36.5511798181818, 0),
                    new Vector(-80.04786799999999, 36.5472558181818, 0),
                    new Vector(-80.02382, 36.5451498181819, 0),
                    new Vector(-79.71719899999989, 36.5480298181819, 0),
                    new Vector(-79.510046, 36.5477688181819, 0),
                    new Vector(-79.21679899999999, 36.5499198181818, 0),
                    new Vector(-79.14406099999999, 36.5461938181819, 0),
                    new Vector(-78.79642699999989, 36.5436648181819, 0),
                    new Vector(-78.737117, 36.5462208181818, 0),
                    new Vector(-78.45853099999999, 36.5416218181818, 0),
                    new Vector(-78.320975, 36.5456718181819, 0),
                    new Vector(-78.05137999999999, 36.5526108181819, 0),
                    new Vector(-77.89856899999999, 36.5530878181819, 0),
                    new Vector(-77.763632, 36.5535738181818, 0),
                    new Vector(-77.319743, 36.5540508181819, 0),
                    new Vector(-77.177048, 36.5564358181818, 0),
                    new Vector(-76.923815, 36.5542938181819, 0),
                    new Vector(-76.921322, 36.5543118181819, 0),
                    new Vector(-76.56325699999999, 36.5553918181819, 0),
                    new Vector(-76.497224, 36.5559678181818, 0),
                    new Vector(-76.329914, 36.5562018181818, 0),
                    new Vector(-76.127054, 36.5573088181819, 0),
                    new Vector(-76.045613, 36.5570928181818, 0),
                    new Vector(-76.06150700000001, 36.6037398181819, 0),
                    new Vector(-76.026821, 36.5568588181818, 0),
                    new Vector(-75.9983179999999, 36.5568048181818, 0),
                    new Vector(-75.950447, 36.7217298181818, 0),
                    new Vector(-75.89249599999989, 36.5991768181818, 0),
                    new Vector(-75.90163099999999, 36.5563458181819, 0),
                    new Vector(-75.877808, 36.5560218181819, 0),
                    new Vector(-75.995015, 36.9232938181819, 0),
                    new Vector(-76.11809, 36.9317628181819, 0),
                    new Vector(-76.191323, 36.9045918181819, 0),
                    new Vector(-76.201988, 36.9352188181819, 0),
                    new Vector(-76.283888, 36.9628758181819, 0),
                    new Vector(-76.30727899999989, 36.9421488181818, 0),
                    new Vector(-76.292366, 36.8284788181819, 0),
                    new Vector(-76.317098, 36.8459838181819, 0),
                    new Vector(-76.400852, 36.8262828181819, 0),
                    new Vector(-76.39375099999999, 36.8360748181818, 0),
                    new Vector(-76.341578, 36.8603298181818, 0),
                    new Vector(-76.34780600000001, 36.9134838181819, 0),
                    new Vector(-76.410473, 36.9015678181818, 0),
                    new Vector(-76.506863, 36.8696088181818, 0),
                    new Vector(-76.56152899999999, 36.7957548181819, 0),
                    new Vector(-76.560188, 36.8419338181819, 0),
                    new Vector(-76.486289, 36.8957178181818, 0),
                    new Vector(-76.481843, 36.9192348181818, 0),
                    new Vector(-76.51684400000001, 36.9123138181819, 0),
                    new Vector(-76.489178, 36.9618858181819, 0),
                    new Vector(-76.554716, 37.0063368181818, 0),
                    new Vector(-76.613045, 36.9949878181818, 0),
                    new Vector(-76.577504, 37.0246338181819, 0),
                    new Vector(-76.665317, 37.0542798181818, 0),
                    new Vector(-76.671221, 37.1478528181819, 0),
                    new Vector(-76.685648, 37.1981358181819, 0),
                    new Vector(-76.728893, 37.1508138181819, 0),
                    new Vector(-76.797077, 37.2074508181819, 0),
                    new Vector(-76.900541, 37.2012048181818, 0),
                    new Vector(-76.941176, 37.2367728181818, 0),
                    new Vector(-76.878113, 37.2595608181819, 0),
                    new Vector(-76.87517, 37.3230828181818, 0),
                    new Vector(-76.856855, 37.2440538181819, 0),
                    new Vector(-76.79561, 37.2405348181819, 0),
                    new Vector(-76.745786, 37.1935368181819, 0),
                    new Vector(-76.696826, 37.2326598181818, 0),
                    new Vector(-76.64777599999999, 37.2259818181819, 0),
                    new Vector(-76.609706, 37.1787138181818, 0),
                    new Vector(-76.62459199999989, 37.1324178181818, 0),
                    new Vector(-76.568117, 37.080307818182, 0),
                    new Vector(-76.564166, 37.1179098181819, 0),
                    new Vector(-76.51493600000001, 37.0884978181819, 0),
                    new Vector(-76.530794, 37.0677798181819, 0),
                    new Vector(-76.425782, 36.9654048181819, 0),
                    new Vector(-76.38422, 36.9905598181819, 0),
                    new Vector(-76.29300499999999, 37.0206198181818, 0),
                    new Vector(-76.278587, 37.0744758181818, 0),
                    new Vector(-76.39536200000001, 37.1078478181819, 0),
                    new Vector(-76.285337, 37.1222298181819, 0),
                    new Vector(-76.336979, 37.1771478181819, 0),
                    new Vector(-76.3634569999999, 37.1465658181818, 0),
                    new Vector(-76.396541, 37.1731698181819, 0),
                    new Vector(-76.41266, 37.1525328181818, 0),
                    new Vector(-76.424333, 37.2074418181818, 0),
                    new Vector(-76.59472100000001, 37.2914388181818, 0),
                    new Vector(-76.669664, 37.3717908181819, 0),
                    new Vector(-76.704368, 37.4186358181819, 0),
                    new Vector(-76.6531669999999, 37.4123448181819, 0),
                    new Vector(-76.46081, 37.2555738181819, 0),
                    new Vector(-76.39241, 37.2935628181818, 0),
                    new Vector(-76.45522099999999, 37.3776408181819, 0),
                    new Vector(-76.4034259999999, 37.3731768181819, 0),
                    new Vector(-76.4167549999999, 37.412281818182, 0),
                    new Vector(-76.46360900000001, 37.4190408181818, 0),
                    new Vector(-76.44653599999999, 37.4581098181818, 0),
                    new Vector(-76.33868, 37.3936788181818, 0),
                    new Vector(-76.30063699999999, 37.3347108181819, 0),
                    new Vector(-76.274852, 37.3304538181819, 0),
                    new Vector(-76.2542509999999, 37.3903218181819, 0),
                    new Vector(-76.355339, 37.5158808181818, 0),
                    new Vector(-76.43385499999999, 37.5153408181819, 0),
                    new Vector(-76.512524, 37.5527088181818, 0),
                    new Vector(-76.34831, 37.5252858181819, 0),
                    new Vector(-76.3143079999999, 37.5513228181819, 0),
                    new Vector(-76.56917, 37.6420428181819, 0),
                    new Vector(-76.681409, 37.7748918181818, 0),
                    new Vector(-76.732034, 37.7986158181819, 0),
                    new Vector(-76.818191, 37.9196388181819, 0),
                    new Vector(-76.771535, 37.9168038181819, 0),
                    new Vector(-76.63145900000001, 37.7964828181819, 0),
                    new Vector(-76.58013200000001, 37.7702478181819, 0),
                    new Vector(-76.506764, 37.6565148181819, 0),
                    new Vector(-76.344539, 37.6230528181819, 0),
                    new Vector(-76.3227229999999, 37.6779438181817, 0),
                    new Vector(-76.35667100000001, 37.7002638181818, 0),
                    new Vector(-76.30961000000001, 37.7192448181818, 0),
                    new Vector(-76.324208, 37.7989488181819, 0),
                    new Vector(-76.251587, 37.8503118181819, 0),
                    new Vector(-76.25886800000001, 37.8901638181818, 0),
                    new Vector(-76.367417, 37.9570968181819, 0),
                    new Vector(-76.524215, 38.0128698181818, 0),
                    new Vector(-76.573373, 38.003302818182, 0),
                    new Vector(-76.557722, 38.0254608181819, 0),
                    new Vector(-76.581293, 38.0242098181818, 0),
                    new Vector(-76.594982, 38.0030058181819, 0),
                    new Vector(-76.619561, 37.9995768181818, 0),
                    new Vector(-76.63919, 37.9688868181818, 0),
                    new Vector(-76.65946700000001, 37.9830798181818, 0),
                    new Vector(-76.702091, 37.9829088181819, 0),
                    new Vector(-76.719461, 37.9966248181818, 0),
                    new Vector(-76.763228, 38.0004948181819, 0),
                    new Vector(-76.762373, 38.0276838181818, 0),
                    new Vector(-76.801253, 38.0551158181819, 0),
                    new Vector(-76.819334, 38.0597508181819, 0),
                    new Vector(-76.878545, 38.1090168181818, 0),
                    new Vector(-76.92776600000001, 38.0965698181819, 0),
                    new Vector(-76.94976200000001, 38.0786598181818, 0),
                    new Vector(-76.98280099999999, 38.0882088181818, 0),
                    new Vector(-77.00198, 38.1054978181818, 0),
                    new Vector(-77.02018700000001, 38.0942478181819, 0),
                    new Vector(-77.037719, 38.0961288181818, 0),
                    new Vector(-77.05342400000001, 38.1088728181818, 0),
                    new Vector(-77.05555699999999, 38.1433248181818, 0),
                    new Vector(-77.07245899999999, 38.1556278181819, 0),
                    new Vector(-77.086544, 38.1488778181819, 0),
                    new Vector(-77.101106, 38.1616218181819, 0),
                    new Vector(-77.1205099999999, 38.1449088181818, 0),
                    new Vector(-77.1170989999999, 38.1254058181819, 0),
                    new Vector(-77.145206, 38.1196008181819, 0),
                    new Vector(-77.16882200000001, 38.0734398181819, 0),
                    new Vector(-77.129249, 38.0366118181819, 0),
                    new Vector(-77.133398, 38.0230218181819, 0),
                    new Vector(-77.081504, 38.0065338181819, 0),
                    new Vector(-77.074106, 37.9707138181818, 0),
                    new Vector(-77.096912, 37.9658088181819, 0),
                    new Vector(-77.107973, 37.9717398181818, 0),
                    new Vector(-77.152343, 37.9700658181819, 0),
                    new Vector(-77.16871399999999, 37.9637658181818, 0),
                    new Vector(-77.18459900000001, 37.9361538181819, 0),
                    new Vector(-77.17890199999989, 37.9057698181819, 0),
                    new Vector(-77.187686, 37.8967248181818, 0),
                    new Vector(-77.19296, 37.8894888181819, 0),
                    new Vector(-77.21278700000001, 37.8877248181818, 0),
                    new Vector(-77.210987, 37.9022238181819, 0),
                    new Vector(-77.2436299999999, 37.9118178181819, 0),
                    new Vector(-77.247248, 37.8760158181818, 0),
                    new Vector(-77.28404, 37.8538758181819, 0),
                    new Vector(-77.294012, 37.8339498181819, 0),
                    new Vector(-77.34418700000001, 37.8013788181818, 0),
                    new Vector(-77.34654500000001, 37.7909658181818, 0),
                    new Vector(-77.35586000000001, 37.7882568181818, 0),
                    new Vector(-77.365166, 37.7959698181818, 0),
                    new Vector(-77.38790899999999, 37.7765118181819, 0),
                    new Vector(-77.404217, 37.7783388181819, 0),
                    new Vector(-77.40651200000001, 37.804168818182, 0),
                    new Vector(-77.4175819999999, 37.8023598181819, 0),
                    new Vector(-77.42805799999999, 37.8109818181819, 0),
                    new Vector(-77.42105599999999, 37.8205038181819, 0),
                    new Vector(-77.43326, 37.8477018181818, 0),
                    new Vector(-77.42101099999999, 37.8644598181819, 0),
                    new Vector(-77.440811, 37.8912168181819, 0),
                    new Vector(-77.483966, 37.8817218181818, 0),
                    new Vector(-77.52595100000001, 37.9179648181819, 0),
                    new Vector(-77.5387939999999, 37.9143378181818, 0),
                    new Vector(-77.55221299999999, 37.9229418181819, 0),
                    new Vector(-77.548721, 37.9338228181818, 0),
                    new Vector(-77.57501000000001, 37.9623618181818, 0),
                    new Vector(-77.587259, 37.9505718181819, 0),
                    new Vector(-77.603027, 37.9573668181819, 0),
                    new Vector(-77.61760700000001, 37.9532628181819, 0),
                    new Vector(-77.64687499999999, 37.9958418181819, 0),
                    new Vector(-77.663813, 37.9967328181819, 0),
                    new Vector(-77.67670099999999, 38.0107548181818, 0),
                    new Vector(-77.689544, 38.0111868181818, 0),
                    new Vector(-77.716436, 38.0156778181818, 0),
                    new Vector(-77.732834, 38.0306088181819, 0),
                    new Vector(-77.74799899999989, 38.0246868181818, 0),
                    new Vector(-77.749835, 38.0477898181819, 0),
                    new Vector(-77.787887, 38.0644848181819, 0),
                    new Vector(-77.78733800000001, 38.0717388181819, 0),
                    new Vector(-77.811323, 38.0780208181819, 0),
                    new Vector(-77.83657700000001, 38.1015288181818, 0),
                    new Vector(-77.853551, 38.1051108181819, 0),
                    new Vector(-77.86112900000001, 38.0987388181819, 0),
                    new Vector(-77.8851769999999, 38.1108978181818, 0),
                    new Vector(-77.958347, 38.1210858181819, 0),
                    new Vector(-77.979992, 38.1209958181819, 0),
                    new Vector(-78.001169, 38.138572818182, 0),
                    new Vector(-78.02283199999989, 38.1412098181818, 0),
                    new Vector(-78.05202800000001, 38.1324708181819, 0),
                    new Vector(-78.100151, 38.1499308181818, 0),
                    new Vector(-78.123479, 38.1398328181819, 0),
                    new Vector(-78.138716, 38.142937818182, 0),
                    new Vector(-78.18538100000001, 38.126818818182, 0),
                    new Vector(-78.207035, 38.1271428181819, 0),
                    new Vector(-78.370358, 38.184121818182, 0),
                    new Vector(-78.6580969999999, 38.2741848181818, 0),
                    new Vector(-78.66887, 38.2509738181819, 0),
                    new Vector(-78.72427399999999, 38.2350438181819, 0),
                    new Vector(-78.75194, 38.2071078181819, 0),
                    new Vector(-78.75728599999999, 38.1775788181819, 0),
                    new Vector(-78.782855, 38.1333528181819, 0),
                    new Vector(-78.77903000000001, 38.0812608181819, 0),
                    new Vector(-78.83913200000001, 38.0425428181819, 0),
                    new Vector(-78.88332200000001, 38.0302668181819, 0),
                    new Vector(-78.898343, 37.9906668181818, 0),
                    new Vector(-78.89645299999999, 37.9521558181818, 0),
                    new Vector(-78.92701700000001, 37.9332198181818, 0),
                    new Vector(-78.95093900000001, 37.9324818181818, 0),
                    new Vector(-78.990278, 37.8871398181819, 0),
                    new Vector(-79.03523300000001, 37.8892728181818, 0),
                    new Vector(-79.0625569999999, 37.9125108181818, 0),
                    new Vector(-79.099052, 37.9007028181818, 0),
                    new Vector(-79.127672, 37.9021338181819, 0),
                    new Vector(-79.149551, 37.8896058181818, 0),
                    new Vector(-79.178099, 37.9137078181819, 0),
                    new Vector(-79.48260500000001, 38.0854908181819, 0),
                    new Vector(-79.524788, 38.0453418181818, 0),
                    new Vector(-79.518407, 38.0259648181819, 0),
                    new Vector(-79.54539800000001, 37.9878948181818, 0),
                    new Vector(-79.613978, 37.9350468181818, 0),
                    new Vector(-79.646162, 37.8773658181818, 0),
                    new Vector(-79.686536, 37.842643818182, 0),
                    new Vector(-79.75849100000001, 37.8889218181819, 0),
                    new Vector(-79.819034, 37.8850698181819, 0),
                    new Vector(-79.88827999999999, 37.8977958181818, 0),
                    new Vector(-79.933379, 37.9563048181819, 0),
                    new Vector(-80.004227, 37.9621188181818, 0),
                    new Vector(-80.03228900000001, 37.9461258181819, 0),
                    new Vector(-80.054807, 37.9556388181819, 0),
                    new Vector(-80.1064939999999, 37.9146438181819, 0),
                    new Vector(-80.118509, 37.8912708181817, 0),
                    new Vector(-80.160008, 37.8772218181818, 0),
                    new Vector(-80.17222099999999, 37.8601848181818, 0),
                    new Vector(-80.17159100000001, 37.8429678181819, 0),
                    new Vector(-80.223737, 37.8023598181819, 0),
                    new Vector(-80.22054199999999, 37.7788518181819, 0),
                    new Vector(-80.254688, 37.7572158181819, 0),
                    new Vector(-80.250035, 37.7260668181819, 0),
                    new Vector(-80.3031079999999, 37.6826778181818, 0),
                    new Vector(-80.29570099999999, 37.6715088181819, 0),
                    new Vector(-80.304863, 37.6522488181819, 0),
                    new Vector(-80.300939, 37.6405488181819, 0),
                    new Vector(-80.254418, 37.6407018181818, 0),
                    new Vector(-80.2189309999999, 37.6242858181819, 0),
                    new Vector(-80.24639000000001, 37.5969078181819, 0),
                    new Vector(-80.316716, 37.5667128181819, 0),
                    new Vector(-80.32590500000001, 37.5333948181819, 0),
                    new Vector(-80.308301, 37.5283548181819, 0),
                    new Vector(-80.280725, 37.5362478181819, 0),
                    new Vector(-80.2879159999999, 37.5111288181819, 0),
                    new Vector(-80.3475049999999, 37.4911848181818, 0),
                    new Vector(-80.352158, 37.4761098181818, 0),
                    new Vector(-80.388311, 37.4657328181819, 0),
                    new Vector(-80.425382, 37.4349168181818, 0),
                    new Vector(-80.474765, 37.4228388181818, 0),
                    new Vector(-80.48679799999999, 37.433872818182, 0),
                    new Vector(-80.48787799999999, 37.4606208181819, 0),
                    new Vector(-80.50876700000001, 37.4750298181818, 0),
                    new Vector(-80.542751, 37.4691888181819, 0),
                    new Vector(-80.5974889999999, 37.4460498181819, 0),
                    new Vector(-80.70520999999999, 37.3883778181819, 0),
                    new Vector(-80.72973500000001, 37.3927248181819, 0),
                    new Vector(-80.7463309999999, 37.3877478181819, 0),
                    new Vector(-80.74769000000001, 37.3790898181819, 0),
                    new Vector(-80.76299, 37.3713948181818, 0),
                    new Vector(-80.770019, 37.3861728181819, 0),
                    new Vector(-80.79924200000001, 37.3917348181819, 0),
                    new Vector(-80.799611, 37.4130468181818, 0),
                    new Vector(-80.85052399999999, 37.4234418181818, 0),
                    new Vector(-80.877353, 37.3886838181818, 0),
                    new Vector(-80.8484179999999, 37.3509288181819, 0),
                    new Vector(-80.855429, 37.3393908181819, 0),
                    new Vector(-80.934179, 37.3013658181819, 0),
                    new Vector(-80.967893, 37.2917898181819, 0),
                    new Vector(-80.97854, 37.2964698181818, 0),
                    new Vector(-80.985938, 37.3062438181819, 0),
                    new Vector(-81.024935, 37.2860388181819, 0),
                    new Vector(-81.140738, 37.2749058181818, 0),
                    new Vector(-81.22293500000001, 37.2402108181819, 0),
                    new Vector(-81.31187300000001, 37.2936888181818, 0),
                    new Vector(-81.35879, 37.338949818182, 0),
                    new Vector(-81.390947, 37.3111488181819, 0),
                    new Vector(-81.40334900000001, 37.2826188181819, 0),
                    new Vector(-81.47536700000001, 37.2544218181818, 0),
                    new Vector(-81.495536, 37.2528558181819, 0),
                    new Vector(-81.50553499999999, 37.2343518181819, 0),
                    new Vector(-81.55665500000001, 37.2063348181819, 0),
                    new Vector(-81.665879, 37.2049038181818, 0),
                    new Vector(-81.70172599999999, 37.2354228181819, 0),
                    new Vector(-81.738455, 37.2504888181818, 0),
                    new Vector(-81.751856, 37.2722148181819, 0),
                    new Vector(-81.79266200000001, 37.2871188181819, 0),
                    new Vector(-81.8153779999999, 37.2795048181818, 0),
                    new Vector(-81.83889499999999, 37.285480818182, 0),
                    new Vector(-81.85868600000001, 37.3070088181818, 0),
                    new Vector(-81.863816, 37.3254408181819, 0),
                    new Vector(-81.89715200000001, 37.3405698181819, 0),
                    new Vector(-81.926816, 37.3717098181818, 0),
                    new Vector(-81.920732, 37.4155038181819, 0),
                    new Vector(-81.988196, 37.4665788181817, 0),
                    new Vector(-81.976415, 37.482886818182, 0),
                    new Vector(-81.9479929999999, 37.4930118181818, 0),
                    new Vector(-81.935456, 37.506637818182, 0),
                    new Vector(-81.959576, 37.5311718181819, 0),
                    new Vector(-82.28895799999999, 37.3048398181818, 0),
                    new Vector(-82.353848, 37.2604968181819, 0),
                    new Vector(-82.405886, 37.2506868181818, 0),
                    new Vector(-82.550039, 37.1993418181818, 0),
                    new Vector(-82.56802999999999, 37.1938878181818, 0),
                    new Vector(-82.719104, 37.1100078181819, 0),
                    new Vector(-82.721372, 37.0931058181818, 0),
                    new Vector(-82.709177, 37.0754748181819, 0),
                    new Vector(-82.72005799999999, 37.0659168181819, 0),
                    new Vector(-82.72360399999999, 37.0339938181818, 0),
                    new Vector(-82.81222699999999, 37.0055898181818, 0),
                    new Vector(-82.86655999999989, 36.9745668181818, 0),
                    new Vector(-82.86063799999989, 36.9321498181819, 0),
                    new Vector(-82.878044, 36.8936748181819, 0),
                    new Vector(-82.95080899999989, 36.8640648181819, 0),
                    new Vector(-83.046632, 36.8587638181819, 0),
                    new Vector(-83.067953, 36.8509698181819, 0),
                    new Vector(-83.12821700000001, 36.7791408181818, 0),
                    new Vector(-83.124392, 36.7511508181819, 0),
                    new Vector(-83.138513, 36.7400538181818, 0),
                    new Vector(-83.203655, 36.7342668181819, 0),
                    new Vector(-83.32138399999999, 36.7095258181819, 0),
                    new Vector(-83.385851, 36.6882138181819, 0),
                    new Vector(-83.4041569999999, 36.6723288181819, 0),
                    new Vector(-83.4602179999999, 36.6618348181819, 0),
                    new Vector(-83.530895, 36.6614658181819, 0),
                    new Vector(-83.64679700000001, 36.616960818182, 0),
                    new Vector(-83.6751739999999, 36.5986908181818, 0),
                    new Vector(-83.46420500000001, 36.5988438181818, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-75.64786700000001, 37.9702638181819, 0),
                    new Vector(-75.6581, 37.9413108181819, 0),
                    new Vector(-75.733628, 37.9306998181818, 0),
                    new Vector(-75.686351, 37.8582588181818, 0),
                    new Vector(-75.69573800000001, 37.8246438181819, 0),
                    new Vector(-75.78225500000001, 37.7899488181819, 0),
                    new Vector(-75.799373, 37.7119188181818, 0),
                    new Vector(-75.90564499999989, 37.5923088181818, 0),
                    new Vector(-75.88692500000001, 37.5804738181819, 0),
                    new Vector(-75.929216, 37.5860178181818, 0),
                    new Vector(-75.9407539999999, 37.5616818181819, 0),
                    new Vector(-75.867026, 37.5523128181819, 0),
                    new Vector(-75.930413, 37.5570198181818, 0),
                    new Vector(-75.954362, 37.5219648181818, 0),
                    new Vector(-75.965099, 37.4795028181819, 0),
                    new Vector(-75.93410299999989, 37.4847858181819, 0),
                    new Vector(-76.01812700000001, 37.3089078181819, 0),
                    new Vector(-75.970634, 37.1263788181818, 0),
                    new Vector(-75.931034, 37.1426418181819, 0),
                    new Vector(-75.896762, 37.3675248181819, 0),
                    new Vector(-75.826328, 37.4182848181818, 0),
                    new Vector(-75.790418, 37.4082408181819, 0),
                    new Vector(-75.82013600000001, 37.4263398181818, 0),
                    new Vector(-75.812684, 37.4691798181818, 0),
                    new Vector(-75.70491800000001, 37.493623818182, 0),
                    new Vector(-75.75615500000001, 37.5106518181819, 0),
                    new Vector(-75.727175, 37.5583158181819, 0),
                    new Vector(-75.649919, 37.5598908181818, 0),
                    new Vector(-75.69914900000001, 37.5896448181819, 0),
                    new Vector(-75.589556, 37.6773228181819, 0),
                    new Vector(-75.61757299999989, 37.6972758181819, 0),
                    new Vector(-75.372422, 38.0168298181819, 0),
                    new Vector(-75.62607800000001, 37.9965438181819, 0),
                    new Vector(-75.64786700000001, 37.9702638181819, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-75.270353, 38.0276928181818, 0),
                    new Vector(-75.34633100000001, 37.9189098181819, 0),
                    new Vector(-75.3782089999999, 37.9010898181818, 0),
                    new Vector(-75.344459, 37.9020258181819, 0),
                    new Vector(-75.385715, 37.8757728181818, 0),
                    new Vector(-75.33881599999999, 37.8889038181819, 0),
                    new Vector(-75.298496, 37.9629828181818, 0),
                    new Vector(-75.24221900000001, 38.0286468181819, 0),
                    new Vector(-75.270353, 38.0276928181818, 0)
                })
            }
        };
    }
}