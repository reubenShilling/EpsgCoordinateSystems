using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_Ohio_South_ftUS : INad83UsFtCrs
    {
        private const int _srid = 3735;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Ohio South";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / Ohio South (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",40.03333333333333],PARAMETER[\"standard_parallel_2\",38.73333333333333],PARAMETER[\"latitude_of_origin\",38],PARAMETER[\"central_meridian\",-82.5],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"3735\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / Ohio South (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",40.03333333333333],PARAMETER[\"standard_parallel_2\",38.73333333333333],PARAMETER[\"latitude_of_origin\",38],PARAMETER[\"central_meridian\",-82.5],PARAMETER[\"false_easting\",1968500],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(39.0941928181818, -84.515297),
                    new Vector(39.1073598181818, -84.492059),
                    new Vector(39.1118238181818, -84.444917),
                    new Vector(39.0847248181818, -84.425684),
                    new Vector(39.0473388181818, -84.419735),
                    new Vector(39.0357468181819, -84.3913129999999),
                    new Vector(39.0378078181819, -84.345782),
                    new Vector(39.0140748181818, -84.31331899999989),
                    new Vector(38.9445408181818, -84.29013500000001),
                    new Vector(38.9174778181819, -84.26152399999999),
                    new Vector(38.8745568181819, -84.23528899999999),
                    new Vector(38.8126908181818, -84.228701),
                    new Vector(38.7884988181819, -84.17675300000001),
                    new Vector(38.7655038181818, -84.08886800000001),
                    new Vector(38.7637398181819, -84.053804),
                    new Vector(38.7776448181818, -83.962166),
                    new Vector(38.7579618181818, -83.91254000000001),
                    new Vector(38.7449208181819, -83.85755899999999),
                    new Vector(38.7118818181819, -83.83753400000001),
                    new Vector(38.6938458181819, -83.790464),
                    new Vector(38.6508168181819, -83.770223),
                    new Vector(38.6355528181819, -83.7128299999999),
                    new Vector(38.6209278181819, -83.67853100000001),
                    new Vector(38.6238798181819, -83.65575200000001),
                    new Vector(38.6358678181819, -83.64318799999999),
                    new Vector(38.6649738181819, -83.63324299999999),
                    new Vector(38.677969818182, -83.61838400000001),
                    new Vector(38.6961048181819, -83.526557),
                    new Vector(38.6901378181819, -83.50006999999999),
                    new Vector(38.6637768181818, -83.453621),
                    new Vector(38.6550018181819, -83.371415),
                    new Vector(38.6319888181819, -83.3300239999999),
                    new Vector(38.6065638181819, -83.320331),
                    new Vector(38.5963218181818, -83.30652499999999),
                    new Vector(38.5966368181818, -83.290046),
                    new Vector(38.6092548181819, -83.2727569999999),
                    new Vector(38.6241768181819, -83.24500999999989),
                    new Vector(38.6098488181818, -83.181938),
                    new Vector(38.6193348181819, -83.143157),
                    new Vector(38.6648388181819, -83.111243),
                    new Vector(38.6857278181819, -83.060879),
                    new Vector(38.7145098181819, -83.026949),
                    new Vector(38.7196488181818, -82.972481),
                    new Vector(38.7464148181819, -82.92129799999999),
                    new Vector(38.742769818182, -82.890311),
                    new Vector(38.7190098181819, -82.873193),
                    new Vector(38.6832978181819, -82.8800059999999),
                    new Vector(38.6523918181818, -82.860026),
                    new Vector(38.6004528181819, -82.853852),
                    new Vector(38.571661818182, -82.826987),
                    new Vector(38.5572888181819, -82.802363),
                    new Vector(38.5530678181818, -82.7419459999999),
                    new Vector(38.5391448181818, -82.695578),
                    new Vector(38.5021368181818, -82.6697659999999),
                    new Vector(38.4726708181818, -82.613741),
                    new Vector(38.4125148181819, -82.5865969999999),
                    new Vector(38.4039018181819, -82.575419),
                    new Vector(38.4005088181818, -82.547546),
                    new Vector(38.4058368181818, -82.494995),
                    new Vector(38.4303888181819, -82.414895),
                    new Vector(38.4284718181819, -82.394762),
                    new Vector(38.4419538181819, -82.329179),
                    new Vector(38.4652278181819, -82.31424800000001),
                    new Vector(38.5800858181819, -82.289975),
                    new Vector(38.5948908181819, -82.270904),
                    new Vector(38.5848378181818, -82.21366399999989),
                    new Vector(38.5950348181819, -82.184243),
                    new Vector(38.6321868181819, -82.173659),
                    new Vector(38.6778888181818, -82.188986),
                    new Vector(38.7102978181817, -82.18397299999999),
                    new Vector(38.7789408181819, -82.216751),
                    new Vector(38.804617818182, -82.197716),
                    new Vector(38.8387908181818, -82.146101),
                    new Vector(38.8993968181819, -82.139315),
                    new Vector(38.9520918181818, -82.1012089999999),
                    new Vector(38.9772018181818, -82.08501800000001),
                    new Vector(38.9890638181819, -82.058504),
                    new Vector(39.0141378181819, -82.04288),
                    new Vector(39.0152628181819, -81.99968),
                    new Vector(38.9930058181819, -81.9751909999999),
                    new Vector(38.9911698181818, -81.93773299999999),
                    new Vector(38.9842758181818, -81.927824),
                    new Vector(38.9322288181818, -81.89861000000001),
                    new Vector(38.8947438181818, -81.931856),
                    new Vector(38.8844478181819, -81.91524200000001),
                    new Vector(38.8734588181818, -81.89268800000001),
                    new Vector(38.8857078181819, -81.866804),
                    new Vector(38.9378898181818, -81.84091100000001),
                    new Vector(38.9484648181819, -81.823775),
                    new Vector(38.9235618181818, -81.78323),
                    new Vector(38.9301858181819, -81.76229600000001),
                    new Vector(38.9685258181818, -81.781727),
                    new Vector(39.0168288181818, -81.7756789999999),
                    new Vector(39.0441078181818, -81.813461),
                    new Vector(39.0664188181818, -81.82427),
                    new Vector(39.0770208181819, -81.819563),
                    new Vector(39.0772548181819, -81.7863619999999),
                    new Vector(39.0947148181818, -81.75356600000001),
                    new Vector(39.1258728181818, -81.74470100000001),
                    new Vector(39.1757508181819, -81.758912),
                    new Vector(39.2132718181819, -81.723074),
                    new Vector(39.2200218181819, -81.697901),
                    new Vector(39.2602248181819, -81.689531),
                    new Vector(39.2704938181819, -81.667517),
                    new Vector(39.2659218181818, -81.5726839999999),
                    new Vector(39.3326568181819, -81.557393),
                    new Vector(39.3527088181819, -81.540644),
                    new Vector(39.406852818182, -81.465008),
                    new Vector(39.4110288181818, -81.4479529999999),
                    new Vector(39.4060248181818, -81.43398500000001),
                    new Vector(39.3456888181819, -81.375917),
                    new Vector(39.3536448181819, -81.338837),
                    new Vector(39.3870708181819, -81.284018),
                    new Vector(39.3884748181819, -81.23761399999999),
                    new Vector(39.4083558181818, -81.224942),
                    new Vector(39.4158978181818, -81.200309),
                    new Vector(39.4378038181819, -81.18056300000001),
                    new Vector(39.4677828181819, -81.11709500000001),
                    new Vector(39.4964568181819, -81.098249),
                    new Vector(39.5326638181818, -81.03738199999989),
                    new Vector(39.5441478181818, -81.032567),
                    new Vector(39.5818128181818, -80.983643),
                    new Vector(39.6069498181819, -80.932613),
                    new Vector(39.6073548181818, -80.912588),
                    new Vector(39.6240858181819, -80.881106),
                    new Vector(39.6624078181818, -80.87274499999999),
                    new Vector(39.6803538181818, -80.863421),
                    new Vector(39.7034028181818, -80.83279400000001),
                    new Vector(39.7188378181819, -80.83229900000001),
                    new Vector(39.7363338181819, -80.8564549999999),
                    new Vector(39.759994818182, -80.870729),
                    new Vector(39.8089998181819, -80.819096),
                    new Vector(39.8396628181818, -80.825918),
                    new Vector(39.8567178181818, -80.798531),
                    new Vector(39.8723418181819, -80.790845),
                    new Vector(39.9049038181819, -80.812139),
                    new Vector(39.9159018181819, -80.80783700000001),
                    new Vector(39.9198348181819, -80.7960199999999),
                    new Vector(39.9133098181818, -80.768129),
                    new Vector(39.921265818182, -80.758895),
                    new Vector(39.9470148181819, -80.76306200000001),
                    new Vector(39.9834738181819, -80.738888),
                    new Vector(40.0356648181819, -80.73824),
                    new Vector(40.154086818182, -80.70206),
                    new Vector(40.1531238181818, -80.87779399999999),
                    new Vector(40.1640858181818, -81.10471099999999),
                    new Vector(40.1616558181818, -81.219578),
                    new Vector(40.1646618181819, -81.331142),
                    new Vector(40.2082848181819, -81.32926999999999),
                    new Vector(40.2124878181818, -81.61394),
                    new Vector(40.2127038181819, -81.66276499999999),
                    new Vector(40.1444928181818, -81.66662599999999),
                    new Vector(40.1448258181818, -81.711203),
                    new Vector(40.1595048181819, -82.1824699999999),
                    new Vector(40.2314868181819, -82.175738),
                    new Vector(40.2313608181818, -82.19139800000001),
                    new Vector(40.2413328181819, -82.47614),
                    new Vector(40.2618528181819, -82.473944),
                    new Vector(40.2741288181817, -82.742756),
                    new Vector(40.1232348181819, -82.7564),
                    new Vector(40.1379858181818, -83.170175),
                    new Vector(40.1070168181818, -83.17193899999999),
                    new Vector(40.1073048181818, -83.20568),
                    new Vector(40.1136228181819, -83.499566),
                    new Vector(40.2213078181819, -83.48990000000001),
                    new Vector(40.2268698181818, -83.544674),
                    new Vector(40.2403518181818, -83.78001500000001),
                    new Vector(40.2589998181818, -83.779844),
                    new Vector(40.2709878181819, -84.009182),
                    new Vector(40.1795298181819, -84.020162),
                    new Vector(40.1961258181818, -84.24857299999999),
                    new Vector(40.1911308181819, -84.4243069999999),
                    new Vector(40.3528608181818, -84.42671),
                    new Vector(40.3530588181819, -84.79455799999999),
                    new Vector(40.3194978181818, -84.795395),
                    new Vector(40.0139928181817, -84.803567),
                    new Vector(39.9171618181819, -84.80615899999999),
                    new Vector(39.7333008181818, -84.8086969999999),
                    new Vector(39.5640558181818, -84.811037),
                    new Vector(39.5131608181817, -84.811109),
                    new Vector(39.3123348181819, -84.812027),
                    new Vector(39.3030288181818, -84.812072),
                    new Vector(39.1025808181818, -84.81147799999989),
                    new Vector(39.1070358181818, -84.789923),
                    new Vector(39.142063818182, -84.74287099999999),
                    new Vector(39.0896298181819, -84.66748699999999),
                    new Vector(39.0749328181818, -84.622649),
                    new Vector(39.0702618181818, -84.59306599999999),
                    new Vector(39.0941928181818, -84.515297)
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