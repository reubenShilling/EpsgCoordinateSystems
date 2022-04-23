using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Tennessee_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2274;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Tennessee";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Tennessee (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,36.41666666666666],PARAMETER[standard_parallel_2,35.25],PARAMETER[latitude_of_origin,34.33333333333334],PARAMETER[central_meridian,-86],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],AUTHORITY[EPSG,2274],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Tennessee (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,36.41666666666666],PARAMETER[standard_parallel_2,35.25],PARAMETER[latitude_of_origin,34.33333333333334],PARAMETER[central_meridian,-86],PARAMETER[false_easting,1968500],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-83.954606, 35.4555468181819, 0),
                    new Vector(-83.90991200000001, 35.4765618181818, 0),
                    new Vector(-83.8811299999999, 35.5106718181818, 0),
                    new Vector(-83.8301, 35.5191498181818, 0),
                    new Vector(-83.77577599999999, 35.5526928181819, 0),
                    new Vector(-83.67276200000001, 35.5650678181819, 0),
                    new Vector(-83.613758, 35.5718268181818, 0),
                    new Vector(-83.560919, 35.5552758181818, 0),
                    new Vector(-83.505686, 35.5596498181819, 0),
                    new Vector(-83.4581749999999, 35.5973688181818, 0),
                    new Vector(-83.386976, 35.6253048181819, 0),
                    new Vector(-83.34290300000001, 35.6533578181819, 0),
                    new Vector(-83.29828999999999, 35.6564268181817, 0),
                    new Vector(-83.258996, 35.6911128181818, 0),
                    new Vector(-83.253173, 35.7007968181819, 0),
                    new Vector(-83.243723, 35.7183108181819, 0),
                    new Vector(-83.185214, 35.7289848181819, 0),
                    new Vector(-83.143535, 35.7627798181819, 0),
                    new Vector(-83.118056, 35.7639048181819, 0),
                    new Vector(-83.059826, 35.7826698181818, 0),
                    new Vector(-82.98687200000001, 35.7740928181818, 0),
                    new Vector(-82.96261699999999, 35.7919578181819, 0),
                    new Vector(-82.906691, 35.8723188181819, 0),
                    new Vector(-82.91393600000001, 35.9279748181818, 0),
                    new Vector(-82.89584600000001, 35.9484678181819, 0),
                    new Vector(-82.856138, 35.9475228181819, 0),
                    new Vector(-82.808537, 35.920972818182, 0),
                    new Vector(-82.776308, 35.9566848181818, 0),
                    new Vector(-82.773464, 35.9876088181818, 0),
                    new Vector(-82.763087, 35.9996508181818, 0),
                    new Vector(-82.643756, 36.0518238181819, 0),
                    new Vector(-82.62790699999989, 36.0544428181819, 0),
                    new Vector(-82.604264, 36.0430938181818, 0),
                    new Vector(-82.59208700000001, 36.0225558181818, 0),
                    new Vector(-82.60566799999999, 36.0036558181819, 0),
                    new Vector(-82.5991609999999, 35.9634078181819, 0),
                    new Vector(-82.554008, 35.9562168181818, 0),
                    new Vector(-82.506794, 35.9726508181819, 0),
                    new Vector(-82.47505099999999, 35.9932788181818, 0),
                    new Vector(-82.40828, 36.0754308181819, 0),
                    new Vector(-82.373711, 36.0988128181818, 0),
                    new Vector(-82.31178199999999, 36.1222668181818, 0),
                    new Vector(-82.262165, 36.1204938181818, 0),
                    new Vector(-82.20757999999999, 36.1471248181819, 0),
                    new Vector(-82.153904, 36.1397358181819, 0),
                    new Vector(-82.117931, 36.0963738181819, 0),
                    new Vector(-82.0776019999999, 36.1002618181818, 0),
                    new Vector(-82.02029, 36.1298358181819, 0),
                    new Vector(-81.9329539999999, 36.2634498181818, 0),
                    new Vector(-81.910994, 36.2908728181819, 0),
                    new Vector(-81.83040800000001, 36.3347838181819, 0),
                    new Vector(-81.730328, 36.3294648181818, 0),
                    new Vector(-81.7092949999999, 36.3338568181819, 0),
                    new Vector(-81.74021, 36.3619818181818, 0),
                    new Vector(-81.74091199999989, 36.3919068181819, 0),
                    new Vector(-81.698117, 36.4718988181818, 0),
                    new Vector(-81.702635, 36.5194638181818, 0),
                    new Vector(-81.669839, 36.5897628181819, 0),
                    new Vector(-81.652271, 36.6076728181819, 0),
                    new Vector(-81.828896, 36.6115968181819, 0),
                    new Vector(-81.91829300000001, 36.6136128181819, 0),
                    new Vector(-81.9293, 36.5959548181819, 0),
                    new Vector(-82.154183, 36.5951538181819, 0),
                    new Vector(-82.216661, 36.5940738181819, 0),
                    new Vector(-82.296851, 36.5917968181819, 0),
                    new Vector(-82.610834, 36.5915448181819, 0),
                    new Vector(-82.84981999999999, 36.5910498181819, 0),
                    new Vector(-82.986701, 36.5912928181818, 0),
                    new Vector(-83.210927, 36.5880888181819, 0),
                    new Vector(-83.248394, 36.5899338181818, 0),
                    new Vector(-83.275025, 36.6004638181819, 0),
                    new Vector(-83.46420500000001, 36.5988348181818, 0),
                    new Vector(-83.6751739999999, 36.5986998181818, 0),
                    new Vector(-83.6956129999999, 36.5842458181819, 0),
                    new Vector(-83.935598, 36.5912928181818, 0),
                    new Vector(-84.006743, 36.5920938181818, 0),
                    new Vector(-84.25449500000001, 36.5954508181817, 0),
                    new Vector(-84.256772, 36.5954958181819, 0),
                    new Vector(-84.78187699999999, 36.6050718181818, 0),
                    new Vector(-84.791057, 36.6054408181818, 0),
                    new Vector(-84.998462, 36.6209838181819, 0),
                    new Vector(-85.272503, 36.6256188181819, 0),
                    new Vector(-85.300088, 36.6260958181818, 0),
                    new Vector(-85.43737400000001, 36.6182028181819, 0),
                    new Vector(-85.785476, 36.6266808181819, 0),
                    new Vector(-85.9806049999999, 36.6331068181819, 0),
                    new Vector(-86.19898999999999, 36.6432948181818, 0),
                    new Vector(-86.4154489999999, 36.6509358181818, 0),
                    new Vector(-86.51066, 36.6550758181818, 0),
                    new Vector(-86.770535, 36.6520968181819, 0),
                    new Vector(-87.068183, 36.6508098181819, 0),
                    new Vector(-87.112697, 36.6513048181818, 0),
                    new Vector(-87.34660700000001, 36.6492798181819, 0),
                    new Vector(-87.640655, 36.6452208181818, 0),
                    new Vector(-87.69353, 36.6444918181819, 0),
                    new Vector(-87.853532, 36.6415218181818, 0),
                    new Vector(-87.87071299999999, 36.6694308181819, 0),
                    new Vector(-88.071341, 36.6796818181819, 0),
                    new Vector(-88.04109200000001, 36.5827158181818, 0),
                    new Vector(-88.03507999999999, 36.538201818182, 0),
                    new Vector(-88.042766, 36.4965768181819, 0),
                    new Vector(-88.49602400000001, 36.4982058181819, 0),
                    new Vector(-88.5126829999999, 36.4995468181818, 0),
                    new Vector(-88.81071799999999, 36.4990428181819, 0),
                    new Vector(-88.82635999999999, 36.4999068181819, 0),
                    new Vector(-88.83037400000001, 36.4998528181819, 0),
                    new Vector(-89.34666799999989, 36.5026068181818, 0),
                    new Vector(-89.41477999999999, 36.5026788181819, 0),
                    new Vector(-89.448593, 36.4564458181818, 0),
                    new Vector(-89.4709129999999, 36.4460148181819, 0),
                    new Vector(-89.492063, 36.465526818182, 0),
                    new Vector(-89.475899, 36.4986108181818, 0),
                    new Vector(-89.53327400000001, 36.4981698181819, 0),
                    new Vector(-89.516102, 36.4718718181819, 0),
                    new Vector(-89.545253, 36.4410288181818, 0),
                    new Vector(-89.52007999999999, 36.4011138181818, 0),
                    new Vector(-89.51940500000001, 36.3559968181818, 0),
                    new Vector(-89.54463199999999, 36.3457908181819, 0),
                    new Vector(-89.60576, 36.3548178181818, 0),
                    new Vector(-89.62286899999999, 36.3348468181818, 0),
                    new Vector(-89.606849, 36.3080988181818, 0),
                    new Vector(-89.54231, 36.2809368181818, 0),
                    new Vector(-89.53545200000001, 36.264610818182, 0),
                    new Vector(-89.541725, 36.2573478181818, 0),
                    new Vector(-89.618162, 36.2409678181818, 0),
                    new Vector(-89.67066800000001, 36.2549628181818, 0),
                    new Vector(-89.694626, 36.2521998181818, 0),
                    new Vector(-89.695733, 36.2408598181818, 0),
                    new Vector(-89.676869, 36.2209338181819, 0),
                    new Vector(-89.618639, 36.1838088181819, 0),
                    new Vector(-89.589533, 36.1520928181819, 0),
                    new Vector(-89.58949699999999, 36.1298628181818, 0),
                    new Vector(-89.667464, 36.0993798181819, 0),
                    new Vector(-89.678246, 36.0830358181819, 0),
                    new Vector(-89.68892, 36.0258678181819, 0),
                    new Vector(-89.721833, 35.9999568181819, 0),
                    new Vector(-89.71321999999989, 35.9663958181819, 0),
                    new Vector(-89.664269, 35.9378928181818, 0),
                    new Vector(-89.64548600000001, 35.9138718181819, 0),
                    new Vector(-89.64941899999999, 35.894359818182, 0),
                    new Vector(-89.6647279999999, 35.8857198181819, 0),
                    new Vector(-89.71476800000001, 35.9114958181819, 0),
                    new Vector(-89.738051, 35.9150868181818, 0),
                    new Vector(-89.76299, 35.8968888181819, 0),
                    new Vector(-89.766356, 35.8841808181819, 0),
                    new Vector(-89.75778800000001, 35.8714908181819, 0),
                    new Vector(-89.70152, 35.8421058181819, 0),
                    new Vector(-89.700908, 35.8275888181819, 0),
                    new Vector(-89.736017, 35.807113818182, 0),
                    new Vector(-89.75987600000001, 35.8174998181819, 0),
                    new Vector(-89.79046700000001, 35.8056288181818, 0),
                    new Vector(-89.79998000000001, 35.7742998181819, 0),
                    new Vector(-89.827124, 35.7583428181818, 0),
                    new Vector(-89.859956, 35.7482718181818, 0),
                    new Vector(-89.90986100000001, 35.7549138181819, 0),
                    new Vector(-89.9511169999999, 35.734348818182, 0),
                    new Vector(-89.952116, 35.7125598181819, 0),
                    new Vector(-89.929823, 35.6763438181817, 0),
                    new Vector(-89.89349, 35.6560578181818, 0),
                    new Vector(-89.86526600000001, 35.6733828181819, 0),
                    new Vector(-89.8573279999999, 35.6711418181819, 0),
                    new Vector(-89.849282, 35.6453028181818, 0),
                    new Vector(-89.863916, 35.6298228181818, 0),
                    new Vector(-89.87752399999989, 35.6334138181819, 0),
                    new Vector(-89.957138, 35.6031828181819, 0),
                    new Vector(-89.958119, 35.5786758181819, 0),
                    new Vector(-89.921741, 35.5461408181818, 0),
                    new Vector(-89.931263, 35.5293108181818, 0),
                    new Vector(-89.94763399999999, 35.5269798181818, 0),
                    new Vector(-89.962367, 35.5323708181818, 0),
                    new Vector(-89.989673, 35.5617558181818, 0),
                    new Vector(-90.03313400000002, 35.5524948181819, 0),
                    new Vector(-90.04099100000001, 35.5429278181819, 0),
                    new Vector(-90.041909, 35.5125168181818, 0),
                    new Vector(-89.99965400000001, 35.4455388181819, 0),
                    new Vector(-90.04687699999991, 35.4171888181818, 0),
                    new Vector(-90.06038599999999, 35.4134898181818, 0),
                    new Vector(-90.07402999999989, 35.4265938181819, 0),
                    new Vector(-90.074939, 35.4724308181817, 0),
                    new Vector(-90.0823189999999, 35.4782898181818, 0),
                    new Vector(-90.102056, 35.4736548181818, 0),
                    new Vector(-90.13736299999999, 35.4426048181818, 0),
                    new Vector(-90.172769, 35.4238038181818, 0),
                    new Vector(-90.16790899999998, 35.3843388181819, 0),
                    new Vector(-90.140261, 35.383123818182, 0),
                    new Vector(-90.132566, 35.4076848181818, 0),
                    new Vector(-90.11233400000002, 35.4177738181818, 0),
                    new Vector(-90.08525299999999, 35.4183678181818, 0),
                    new Vector(-90.07555999999991, 35.4066048181818, 0),
                    new Vector(-90.08722399999999, 35.3815938181818, 0),
                    new Vector(-90.10571, 35.3660598181819, 0),
                    new Vector(-90.098789, 35.345683818182, 0),
                    new Vector(-90.10643899999998, 35.314768818182, 0),
                    new Vector(-90.157082, 35.3063268181817, 0),
                    new Vector(-90.16983500000001, 35.2826568181819, 0),
                    new Vector(-90.15222199999999, 35.2641438181819, 0),
                    new Vector(-90.10603399999999, 35.2639368181818, 0),
                    new Vector(-90.0901939999999, 35.2544778181818, 0),
                    new Vector(-90.069053, 35.2128258181818, 0),
                    new Vector(-90.073391, 35.1919188181818, 0),
                    new Vector(-90.06252800000001, 35.1670068181818, 0),
                    new Vector(-90.06462500000001, 35.1474768181819, 0),
                    new Vector(-90.083021, 35.1251388181819, 0),
                    new Vector(-90.14382499999989, 35.1366228181819, 0),
                    new Vector(-90.16456100000001, 35.1297018181818, 0),
                    new Vector(-90.1784389999999, 35.1087408181818, 0),
                    new Vector(-90.169169, 35.077915818182, 0),
                    new Vector(-90.19580000000001, 35.0409888181817, 0),
                    new Vector(-90.291911, 35.0485578181818, 0),
                    new Vector(-90.305447, 35.0007948181818, 0),
                    new Vector(-89.71727, 34.9992648181819, 0),
                    new Vector(-89.64656600000001, 35.000740818182, 0),
                    new Vector(-89.342375, 34.9998048181819, 0),
                    new Vector(-89.198132, 35.0008848181818, 0),
                    new Vector(-89.006198, 35.0002368181818, 0),
                    new Vector(-88.812545, 35.0024328181819, 0),
                    new Vector(-88.78504100000001, 35.0031798181819, 0),
                    new Vector(-88.383146, 35.0050428181819, 0),
                    new Vector(-88.351727, 35.0038368181818, 0),
                    new Vector(-88.19399300000001, 35.0044578181818, 0),
                    new Vector(-88.194965, 35.0135478181818, 0),
                    new Vector(-87.98608400000001, 35.0160408181819, 0),
                    new Vector(-87.607805, 35.0105418181818, 0),
                    new Vector(-87.222767, 35.0073468181819, 0),
                    new Vector(-87.207593, 35.0079678181818, 0),
                    new Vector(-86.83341799999999, 34.9982478181819, 0),
                    new Vector(-86.78237, 34.9970688181819, 0),
                    new Vector(-86.313056, 34.9952688181818, 0),
                    new Vector(-86.303498, 34.9954668181819, 0),
                    new Vector(-85.869563, 34.9923798181819, 0),
                    new Vector(-85.608968, 34.9901658181818, 0),
                    new Vector(-85.46738000000001, 34.9901298181819, 0),
                    new Vector(-85.35994700000001, 34.9899858181818, 0),
                    new Vector(-85.267715, 34.9891488181819, 0),
                    new Vector(-84.97279399999999, 34.9926228181819, 0),
                    new Vector(-84.96785300000001, 34.9926858181819, 0),
                    new Vector(-84.800417, 34.9928388181818, 0),
                    new Vector(-84.77114, 34.9907508181819, 0),
                    new Vector(-84.6186799999999, 34.9887618181818, 0),
                    new Vector(-84.32377700000001, 34.9890948181819, 0),
                    new Vector(-84.290963, 35.2106208181818, 0),
                    new Vector(-84.225866, 35.2616778181818, 0),
                    new Vector(-84.179642, 35.2410768181819, 0),
                    new Vector(-84.101567, 35.2456398181819, 0),
                    new Vector(-84.0426889999999, 35.2726578181818, 0),
                    new Vector(-84.030773, 35.2926108181818, 0),
                    new Vector(-84.029117, 35.3253708181819, 0),
                    new Vector(-84.006221, 35.3729448181819, 0),
                    new Vector(-84.012557, 35.4077118181819, 0),
                    new Vector(-83.954606, 35.4555468181819, 0)
                })
            }
        };
    }
}