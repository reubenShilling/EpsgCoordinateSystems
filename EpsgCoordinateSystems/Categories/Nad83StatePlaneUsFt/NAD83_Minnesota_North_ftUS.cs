using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_Minnesota_North_ftUS : INad83UsFtCrs
    {
        private const int _srid = 26849;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Minnesota North";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / Minnesota North (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",48.63333333333333],PARAMETER[\"standard_parallel_2\",47.03333333333333],PARAMETER[\"latitude_of_origin\",46.5],PARAMETER[\"central_meridian\",-93.1],PARAMETER[\"false_easting\",2624666.6667],PARAMETER[\"false_northing\",328083.3333],AUTHORITY[\"EPSG\",\"26849\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / Minnesota North (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",48.63333333333333],PARAMETER[\"standard_parallel_2\",47.03333333333333],PARAMETER[\"latitude_of_origin\",46.5],PARAMETER[\"central_meridian\",-93.1],PARAMETER[\"false_easting\",2624666.6667],PARAMETER[\"false_northing\",328083.3333],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(47.1518838181819, -96.83916799999999),
                    new Vector(47.15243281818191, -96.195722),
                    new Vector(47.1542688181819, -96.071648),
                    new Vector(47.1517758181819, -95.553788),
                    new Vector(47.15041681818191, -95.175104),
                    new Vector(47.3250978181819, -95.16886699999999),
                    new Vector(47.3263128181819, -95.184365),
                    new Vector(47.4137568181819, -95.18528299999998),
                    new Vector(47.4128748181818, -94.66851200000001),
                    new Vector(47.4132888181817, -94.417277),
                    new Vector(47.4340428181819, -94.416152),
                    new Vector(47.41798681818181, -94.30975399999991),
                    new Vector(47.47602781818191, -94.133651),
                    new Vector(47.4783678181819, -94.104986),
                    new Vector(47.4685578181819, -94.08149600000002),
                    new Vector(47.4192738181819, -94.040519),
                    new Vector(47.3760468181818, -94.03953799999989),
                    new Vector(47.348677818182, -94.018226),
                    new Vector(47.3320548181818, -93.963542),
                    new Vector(47.30570281818189, -93.93901700000001),
                    new Vector(47.2937688181818, -93.909452),
                    new Vector(47.3228748181818, -93.876638),
                    new Vector(47.3017248181819, -93.83243899999999),
                    new Vector(47.3009868181818, -93.78223699999999),
                    new Vector(47.25953281818191, -93.784199),
                    new Vector(47.24146981818191, -93.80306299999999),
                    new Vector(47.21835781818189, -93.792191),
                    new Vector(47.2096548181819, -93.77626100000001),
                    new Vector(47.0304018181818, -93.7752349999999),
                    new Vector(47.0223018181819, -93.058466),
                    new Vector(46.7660178181819, -93.059861),
                    new Vector(46.76429881818191, -92.30213300000001),
                    new Vector(46.6665768181819, -92.303141),
                    new Vector(46.6681968181819, -92.214626),
                    new Vector(46.79190181818189, -92.088491),
                    new Vector(46.9270818181818, -91.800977),
                    new Vector(47.1249378181819, -91.46865200000002),
                    new Vector(47.4610518181818, -91.021469),
                    new Vector(47.70993781818181, -90.50963899999989),
                    new Vector(47.8245618181818, -89.999681),
                    new Vector(47.9593908181818, -89.636369),
                    new Vector(47.99256481818181, -89.625641),
                    new Vector(48.00165481818179, -89.53067299999989),
                    new Vector(48.02648581818179, -89.74930999999999),
                    new Vector(47.9925108181819, -89.90039299999999),
                    new Vector(48.0235518181818, -89.98701800000001),
                    new Vector(48.0860838181818, -90.02669899999999),
                    new Vector(48.1127688181818, -90.145274),
                    new Vector(48.09275281818189, -90.55683500000001),
                    new Vector(48.1216968181818, -90.567455),
                    new Vector(48.0884418181818, -90.7433599999999),
                    new Vector(48.254203818182, -90.864491),
                    new Vector(48.1953348181819, -91.02714799999998),
                    new Vector(48.0812958181819, -91.23944899999991),
                    new Vector(48.0435768181819, -91.57156700000002),
                    new Vector(48.10445281818181, -91.568777),
                    new Vector(48.1148388181819, -91.703723),
                    new Vector(48.1967748181818, -91.71194),
                    new Vector(48.2061438181818, -91.78881799999999),
                    new Vector(48.25039681818191, -91.97953699999991),
                    new Vector(48.3555078181818, -92.035184),
                    new Vector(48.3667578181818, -92.125967),
                    new Vector(48.3523218181818, -92.27612299999991),
                    new Vector(48.2983128181818, -92.30027),
                    new Vector(48.2443488181819, -92.27691500000002),
                    new Vector(48.22077781818191, -92.37011899999999),
                    new Vector(48.35749681818191, -92.473322),
                    new Vector(48.4021728181818, -92.45634800000001),
                    new Vector(48.4400718181819, -92.497523),
                    new Vector(48.4603758181818, -92.706647),
                    new Vector(48.4947198181818, -92.69881700000001),
                    new Vector(48.5028288181819, -92.626385),
                    new Vector(48.5403498181818, -92.64182),
                    new Vector(48.54020581818181, -92.72900300000001),
                    new Vector(48.62835181818179, -92.946929),
                    new Vector(48.6265788181819, -93.091442),
                    new Vector(48.6371628181818, -93.30423799999988),
                    new Vector(48.5927118181819, -93.457769),
                    new Vector(48.5495208181819, -93.465338),
                    new Vector(48.5342748181819, -93.51413599999989),
                    new Vector(48.5115948181818, -93.78111199999998),
                    new Vector(48.5254098181819, -93.81268400000002),
                    new Vector(48.6247338181818, -93.84389599999999),
                    new Vector(48.6519948181819, -94.23082399999991),
                    new Vector(48.7077048181819, -94.29233899999988),
                    new Vector(48.7107828181819, -94.430633),
                    new Vector(48.7136718181818, -94.5703129999999),
                    new Vector(48.7776168181818, -94.69443200000001),
                    new Vector(48.87716581818191, -94.681256),
                    new Vector(49.3308108181819, -94.832033),
                    new Vector(49.3717248181819, -95.151866),
                    new Vector(48.9999978181818, -95.157752),
                    new Vector(48.99998881818169, -95.276651),
                    new Vector(48.9999798181819, -96.406916),
                    new Vector(48.99998881818169, -97.229435),
                    new Vector(48.9318228181818, -97.21637600000001),
                    new Vector(48.8737548181819, -97.175723),
                    new Vector(48.8359818181819, -97.17119599999998),
                    new Vector(48.8155338181818, -97.180421),
                    new Vector(48.81037681818179, -97.16470699999989),
                    new Vector(48.8015208181818, -97.17394099999999),
                    new Vector(48.7811718181819, -97.14751699999999),
                    new Vector(48.76354981818191, -97.139246),
                    new Vector(48.75565681818181, -97.147904),
                    new Vector(48.7472148181818, -97.13249600000002),
                    new Vector(48.7262358181819, -97.134809),
                    new Vector(48.7085778181819, -97.11010399999989),
                    new Vector(48.6952488181818, -97.116737),
                    new Vector(48.674530818182, -97.09717100000002),
                    new Vector(48.6299448181819, -97.107629),
                    new Vector(48.62979181818199, -97.127447),
                    new Vector(48.6207738181819, -97.122956),
                    new Vector(48.6140238181819, -97.144718),
                    new Vector(48.58690681818191, -97.140812),
                    new Vector(48.583639818182, -97.158191),
                    new Vector(48.57285781818189, -97.152125),
                    new Vector(48.56226481818189, -97.16794700000001),
                    new Vector(48.5495388181818, -97.14661700000001),
                    new Vector(48.54508381818179, -97.160432),
                    new Vector(48.5383968181819, -97.1555359999999),
                    new Vector(48.5346438181818, -97.139381),
                    new Vector(48.5179578181818, -97.14832700000001),
                    new Vector(48.51731881818189, -97.1345929999999),
                    new Vector(48.4381098181818, -97.14361100000001),
                    new Vector(48.4371018181819, -97.119635),
                    new Vector(48.4161048181819, -97.122596),
                    new Vector(48.41960581818179, -97.15164800000001),
                    new Vector(48.4099938181818, -97.14983000000001),
                    new Vector(48.40787881818191, -97.12913),
                    new Vector(48.3882048181818, -97.15882099999999),
                    new Vector(48.3844068181818, -97.135205),
                    new Vector(48.37245481818201, -97.13378299999998),
                    new Vector(48.3632208181819, -97.150397),
                    new Vector(48.3614928181819, -97.13112800000002),
                    new Vector(48.3259878181818, -97.13714),
                    new Vector(48.3199308181819, -97.112588),
                    new Vector(48.3109758181819, -97.13263999999999),
                    new Vector(48.3036138181819, -97.11475700000001),
                    new Vector(48.29488381818189, -97.1137219999999),
                    new Vector(48.2930388181817, -97.130516),
                    new Vector(48.2861448181819, -97.11267800000002),
                    new Vector(48.2778738181818, -97.111715),
                    new Vector(48.2644818181819, -97.13665400000001),
                    new Vector(48.2591718181818, -97.123784),
                    new Vector(48.2335308181819, -97.127555),
                    new Vector(48.2280498181819, -97.10924),
                    new Vector(48.2217588181819, -97.139759),
                    new Vector(48.2076108181819, -97.110896),
                    new Vector(48.2037498181818, -97.130831),
                    new Vector(48.1950648181819, -97.137275),
                    new Vector(48.1752288181819, -97.13629400000001),
                    new Vector(48.16777681818189, -97.13744600000001),
                    new Vector(48.1592268181818, -97.11606199999999),
                    new Vector(48.1483998181818, -97.13651),
                    new Vector(48.14277481818169, -97.12092199999999),
                    new Vector(48.1163688181819, -97.121876),
                    new Vector(48.10096981818191, -97.0990249999999),
                    new Vector(48.0703428181818, -97.09271599999998),
                    new Vector(48.04816681818191, -97.067075),
                    new Vector(47.9549268181819, -97.048058),
                    new Vector(47.9178918181818, -97.015325),
                    new Vector(47.8755738181818, -97.02056299999988),
                    new Vector(47.8702008181819, -97.00033999999999),
                    new Vector(47.8280268181819, -96.97722800000001),
                    new Vector(47.8096668181819, -96.98388799999999),
                    new Vector(47.7944388181819, -96.957824),
                    new Vector(47.7635058181818, -96.932012),
                    new Vector(47.7140868181819, -96.92366),
                    new Vector(47.6739288181819, -96.88942399999999),
                    new Vector(47.6152578181819, -96.87333200000002),
                    new Vector(47.6011548181818, -96.85221799999989),
                    new Vector(47.56298581818191, -96.8586619999999),
                    new Vector(47.54457181818191, -96.84919399999998),
                    new Vector(47.5213518181818, -96.860687),
                    new Vector(47.5006158181819, -96.85161500000001),
                    new Vector(47.4615378181819, -96.86668100000001),
                    new Vector(47.4367518181819, -96.85582700000001),
                    new Vector(47.41309081818189, -96.867248),
                    new Vector(47.4089328181819, -96.850013),
                    new Vector(47.38411981818179, -96.83982499999999),
                    new Vector(47.3609538181819, -96.85062499999998),
                    new Vector(47.34224281818189, -96.8384659999999),
                    new Vector(47.31460381818189, -96.846746),
                    new Vector(47.2938858181819, -96.83771899999988),
                    new Vector(47.256841818182, -96.849626),
                    new Vector(47.2404618181819, -96.837062),
                    new Vector(47.17006381818171, -96.826487),
                    new Vector(47.1518838181819, -96.83916799999999)
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