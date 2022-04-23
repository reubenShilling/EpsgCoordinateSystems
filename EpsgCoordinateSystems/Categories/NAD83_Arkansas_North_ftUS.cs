using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Arkansas_North_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 3433;

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Arkansas North";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Arkansas North (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,36.23333333333333],PARAMETER[standard_parallel_2,34.93333333333333],PARAMETER[latitude_of_origin,34.33333333333334],PARAMETER[central_meridian,-92],PARAMETER[false_easting,1312333.3333],PARAMETER[false_northing,0],AUTHORITY[EPSG,3433],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Arkansas North (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,36.23333333333333],PARAMETER[standard_parallel_2,34.93333333333333],PARAMETER[latitude_of_origin,34.33333333333334],PARAMETER[central_meridian,-92],PARAMETER[false_easting,1312333.3333],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public Geometry Wgs84Boundary => new LinearRing
        {
            Coordinates = new CoordinateCollection(new[]
            {
                new Vector(-94.439318, 34.9291548181818, 0),
                new Vector(-94.44596, 34.7356098181818, 0),
                new Vector(-94.31054600000002, 34.7285268181818, 0),
                new Vector(-94.31287699999999, 34.7029668181819, 0),
                new Vector(-94.02809900000001, 34.6957038181819, 0),
                new Vector(-94.025516, 34.6898808181818, 0),
                new Vector(-93.92355499999999, 34.6878738181819, 0),
                new Vector(-93.924734, 34.6791888181818, 0),
                new Vector(-93.871544, 34.6784598181819, 0),
                new Vector(-93.87108499999999, 34.6998528181818, 0),
                new Vector(-93.86094199999999, 34.6988628181818, 0),
                new Vector(-93.86292199999998, 34.7137938181819, 0),
                new Vector(-93.810281, 34.7134698181819, 0),
                new Vector(-93.80830099999999, 34.7280948181819, 0),
                new Vector(-93.77081599999988, 34.7285628181818, 0),
                new Vector(-93.770483, 34.7426658181819, 0),
                new Vector(-93.736751, 34.7402538181819, 0),
                new Vector(-93.73874899999988, 34.7560938181819, 0),
                new Vector(-93.703919, 34.7541768181819, 0),
                new Vector(-93.386813, 34.7505858181819, 0),
                new Vector(-93.385436, 34.7788098181819, 0),
                new Vector(-93.28340300000002, 34.7767038181818, 0),
                new Vector(-93.075017, 34.7755158181818, 0),
                new Vector(-93.072317, 34.8624018181819, 0),
                new Vector(-92.82270200000001, 34.8588468181819, 0),
                new Vector(-92.779223, 34.838254818182, 0),
                new Vector(-92.740262, 34.8311628181819, 0),
                new Vector(-92.74121599999989, 34.8538518181818, 0),
                new Vector(-92.75245699999988, 34.8544458181819, 0),
                new Vector(-92.752556, 34.9098858181819, 0),
                new Vector(-92.64995600000002, 34.9108668181819, 0),
                new Vector(-92.64778700000001, 34.9404498181818, 0),
                new Vector(-92.544377, 34.9359048181818, 0),
                new Vector(-92.540741, 34.9578108181819, 0),
                new Vector(-92.47657100000002, 34.9526448181819, 0),
                new Vector(-92.461127, 34.9448508181818, 0),
                new Vector(-92.446871, 34.9097778181819, 0),
                new Vector(-92.45096599999989, 34.8701508181819, 0),
                new Vector(-92.4399769999999, 34.8613488181818, 0),
                new Vector(-92.426198, 34.9116678181817, 0),
                new Vector(-92.412536, 34.9210818181819, 0),
                new Vector(-92.410223, 34.9343208181818, 0),
                new Vector(-92.23051099999989, 34.9286418181818, 0),
                new Vector(-92.22604699999998, 35.0241408181818, 0),
                new Vector(-92.12038699999998, 35.0224578181819, 0),
                new Vector(-92.11876700000001, 35.0733618181819, 0),
                new Vector(-92.0933239999999, 35.0689248181818, 0),
                new Vector(-92.065442, 35.0754498181818, 0),
                new Vector(-92.013125, 35.0738568181819, 0),
                new Vector(-91.9504759999999, 35.0474688181818, 0),
                new Vector(-91.91787799999999, 35.0472348181818, 0),
                new Vector(-91.8695479999999, 35.0282358181819, 0),
                new Vector(-91.798106, 35.0432838181819, 0),
                new Vector(-91.71123799999988, 35.0690148181818, 0),
                new Vector(-91.64958800000001, 35.0547138181819, 0),
                new Vector(-91.62586399999989, 35.0297208181818, 0),
                new Vector(-91.586651, 35.0335998181818, 0),
                new Vector(-91.580522, 35.0350758181819, 0),
                new Vector(-91.579874, 35.0941158181819, 0),
                new Vector(-91.463009, 35.0956818181818, 0),
                new Vector(-91.44005900000001, 35.0769798181818, 0),
                new Vector(-91.44603499999999, 35.0691678181818, 0),
                new Vector(-91.475825, 35.0695818181818, 0),
                new Vector(-91.465007, 35.0643078181819, 0),
                new Vector(-91.355846, 35.0569998181819, 0),
                new Vector(-91.36079599999999, 34.9134138181818, 0),
                new Vector(-91.28567299999999, 34.9136838181819, 0),
                new Vector(-91.285574, 34.9817958181819, 0),
                new Vector(-91.24178000000001, 34.9810938181819, 0),
                new Vector(-91.23845900000001, 35.0074818181819, 0),
                new Vector(-91.14749600000002, 35.006977818182, 0),
                new Vector(-91.146101, 34.9152678181819, 0),
                new Vector(-91.120289, 34.9147188181819, 0),
                new Vector(-91.11939800000002, 34.8724908181819, 0),
                new Vector(-91.09696999999991, 34.8718878181817, 0),
                new Vector(-91.093919, 34.9137198181819, 0),
                new Vector(-90.40478, 34.9051608181818, 0),
                new Vector(-90.40402400000002, 34.8411348181819, 0),
                new Vector(-90.34151900000001, 34.8606738181819, 0),
                new Vector(-90.32291600000001, 34.8503598181819, 0),
                new Vector(-90.301649, 34.8518718181819, 0),
                new Vector(-90.299543, 34.8650568181818, 0),
                new Vector(-90.296375, 34.8827868181818, 0),
                new Vector(-90.26680099999999, 34.8966108181819, 0),
                new Vector(-90.24293299999998, 34.9208298181819, 0),
                new Vector(-90.24198800000001, 34.9390008181818, 0),
                new Vector(-90.248261, 34.949854818182, 0),
                new Vector(-90.29959699999999, 34.9785738181819, 0),
                new Vector(-90.305447, 35.0007948181818, 0),
                new Vector(-90.291911, 35.0485578181818, 0),
                new Vector(-90.19580000000001, 35.0409888181817, 0),
                new Vector(-90.169169, 35.077915818182, 0),
                new Vector(-90.1784389999999, 35.1087408181818, 0),
                new Vector(-90.16456100000001, 35.1297018181818, 0),
                new Vector(-90.14382499999989, 35.1366228181819, 0),
                new Vector(-90.083021, 35.1251388181819, 0),
                new Vector(-90.06462500000001, 35.1474768181819, 0),
                new Vector(-90.06252800000001, 35.1670068181818, 0),
                new Vector(-90.073391, 35.1919188181818, 0),
                new Vector(-90.069053, 35.2128258181818, 0),
                new Vector(-90.0901939999999, 35.2544778181818, 0),
                new Vector(-90.10603399999999, 35.2639368181818, 0),
                new Vector(-90.15222199999999, 35.2641438181819, 0),
                new Vector(-90.16983500000001, 35.2826568181819, 0),
                new Vector(-90.157082, 35.3063268181817, 0),
                new Vector(-90.10643899999998, 35.314768818182, 0),
                new Vector(-90.098789, 35.345683818182, 0),
                new Vector(-90.10571, 35.3660598181819, 0),
                new Vector(-90.08722399999999, 35.3815938181818, 0),
                new Vector(-90.07555999999991, 35.4066048181818, 0),
                new Vector(-90.08525299999999, 35.4183678181818, 0),
                new Vector(-90.11233400000002, 35.4177738181818, 0),
                new Vector(-90.132566, 35.4076848181818, 0),
                new Vector(-90.140261, 35.383123818182, 0),
                new Vector(-90.16790899999998, 35.3843388181819, 0),
                new Vector(-90.172769, 35.4238038181818, 0),
                new Vector(-90.13736299999999, 35.4426048181818, 0),
                new Vector(-90.102056, 35.4736548181818, 0),
                new Vector(-90.0823189999999, 35.4782898181818, 0),
                new Vector(-90.074939, 35.4724308181817, 0),
                new Vector(-90.07402999999989, 35.4265938181819, 0),
                new Vector(-90.06038599999999, 35.4134898181818, 0),
                new Vector(-90.04687699999991, 35.4171888181818, 0),
                new Vector(-89.99965400000001, 35.4455388181819, 0),
                new Vector(-90.041909, 35.5125168181818, 0),
                new Vector(-90.04099100000001, 35.5429278181819, 0),
                new Vector(-90.03313400000002, 35.5524948181819, 0),
                new Vector(-89.989673, 35.5617558181818, 0),
                new Vector(-89.962367, 35.5323708181818, 0),
                new Vector(-89.94763399999999, 35.5269798181818, 0),
                new Vector(-89.931263, 35.5293108181818, 0),
                new Vector(-89.921741, 35.5461408181818, 0),
                new Vector(-89.958119, 35.5786758181819, 0),
                new Vector(-89.957138, 35.6031828181819, 0),
                new Vector(-89.87752399999989, 35.6334138181819, 0),
                new Vector(-89.863916, 35.6298228181818, 0),
                new Vector(-89.849282, 35.6453028181818, 0),
                new Vector(-89.8573279999999, 35.6711418181819, 0),
                new Vector(-89.86526600000001, 35.6733828181819, 0),
                new Vector(-89.89349, 35.6560578181818, 0),
                new Vector(-89.929823, 35.6763438181817, 0),
                new Vector(-89.952116, 35.7125598181819, 0),
                new Vector(-89.9511169999999, 35.734348818182, 0),
                new Vector(-89.90986100000001, 35.7549138181819, 0),
                new Vector(-89.859956, 35.7482718181818, 0),
                new Vector(-89.827124, 35.7583428181818, 0),
                new Vector(-89.79998000000001, 35.7742998181819, 0),
                new Vector(-89.79046700000001, 35.8056288181818, 0),
                new Vector(-89.75987600000001, 35.8174998181819, 0),
                new Vector(-89.736017, 35.807113818182, 0),
                new Vector(-89.700908, 35.8275888181819, 0),
                new Vector(-89.70152, 35.8421058181819, 0),
                new Vector(-89.75778800000001, 35.8714908181819, 0),
                new Vector(-89.766356, 35.8841808181819, 0),
                new Vector(-89.76299, 35.8968888181819, 0),
                new Vector(-89.738051, 35.9150868181818, 0),
                new Vector(-89.71476800000001, 35.9114958181819, 0),
                new Vector(-89.6647279999999, 35.8857198181819, 0),
                new Vector(-89.64941899999999, 35.894359818182, 0),
                new Vector(-89.64548600000001, 35.9138718181819, 0),
                new Vector(-89.664269, 35.9378928181818, 0),
                new Vector(-89.71321999999989, 35.9663958181819, 0),
                new Vector(-89.721833, 35.9999568181819, 0),
                new Vector(-89.963294, 35.9969058181819, 0),
                new Vector(-90.28355899999991, 35.9912268181818, 0),
                new Vector(-90.37906700000001, 35.9896518181819, 0),
                new Vector(-90.3153379999999, 36.0917298181818, 0),
                new Vector(-90.28485499999991, 36.1159758181819, 0),
                new Vector(-90.26380400000001, 36.1188288181819, 0),
                new Vector(-90.23493200000001, 36.1371528181819, 0),
                new Vector(-90.23232200000001, 36.1612098181818, 0),
                new Vector(-90.219317, 36.1726308181817, 0),
                new Vector(-90.16141100000002, 36.1970118181818, 0),
                new Vector(-90.131315, 36.2121408181818, 0),
                new Vector(-90.1100119999999, 36.2580678181818, 0),
                new Vector(-90.066191, 36.2723328181819, 0),
                new Vector(-90.049847, 36.3005388181819, 0),
                new Vector(-90.06772999999988, 36.3253878181818, 0),
                new Vector(-90.05028799999999, 36.3626748181817, 0),
                new Vector(-90.05215099999991, 36.3826188181819, 0),
                new Vector(-90.080276, 36.3974508181818, 0),
                new Vector(-90.1169239999999, 36.4049748181819, 0),
                new Vector(-90.12392599999991, 36.4226238181818, 0),
                new Vector(-90.11732000000001, 36.453952818182, 0),
                new Vector(-90.137372, 36.4574718181818, 0),
                new Vector(-90.15025999999999, 36.4918698181818, 0),
                new Vector(-90.224474, 36.4928058181818, 0),
                new Vector(-90.581738, 36.491014818182, 0),
                new Vector(-90.80443400000001, 36.4892598181819, 0),
                new Vector(-91.133951, 36.4880178181818, 0),
                new Vector(-91.41179899999999, 36.4910958181819, 0),
                new Vector(-91.45299200000001, 36.4904388181819, 0),
                new Vector(-91.68856699999999, 36.491014818182, 0),
                new Vector(-92.1276409999999, 36.4914378181818, 0),
                new Vector(-92.146316, 36.4916628181819, 0),
                new Vector(-92.5230559999999, 36.4909158181819, 0),
                new Vector(-92.77763899999999, 36.489979818182, 0),
                new Vector(-92.85227599999999, 36.4898808181819, 0),
                new Vector(-93.29732599999988, 36.4906818181819, 0),
                new Vector(-93.328349, 36.4902678181818, 0),
                new Vector(-93.5964409999999, 36.4899528181818, 0),
                new Vector(-93.85752199999999, 36.4897818181819, 0),
                new Vector(-94.08105500000001, 36.4910238181818, 0),
                new Vector(-94.6172569999999, 36.4894218181819, 0),
                new Vector(-94.607456, 36.4787928181818, 0),
                new Vector(-94.553105, 36.1645308181818, 0),
                new Vector(-94.542422, 36.1068408181819, 0),
                new Vector(-94.485938, 35.7603048181817, 0),
                new Vector(-94.46847799999999, 35.6410908181819, 0),
                new Vector(-94.42855400000001, 35.4005478181819, 0),
                new Vector(-94.439318, 34.9291548181818, 0)
            })
        };
    }
}