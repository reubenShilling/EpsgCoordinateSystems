using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Maine_West_ftUS : INad83UsFtCrs
    {
        private const int _srid = 26848;
        private readonly BoundingBox _boundingBox = new BoundingBox();

public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Maine West";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt => "PROJCS[\"NAD83 / Maine West (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",42.83333333333334],PARAMETER[\"central_meridian\",-70.16666666666667],PARAMETER[\"scale_factor\",0.999966667],PARAMETER[\"false_easting\",2952750],PARAMETER[\"false_northing\",0],AUTHORITY[\"EPSG\",\"26848\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt => "PROJCS[\"NAD83 / Maine West (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",42.83333333333334],PARAMETER[\"central_meridian\",-70.16666666666667],PARAMETER[\"scale_factor\",0.999966667],PARAMETER[\"false_easting\",2952750],PARAMETER[\"false_northing\",0],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(44.2821438181819, -71.008601),
                    new Vector(43.7911668181818, -70.98444499999999),
                    new Vector(43.5718278181819, -70.97387000000001),
                    new Vector(43.5641418181819, -70.95652699999999),
                    new Vector(43.5489588181819, -70.94961499999999),
                    new Vector(43.5319938181819, -70.96426700000001),
                    new Vector(43.5163878181819, -70.959281),
                    new Vector(43.470208818182, -70.970792),
                    new Vector(43.4381238181818, -70.96148599999999),
                    new Vector(43.3961838181818, -70.97909900000001),
                    new Vector(43.3663848181818, -70.969703),
                    new Vector(43.3020708181818, -70.90580300000001),
                    new Vector(43.2810198181818, -70.9010779999999),
                    new Vector(43.2352188181819, -70.813211),
                    new Vector(43.1591688181819, -70.830545),
                    new Vector(43.1218728181819, -70.818665),
                    new Vector(43.0910568181818, -70.6656739999999),
                    new Vector(43.3357218181819, -70.538945),
                    new Vector(43.3494738181818, -70.456973),
                    new Vector(43.4303028181818, -70.36592899999989),
                    new Vector(43.5349098181819, -70.341611),
                    new Vector(43.5772368181818, -70.222235),
                    new Vector(43.6858038181819, -70.235798),
                    new Vector(43.7898078181819, -70.15662500000001),
                    new Vector(43.8455988181819, -70.026404),
                    new Vector(43.8457338181819, -69.987371),
                    new Vector(43.7862078181818, -69.999503),
                    new Vector(43.7688468181819, -69.972899),
                    new Vector(43.7907348181819, -69.90313999999999),
                    new Vector(43.8767118181819, -69.886787),
                    new Vector(43.8423498181818, -69.846152),
                    new Vector(43.7443308181819, -69.851786),
                    new Vector(43.7279778181818, -69.830393),
                    new Vector(43.7560848181818, -69.79153100000001),
                    new Vector(44.0000028181818, -69.859931),
                    new Vector(44.0741448181819, -69.777275),
                    new Vector(44.0477388181819, -69.76675400000001),
                    new Vector(44.0268678181819, -69.800009),
                    new Vector(43.7912748181818, -69.777671),
                    new Vector(43.7617008181818, -69.750365),
                    new Vector(43.7844798181818, -69.72467),
                    new Vector(43.8933708181818, -69.748529),
                    new Vector(43.9379838181819, -69.72063799999999),
                    new Vector(44.0336088181818, -69.61293499999999),
                    new Vector(43.9802568181819, -69.655244),
                    new Vector(43.8522228181818, -69.664451),
                    new Vector(43.8448608181818, -69.58932799999999),
                    new Vector(43.8871608181819, -69.48323600000001),
                    new Vector(44.0251308181818, -69.394487),
                    new Vector(44.0159688181819, -69.34645399999989),
                    new Vector(44.0111358181819, -69.328598),
                    new Vector(44.0701758181819, -69.2825),
                    new Vector(44.0945748181819, -69.3018409999999),
                    new Vector(44.1286398181819, -69.29757499999999),
                    new Vector(44.2106298181819, -69.3327469999999),
                    new Vector(44.2139958181818, -69.403379),
                    new Vector(44.2232838181819, -69.40785200000001),
                    new Vector(44.2375848181819, -69.438821),
                    new Vector(44.3075778181819, -69.444338),
                    new Vector(44.3224998181819, -69.440135),
                    new Vector(44.3185668181818, -69.418661),
                    new Vector(44.330752818182, -69.414647),
                    new Vector(44.3415798181818, -69.504728),
                    new Vector(44.4635388181818, -69.440243),
                    new Vector(44.4577878181818, -69.39257000000001),
                    new Vector(44.5437108181818, -69.368756),
                    new Vector(44.5498308181819, -69.41389100000001),
                    new Vector(44.6357088181819, -69.401633),
                    new Vector(44.6427648181818, -69.460898),
                    new Vector(44.6691978181818, -69.432773),
                    new Vector(44.6751558181819, -69.47349800000001),
                    new Vector(44.6943168181818, -69.47286800000001),
                    new Vector(44.6957928181819, -69.462473),
                    new Vector(44.7028848181818, -69.40284800000001),
                    new Vector(44.7437448181818, -69.39555799999989),
                    new Vector(44.7519888181818, -69.38276),
                    new Vector(44.7538608181818, -69.344672),
                    new Vector(44.7170508181819, -69.32405300000001),
                    new Vector(44.7232248181818, -69.2657329999999),
                    new Vector(44.8019478181819, -69.282743),
                    new Vector(44.8066188181818, -69.272744),
                    new Vector(45.0730818181818, -69.352268),
                    new Vector(45.0550548181819, -69.49378400000001),
                    new Vector(45.0306918181819, -69.489608),
                    new Vector(45.01309681818179, -69.60705799999999),
                    new Vector(45.10334881818181, -69.64125799999999),
                    new Vector(45.102682818182, -69.649052),
                    new Vector(45.2924478181818, -69.70676899999999),
                    new Vector(45.29488681818179, -69.69754399999989),
                    new Vector(45.5380308181818, -69.777563),
                    new Vector(45.5806908181819, -69.708416),
                    new Vector(45.61007581818191, -69.711089),
                    new Vector(45.6155298181819, -69.6957529999999),
                    new Vector(45.6384258181818, -69.710576),
                    new Vector(45.6421698181817, -69.69859700000001),
                    new Vector(45.6531048181818, -69.697238),
                    new Vector(45.6562818181818, -69.73943),
                    new Vector(45.6740118181819, -69.735686),
                    new Vector(45.6886278181819, -69.778454),
                    new Vector(45.7243758181818, -69.79447399999999),
                    new Vector(45.7368138181819, -69.8119609999999),
                    new Vector(45.7421238181818, -69.791387),
                    new Vector(45.7536528181818, -69.793925),
                    new Vector(45.7746858181818, -69.778229),
                    new Vector(45.75549781818189, -69.76507100000001),
                    new Vector(45.7552098181819, -69.72656000000001),
                    new Vector(45.77547781818181, -69.730484),
                    new Vector(45.8104968181818, -69.70863199999999),
                    new Vector(45.82640881818179, -69.719369),
                    new Vector(45.8378028181818, -69.702944),
                    new Vector(45.8777448181819, -69.720647),
                    new Vector(45.8827578181819, -69.705275),
                    new Vector(45.8511138181818, -69.675269),
                    new Vector(45.8640378181818, -69.6495649999999),
                    new Vector(45.9768798181819, -69.683459),
                    new Vector(45.97282081818189, -69.728936),
                    new Vector(46.57171681818191, -69.7172089999999),
                    new Vector(46.5706008181818, -70.014146),
                    new Vector(46.4261148181818, -70.046609),
                    new Vector(46.33483681818179, -70.191059),
                    new Vector(46.1902428181818, -70.28349799999999),
                    new Vector(46.1374398181818, -70.229327),
                    new Vector(46.06665481818191, -70.304846),
                    new Vector(46.0531548181818, -70.28001500000001),
                    new Vector(45.96877981818191, -70.31029100000001),
                    new Vector(45.9446148181819, -70.247462),
                    new Vector(45.8990118181819, -70.25396000000001),
                    new Vector(45.7903098181819, -70.41622099999999),
                    new Vector(45.7220448181819, -70.396385),
                    new Vector(45.6606648181819, -70.552274),
                    new Vector(45.51295681818181, -70.719908),
                    new Vector(45.3919608181819, -70.63493),
                    new Vector(45.4251708181819, -70.7969659999999),
                    new Vector(45.3907278181819, -70.829132),
                    new Vector(45.3546828181818, -70.812662),
                    new Vector(45.2781378181819, -70.84287500000001),
                    new Vector(45.2254428181819, -70.876445),
                    new Vector(45.3388608181819, -70.95938),
                    new Vector(45.30147481818191, -71.087513),
                    new Vector(44.6685408181818, -71.02872499999999),
                    new Vector(44.2821438181819, -71.008601)
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