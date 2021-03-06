using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_West_Virginia_South_ftUS : INad83UsFtCrs
    {
        private const int _srid = 26854;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "West Virginia South";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / West Virginia South (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",38.88333333333333],PARAMETER[\"standard_parallel_2\",37.48333333333333],PARAMETER[\"latitude_of_origin\",37],PARAMETER[\"central_meridian\",-81],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"26854\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / West Virginia South (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",38.88333333333333],PARAMETER[\"standard_parallel_2\",37.48333333333333],PARAMETER[\"latitude_of_origin\",37],PARAMETER[\"central_meridian\",-81],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(37.9556478181819, -80.054807),
                    new Vector(37.9898748181818, -80.000501),
                    new Vector(38.0386188181819, -79.96648999999999),
                    new Vector(38.0673648181818, -79.957517),
                    new Vector(38.1033108181819, -79.92829399999999),
                    new Vector(38.1213108181819, -79.935323),
                    new Vector(38.1626118181817, -79.91033899999999),
                    new Vector(38.1792618181818, -79.916162),
                    new Vector(38.2502808181818, -79.831157),
                    new Vector(38.2686678181819, -79.7936179999999),
                    new Vector(38.2851198181819, -79.786508),
                    new Vector(38.2988718181818, -79.8027799999999),
                    new Vector(38.3143248181819, -79.80032300000001),
                    new Vector(38.3539878181818, -79.763999),
                    new Vector(38.3518368181819, -79.732823),
                    new Vector(38.3946858181818, -79.7200339999999),
                    new Vector(38.4302358181819, -79.684088),
                    new Vector(38.5003548181818, -79.692656),
                    new Vector(38.5207848181818, -79.66562),
                    new Vector(38.5501788181819, -79.6694269999999),
                    new Vector(38.5923528181819, -79.642409),
                    new Vector(38.5538058181818, -79.53651499999999),
                    new Vector(38.4621498181819, -79.486349),
                    new Vector(38.4126408181818, -79.316996),
                    new Vector(38.4373098181819, -79.27236499999999),
                    new Vector(38.4805008181818, -79.231667),
                    new Vector(38.6582418181819, -79.12742900000001),
                    new Vector(38.663767818182, -79.121066),
                    new Vector(38.6592048181819, -79.088549),
                    new Vector(38.7072738181818, -79.08723500000001),
                    new Vector(38.7620568181819, -79.05655400000001),
                    new Vector(38.8082808181818, -79.1278159999999),
                    new Vector(38.8821168181819, -79.231748),
                    new Vector(38.9488518181818, -79.3505119999999),
                    new Vector(38.9688588181818, -79.34687599999999),
                    new Vector(38.9598948181817, -79.370321),
                    new Vector(38.9697048181818, -79.4102359999999),
                    new Vector(38.9676258181819, -79.456343),
                    new Vector(38.9775258181818, -79.489175),
                    new Vector(38.9716488181819, -79.51683199999999),
                    new Vector(39.0363678181818, -79.78468100000001),
                    new Vector(39.0655818181819, -79.773737),
                    new Vector(39.084067818182, -79.779668),
                    new Vector(39.1063068181819, -79.80230299999999),
                    new Vector(39.1148028181819, -79.83340699999999),
                    new Vector(39.1052808181819, -79.83311),
                    new Vector(39.0885228181818, -79.856285),
                    new Vector(39.0623868181818, -79.871441),
                    new Vector(38.972080818182, -79.8992779999999),
                    new Vector(38.9491578181819, -80.070764),
                    new Vector(38.9844738181819, -80.05127899999999),
                    new Vector(39.0314268181819, -80.06063899999999),
                    new Vector(39.0372228181818, -80.130173),
                    new Vector(39.0817728181818, -80.167361),
                    new Vector(39.0939408181819, -80.212892),
                    new Vector(39.1107798181818, -80.230721),
                    new Vector(39.0972618181819, -80.247398),
                    new Vector(39.0996918181819, -80.30088499999999),
                    new Vector(39.1300038181819, -80.460482),
                    new Vector(39.1431798181819, -80.478239),
                    new Vector(39.1411098181819, -80.52622700000001),
                    new Vector(39.1631058181817, -80.57226199999999),
                    new Vector(39.1631148181818, -80.590082),
                    new Vector(39.1416048181818, -80.634272),
                    new Vector(39.1396878181818, -80.656142),
                    new Vector(39.1200678181818, -80.679029),
                    new Vector(39.1008438181818, -80.685896),
                    new Vector(39.0907008181819, -80.7097729999999),
                    new Vector(39.0937248181818, -80.733047),
                    new Vector(39.1096458181819, -80.817413),
                    new Vector(39.0780558181819, -80.862224),
                    new Vector(39.0726378181818, -80.894597),
                    new Vector(39.0438378181819, -80.919329),
                    new Vector(39.0369528181819, -80.9711599999999),
                    new Vector(39.0089448181819, -81.031451),
                    new Vector(39.0153978181818, -81.05963),
                    new Vector(39.0113748181819, -81.073643),
                    new Vector(39.0240468181818, -81.10567399999999),
                    new Vector(39.0486798181819, -81.116393),
                    new Vector(39.0381858181819, -81.165074),
                    new Vector(38.9376648181819, -81.2801929999999),
                    new Vector(38.9181528181818, -81.280355),
                    new Vector(38.9005218181819, -81.35222),
                    new Vector(38.9472948181819, -81.45122000000001),
                    new Vector(38.9369088181818, -81.4920979999999),
                    new Vector(38.9215098181819, -81.50546300000001),
                    new Vector(38.9429658181819, -81.515525),
                    new Vector(38.9537118181819, -81.533894),
                    new Vector(38.9730798181818, -81.537926),
                    new Vector(38.9857068181819, -81.526172),
                    new Vector(39.0080628181819, -81.536306),
                    new Vector(39.0299778181819, -81.587327),
                    new Vector(39.0947148181818, -81.75356600000001),
                    new Vector(39.0772548181819, -81.7863619999999),
                    new Vector(39.0770208181819, -81.819563),
                    new Vector(39.0664188181818, -81.82427),
                    new Vector(39.0441078181818, -81.813461),
                    new Vector(39.0168288181818, -81.7756789999999),
                    new Vector(38.9685258181818, -81.781727),
                    new Vector(38.9301858181819, -81.76229600000001),
                    new Vector(38.9235618181818, -81.78323),
                    new Vector(38.9484648181819, -81.823775),
                    new Vector(38.9378898181818, -81.84091100000001),
                    new Vector(38.8857078181819, -81.866804),
                    new Vector(38.8734588181818, -81.89268800000001),
                    new Vector(38.8844478181819, -81.91524200000001),
                    new Vector(38.8947438181818, -81.931856),
                    new Vector(38.9322288181818, -81.89861000000001),
                    new Vector(38.9842758181818, -81.927824),
                    new Vector(38.9911698181818, -81.93773299999999),
                    new Vector(38.9930058181819, -81.9751909999999),
                    new Vector(39.0152628181819, -81.99968),
                    new Vector(39.0141378181819, -82.04288),
                    new Vector(38.9890638181819, -82.058504),
                    new Vector(38.9772018181818, -82.08501800000001),
                    new Vector(38.9520918181818, -82.1012089999999),
                    new Vector(38.8993968181819, -82.139315),
                    new Vector(38.8387908181818, -82.146101),
                    new Vector(38.804617818182, -82.197716),
                    new Vector(38.7789408181819, -82.216751),
                    new Vector(38.7102978181817, -82.18397299999999),
                    new Vector(38.6778888181818, -82.188986),
                    new Vector(38.6321868181819, -82.173659),
                    new Vector(38.5950348181819, -82.184243),
                    new Vector(38.5848378181818, -82.21366399999989),
                    new Vector(38.5948908181819, -82.270904),
                    new Vector(38.5800858181819, -82.289975),
                    new Vector(38.4652278181819, -82.31424800000001),
                    new Vector(38.4419538181819, -82.329179),
                    new Vector(38.4284718181819, -82.394762),
                    new Vector(38.4303888181819, -82.414895),
                    new Vector(38.4058368181818, -82.494995),
                    new Vector(38.4005088181818, -82.547546),
                    new Vector(38.4039018181819, -82.575419),
                    new Vector(38.4125148181819, -82.5865969999999),
                    new Vector(38.3684598181818, -82.59823400000001),
                    new Vector(38.3078088181819, -82.57229599999999),
                    new Vector(38.2925088181818, -82.5800449999999),
                    new Vector(38.2559688181818, -82.57458200000001),
                    new Vector(38.2453938181819, -82.589108),
                    new Vector(38.238805818182, -82.616225),
                    new Vector(38.193823818182, -82.606649),
                    new Vector(38.1780918181818, -82.61376799999999),
                    new Vector(38.1694338181819, -82.647158),
                    new Vector(38.1463308181819, -82.646123),
                    new Vector(38.1099618181818, -82.59321199999989),
                    new Vector(38.0156598181819, -82.524686),
                    new Vector(37.9759068181818, -82.47578),
                    new Vector(37.9543968181818, -82.4801719999999),
                    new Vector(37.9425078181819, -82.493402),
                    new Vector(37.9222668181819, -82.50020600000001),
                    new Vector(37.8948528181818, -82.437611),
                    new Vector(37.8723528181818, -82.42151),
                    new Vector(37.8117198181818, -82.405805),
                    new Vector(37.7843958181817, -82.339844),
                    new Vector(37.7584308181819, -82.3195039999999),
                    new Vector(37.7441748181819, -82.329404),
                    new Vector(37.6690518181818, -82.2956269999999),
                    new Vector(37.6567758181818, -82.23836900000001),
                    new Vector(37.6240158181818, -82.205438),
                    new Vector(37.6406658181818, -82.1855479999999),
                    new Vector(37.5935688181818, -82.1593129999999),
                    new Vector(37.5905358181819, -82.131782),
                    new Vector(37.5698988181818, -82.13746999999999),
                    new Vector(37.5659208181818, -82.14651499999999),
                    new Vector(37.5574518181818, -82.14251),
                    new Vector(37.5483078181818, -82.084388),
                    new Vector(37.5253488181818, -82.05566),
                    new Vector(37.5514578181819, -82.04913500000001),
                    new Vector(37.5305148181819, -82.02635600000001),
                    new Vector(37.5432588181819, -81.97657700000001),
                    new Vector(37.5311718181819, -81.959576),
                    new Vector(37.5066468181818, -81.935456),
                    new Vector(37.4930298181819, -81.9479929999999),
                    new Vector(37.4829048181819, -81.976415),
                    new Vector(37.4665788181817, -81.988196),
                    new Vector(37.4155218181818, -81.920732),
                    new Vector(37.3717278181819, -81.926816),
                    new Vector(37.3405878181817, -81.89715200000001),
                    new Vector(37.3254588181818, -81.863816),
                    new Vector(37.3070268181819, -81.85868600000001),
                    new Vector(37.2855078181818, -81.83889499999999),
                    new Vector(37.2795408181818, -81.8153779999999),
                    new Vector(37.2871548181819, -81.79266200000001),
                    new Vector(37.2722508181819, -81.751856),
                    new Vector(37.2504888181818, -81.738455),
                    new Vector(37.2354408181819, -81.70172599999999),
                    new Vector(37.2049128181818, -81.665879),
                    new Vector(37.2063528181818, -81.55665500000001),
                    new Vector(37.2343698181818, -81.50553499999999),
                    new Vector(37.2528558181819, -81.495536),
                    new Vector(37.2544218181818, -81.47536700000001),
                    new Vector(37.2826278181819, -81.40334900000001),
                    new Vector(37.3111578181819, -81.390947),
                    new Vector(37.3389588181818, -81.35879),
                    new Vector(37.2937068181819, -81.31187300000001),
                    new Vector(37.2402198181819, -81.22293500000001),
                    new Vector(37.2749238181819, -81.140738),
                    new Vector(37.2860658181818, -81.024935),
                    new Vector(37.3062438181819, -80.985938),
                    new Vector(37.2964698181818, -80.97854),
                    new Vector(37.2917898181819, -80.967893),
                    new Vector(37.3013748181818, -80.934179),
                    new Vector(37.3394088181819, -80.855429),
                    new Vector(37.3509468181818, -80.8484179999999),
                    new Vector(37.3887018181819, -80.877353),
                    new Vector(37.4234598181819, -80.85052399999999),
                    new Vector(37.4130648181819, -80.799611),
                    new Vector(37.3917528181819, -80.79924200000001),
                    new Vector(37.3861908181818, -80.770019),
                    new Vector(37.3714218181819, -80.76299),
                    new Vector(37.3790808181819, -80.74769000000001),
                    new Vector(37.3877388181818, -80.7463309999999),
                    new Vector(37.3927158181818, -80.72973500000001),
                    new Vector(37.3883778181819, -80.70520999999999),
                    new Vector(37.4460588181819, -80.5974889999999),
                    new Vector(37.4692068181818, -80.542751),
                    new Vector(37.4750478181819, -80.50876700000001),
                    new Vector(37.4606028181818, -80.48787799999999),
                    new Vector(37.4338638181819, -80.48679799999999),
                    new Vector(37.4228208181819, -80.474765),
                    new Vector(37.434907818182, -80.425382),
                    new Vector(37.4657238181819, -80.388311),
                    new Vector(37.4761008181818, -80.352158),
                    new Vector(37.4911848181818, -80.3475049999999),
                    new Vector(37.5111558181818, -80.2879159999999),
                    new Vector(37.5362658181818, -80.280725),
                    new Vector(37.5283728181819, -80.308301),
                    new Vector(37.5334038181818, -80.32590500000001),
                    new Vector(37.5667218181818, -80.316716),
                    new Vector(37.5968988181818, -80.24639000000001),
                    new Vector(37.6242678181819, -80.2189309999999),
                    new Vector(37.6407018181818, -80.254418),
                    new Vector(37.6405488181819, -80.300939),
                    new Vector(37.6522488181819, -80.304863),
                    new Vector(37.6714998181819, -80.29570099999999),
                    new Vector(37.6826688181819, -80.3031079999999),
                    new Vector(37.7260578181819, -80.250035),
                    new Vector(37.7572338181818, -80.254688),
                    new Vector(37.7788518181819, -80.22054199999999),
                    new Vector(37.8023598181819, -80.223737),
                    new Vector(37.8429768181818, -80.17159100000001),
                    new Vector(37.8601848181818, -80.17222099999999),
                    new Vector(37.8772308181818, -80.160008),
                    new Vector(37.8912798181818, -80.118509),
                    new Vector(37.9146528181819, -80.1064939999999),
                    new Vector(37.9556478181819, -80.054807)
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