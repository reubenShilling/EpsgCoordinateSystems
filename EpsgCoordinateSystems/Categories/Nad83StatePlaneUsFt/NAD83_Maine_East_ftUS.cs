using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_Maine_East_ftUS : INad83UsFtCrs
    {
        private const int _srid = 26847;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Maine East";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / Maine East (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",43.66666666666666],PARAMETER[\"central_meridian\",-68.5],PARAMETER[\"scale_factor\",0.9999],PARAMETER[\"false_easting\",984250.0000000002],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"26847\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / Maine East (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",43.66666666666666],PARAMETER[\"central_meridian\",-68.5],PARAMETER[\"scale_factor\",0.9999],PARAMETER[\"false_easting\",984250.0000000002],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(44.6640948181819, -68.823806),
                    new Vector(44.6089068181819, -68.823554),
                    new Vector(44.5523148181819, -68.74528100000001),
                    new Vector(44.5072788181819, -68.741348),
                    new Vector(44.4139938181819, -68.8137619999999),
                    new Vector(44.3274408181819, -68.812853),
                    new Vector(44.3463228181819, -68.740313),
                    new Vector(44.2598868181819, -68.559431),
                    new Vector(44.2898388181819, -68.530073),
                    new Vector(44.3990448181819, -68.55218600000001),
                    new Vector(44.4653118181819, -68.42857100000001),
                    new Vector(44.4313908181818, -68.36376199999999),
                    new Vector(44.4906468181819, -68.245619),
                    new Vector(44.4752388181819, -68.13625999999989),
                    new Vector(44.3813688181818, -68.07438500000001),
                    new Vector(44.3849508181819, -68.016389),
                    new Vector(44.4848058181819, -67.986527),
                    new Vector(44.5053258181817, -67.96343299999999),
                    new Vector(44.4712248181818, -67.96834699999999),
                    new Vector(44.4523968181819, -67.900046),
                    new Vector(44.5360788181818, -67.858565),
                    new Vector(44.554006818182, -67.811216),
                    new Vector(44.5402368181819, -67.618832),
                    new Vector(44.598340818182, -67.570988),
                    new Vector(44.6914008181818, -67.388513),
                    new Vector(44.6535198181819, -67.30846699999999),
                    new Vector(44.6537808181818, -67.2003679999999),
                    new Vector(44.7806268181819, -67.00771400000001),
                    new Vector(44.8286508181819, -66.969275),
                    new Vector(44.9045838181819, -67.14671),
                    new Vector(44.9592948181819, -67.065359),
                    new Vector(45.12198781818189, -67.150661),
                    new Vector(45.1562598181819, -67.165907),
                    new Vector(45.1827828181819, -67.27408699999999),
                    new Vector(45.1222578181819, -67.34560999999999),
                    new Vector(45.1895778181819, -67.439435),
                    new Vector(45.2802798181818, -67.47795499999999),
                    new Vector(45.3758508181818, -67.4185549999999),
                    new Vector(45.4858218181818, -67.504109),
                    new Vector(45.5035518181818, -67.41607999999999),
                    new Vector(45.5925618181818, -67.4393),
                    new Vector(45.6051978181819, -67.615133),
                    new Vector(45.681301818182, -67.718039),
                    new Vector(45.6592878181818, -67.752959),
                    new Vector(45.678106818182, -67.80343999999999),
                    new Vector(45.79451281818181, -67.80305300000001),
                    new Vector(45.8278038181819, -67.759367),
                    new Vector(45.8784738181818, -67.79457499999999),
                    new Vector(45.9165798181818, -67.75561399999999),
                    new Vector(45.947062818182, -67.780292),
                    new Vector(47.0610018181818, -67.791011),
                    new Vector(47.352142818182, -68.230805),
                    new Vector(47.35737181818191, -68.334818),
                    new Vector(47.2851018181818, -68.391257),
                    new Vector(47.2969638181818, -68.514674),
                    new Vector(47.1822588181818, -68.89487),
                    new Vector(47.2573638181818, -69.03671900000001),
                    new Vector(47.42202781818181, -69.04697),
                    new Vector(47.45333881818189, -69.2303),
                    new Vector(46.69136281818181, -69.984977),
                    new Vector(46.5706008181818, -70.014146),
                    new Vector(46.57171681818191, -69.7172089999999),
                    new Vector(45.97282081818189, -69.728936),
                    new Vector(45.9768798181819, -69.683459),
                    new Vector(45.8640378181818, -69.6495649999999),
                    new Vector(45.8511138181818, -69.675269),
                    new Vector(45.8827578181819, -69.705275),
                    new Vector(45.8777448181819, -69.720647),
                    new Vector(45.8378028181818, -69.702944),
                    new Vector(45.82640881818179, -69.719369),
                    new Vector(45.8104968181818, -69.70863199999999),
                    new Vector(45.77547781818181, -69.730484),
                    new Vector(45.7552098181819, -69.72656000000001),
                    new Vector(45.75549781818189, -69.76507100000001),
                    new Vector(45.7746858181818, -69.778229),
                    new Vector(45.7536528181818, -69.793925),
                    new Vector(45.7421238181818, -69.791387),
                    new Vector(45.7368138181819, -69.8119609999999),
                    new Vector(45.7243758181818, -69.79447399999999),
                    new Vector(45.6886278181819, -69.778454),
                    new Vector(45.6740118181819, -69.735686),
                    new Vector(45.6562818181818, -69.73943),
                    new Vector(45.6531048181818, -69.697238),
                    new Vector(45.6421698181817, -69.69859700000001),
                    new Vector(45.6384258181818, -69.710576),
                    new Vector(45.6155298181819, -69.6957529999999),
                    new Vector(45.61007581818191, -69.711089),
                    new Vector(45.5806908181819, -69.708416),
                    new Vector(45.5380308181818, -69.777563),
                    new Vector(45.29488681818179, -69.69754399999989),
                    new Vector(45.2924478181818, -69.70676899999999),
                    new Vector(45.102682818182, -69.649052),
                    new Vector(45.10334881818181, -69.64125799999999),
                    new Vector(45.01309681818179, -69.60705799999999),
                    new Vector(45.0306918181819, -69.489608),
                    new Vector(45.0550548181819, -69.49378400000001),
                    new Vector(45.0730818181818, -69.352268),
                    new Vector(44.8066188181818, -69.272744),
                    new Vector(44.8019478181819, -69.282743),
                    new Vector(44.7232248181818, -69.2657329999999),
                    new Vector(44.7170508181819, -69.32405300000001),
                    new Vector(44.7538608181818, -69.344672),
                    new Vector(44.7519888181818, -69.38276),
                    new Vector(44.7437448181818, -69.39555799999989),
                    new Vector(44.7028848181818, -69.40284800000001),
                    new Vector(44.6957928181819, -69.462473),
                    new Vector(44.6943168181818, -69.47286800000001),
                    new Vector(44.6751558181819, -69.47349800000001),
                    new Vector(44.6691978181818, -69.432773),
                    new Vector(44.6427648181818, -69.460898),
                    new Vector(44.6357088181819, -69.401633),
                    new Vector(44.5498308181819, -69.41389100000001),
                    new Vector(44.5437108181818, -69.368756),
                    new Vector(44.4577878181818, -69.39257000000001),
                    new Vector(44.4635388181818, -69.440243),
                    new Vector(44.3415798181818, -69.504728),
                    new Vector(44.330752818182, -69.414647),
                    new Vector(44.3185668181818, -69.418661),
                    new Vector(44.3224998181819, -69.440135),
                    new Vector(44.3075778181819, -69.444338),
                    new Vector(44.2375848181819, -69.438821),
                    new Vector(44.2232838181819, -69.40785200000001),
                    new Vector(44.2139958181818, -69.403379),
                    new Vector(44.2106298181819, -69.3327469999999),
                    new Vector(44.1286398181819, -69.29757499999999),
                    new Vector(44.0945748181819, -69.3018409999999),
                    new Vector(44.0701758181819, -69.2825),
                    new Vector(44.0111358181819, -69.328598),
                    new Vector(44.0159688181819, -69.34645399999989),
                    new Vector(43.9421868181818, -69.293651),
                    new Vector(43.9467948181818, -69.219149),
                    new Vector(44.0690598181819, -69.074456),
                    new Vector(44.2440918181819, -69.02148200000001),
                    new Vector(44.2711098181818, -68.985023),
                    new Vector(44.4303288181818, -68.95918399999999),
                    new Vector(44.4945888181819, -68.811683),
                    new Vector(44.569657818182, -68.807903),
                    new Vector(44.6109768181819, -68.860607),
                    new Vector(44.6640948181819, -68.823806)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(44.3772558181819, -68.387918),
                    new Vector(44.2708038181819, -68.402894),
                    new Vector(44.2250838181819, -68.320706),
                    new Vector(44.2900278181818, -68.30471300000001),
                    new Vector(44.3344878181819, -68.164772),
                    new Vector(44.4375648181819, -68.23870700000001),
                    new Vector(44.4288528181819, -68.355446),
                    new Vector(44.3989548181819, -68.350253),
                    new Vector(44.3772558181819, -68.387918)
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