using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Maine_East_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 26847;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Maine East";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Maine East (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,43.66666666666666],PARAMETER[central_meridian,-68.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,984250.0000000002],PARAMETER[false_northing,0],AUTHORITY[EPSG,26847],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Maine East (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,43.66666666666666],PARAMETER[central_meridian,-68.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,984250.0000000002],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-68.823806, 44.6640948181819, 0),
                    new Vector(-68.823554, 44.6089068181819, 0),
                    new Vector(-68.74528100000001, 44.5523148181819, 0),
                    new Vector(-68.741348, 44.5072788181819, 0),
                    new Vector(-68.8137619999999, 44.4139938181819, 0),
                    new Vector(-68.812853, 44.3274408181819, 0),
                    new Vector(-68.740313, 44.3463228181819, 0),
                    new Vector(-68.559431, 44.2598868181819, 0),
                    new Vector(-68.530073, 44.2898388181819, 0),
                    new Vector(-68.55218600000001, 44.3990448181819, 0),
                    new Vector(-68.42857100000001, 44.4653118181819, 0),
                    new Vector(-68.36376199999999, 44.4313908181818, 0),
                    new Vector(-68.245619, 44.4906468181819, 0),
                    new Vector(-68.13625999999989, 44.4752388181819, 0),
                    new Vector(-68.07438500000001, 44.3813688181818, 0),
                    new Vector(-68.016389, 44.3849508181819, 0),
                    new Vector(-67.986527, 44.4848058181819, 0),
                    new Vector(-67.96343299999999, 44.5053258181817, 0),
                    new Vector(-67.96834699999999, 44.4712248181818, 0),
                    new Vector(-67.900046, 44.4523968181819, 0),
                    new Vector(-67.858565, 44.5360788181818, 0),
                    new Vector(-67.811216, 44.554006818182, 0),
                    new Vector(-67.618832, 44.5402368181819, 0),
                    new Vector(-67.570988, 44.598340818182, 0),
                    new Vector(-67.388513, 44.6914008181818, 0),
                    new Vector(-67.30846699999999, 44.6535198181819, 0),
                    new Vector(-67.2003679999999, 44.6537808181818, 0),
                    new Vector(-67.00771400000001, 44.7806268181819, 0),
                    new Vector(-66.969275, 44.8286508181819, 0),
                    new Vector(-67.14671, 44.9045838181819, 0),
                    new Vector(-67.065359, 44.9592948181819, 0),
                    new Vector(-67.150661, 45.12198781818189, 0),
                    new Vector(-67.165907, 45.1562598181819, 0),
                    new Vector(-67.27408699999999, 45.1827828181819, 0),
                    new Vector(-67.34560999999999, 45.1222578181819, 0),
                    new Vector(-67.439435, 45.1895778181819, 0),
                    new Vector(-67.47795499999999, 45.2802798181818, 0),
                    new Vector(-67.4185549999999, 45.3758508181818, 0),
                    new Vector(-67.504109, 45.4858218181818, 0),
                    new Vector(-67.41607999999999, 45.5035518181818, 0),
                    new Vector(-67.4393, 45.5925618181818, 0),
                    new Vector(-67.615133, 45.6051978181819, 0),
                    new Vector(-67.718039, 45.681301818182, 0),
                    new Vector(-67.752959, 45.6592878181818, 0),
                    new Vector(-67.80343999999999, 45.678106818182, 0),
                    new Vector(-67.80305300000001, 45.79451281818181, 0),
                    new Vector(-67.759367, 45.8278038181819, 0),
                    new Vector(-67.79457499999999, 45.8784738181818, 0),
                    new Vector(-67.75561399999999, 45.9165798181818, 0),
                    new Vector(-67.780292, 45.947062818182, 0),
                    new Vector(-67.791011, 47.0610018181818, 0),
                    new Vector(-68.230805, 47.352142818182, 0),
                    new Vector(-68.334818, 47.35737181818191, 0),
                    new Vector(-68.391257, 47.2851018181818, 0),
                    new Vector(-68.514674, 47.2969638181818, 0),
                    new Vector(-68.89487, 47.1822588181818, 0),
                    new Vector(-69.03671900000001, 47.2573638181818, 0),
                    new Vector(-69.04697, 47.42202781818181, 0),
                    new Vector(-69.2303, 47.45333881818189, 0),
                    new Vector(-69.984977, 46.69136281818181, 0),
                    new Vector(-70.014146, 46.5706008181818, 0),
                    new Vector(-69.7172089999999, 46.57171681818191, 0),
                    new Vector(-69.728936, 45.97282081818189, 0),
                    new Vector(-69.683459, 45.9768798181819, 0),
                    new Vector(-69.6495649999999, 45.8640378181818, 0),
                    new Vector(-69.675269, 45.8511138181818, 0),
                    new Vector(-69.705275, 45.8827578181819, 0),
                    new Vector(-69.720647, 45.8777448181819, 0),
                    new Vector(-69.702944, 45.8378028181818, 0),
                    new Vector(-69.719369, 45.82640881818179, 0),
                    new Vector(-69.70863199999999, 45.8104968181818, 0),
                    new Vector(-69.730484, 45.77547781818181, 0),
                    new Vector(-69.72656000000001, 45.7552098181819, 0),
                    new Vector(-69.76507100000001, 45.75549781818189, 0),
                    new Vector(-69.778229, 45.7746858181818, 0),
                    new Vector(-69.793925, 45.7536528181818, 0),
                    new Vector(-69.791387, 45.7421238181818, 0),
                    new Vector(-69.8119609999999, 45.7368138181819, 0),
                    new Vector(-69.79447399999999, 45.7243758181818, 0),
                    new Vector(-69.778454, 45.6886278181819, 0),
                    new Vector(-69.735686, 45.6740118181819, 0),
                    new Vector(-69.73943, 45.6562818181818, 0),
                    new Vector(-69.697238, 45.6531048181818, 0),
                    new Vector(-69.69859700000001, 45.6421698181817, 0),
                    new Vector(-69.710576, 45.6384258181818, 0),
                    new Vector(-69.6957529999999, 45.6155298181819, 0),
                    new Vector(-69.711089, 45.61007581818191, 0),
                    new Vector(-69.708416, 45.5806908181819, 0),
                    new Vector(-69.777563, 45.5380308181818, 0),
                    new Vector(-69.69754399999989, 45.29488681818179, 0),
                    new Vector(-69.70676899999999, 45.2924478181818, 0),
                    new Vector(-69.649052, 45.102682818182, 0),
                    new Vector(-69.64125799999999, 45.10334881818181, 0),
                    new Vector(-69.60705799999999, 45.01309681818179, 0),
                    new Vector(-69.489608, 45.0306918181819, 0),
                    new Vector(-69.49378400000001, 45.0550548181819, 0),
                    new Vector(-69.352268, 45.0730818181818, 0),
                    new Vector(-69.272744, 44.8066188181818, 0),
                    new Vector(-69.282743, 44.8019478181819, 0),
                    new Vector(-69.2657329999999, 44.7232248181818, 0),
                    new Vector(-69.32405300000001, 44.7170508181819, 0),
                    new Vector(-69.344672, 44.7538608181818, 0),
                    new Vector(-69.38276, 44.7519888181818, 0),
                    new Vector(-69.39555799999989, 44.7437448181818, 0),
                    new Vector(-69.40284800000001, 44.7028848181818, 0),
                    new Vector(-69.462473, 44.6957928181819, 0),
                    new Vector(-69.47286800000001, 44.6943168181818, 0),
                    new Vector(-69.47349800000001, 44.6751558181819, 0),
                    new Vector(-69.432773, 44.6691978181818, 0),
                    new Vector(-69.460898, 44.6427648181818, 0),
                    new Vector(-69.401633, 44.6357088181819, 0),
                    new Vector(-69.41389100000001, 44.5498308181819, 0),
                    new Vector(-69.368756, 44.5437108181818, 0),
                    new Vector(-69.39257000000001, 44.4577878181818, 0),
                    new Vector(-69.440243, 44.4635388181818, 0),
                    new Vector(-69.504728, 44.3415798181818, 0),
                    new Vector(-69.414647, 44.330752818182, 0),
                    new Vector(-69.418661, 44.3185668181818, 0),
                    new Vector(-69.440135, 44.3224998181819, 0),
                    new Vector(-69.444338, 44.3075778181819, 0),
                    new Vector(-69.438821, 44.2375848181819, 0),
                    new Vector(-69.40785200000001, 44.2232838181819, 0),
                    new Vector(-69.403379, 44.2139958181818, 0),
                    new Vector(-69.3327469999999, 44.2106298181819, 0),
                    new Vector(-69.29757499999999, 44.1286398181819, 0),
                    new Vector(-69.3018409999999, 44.0945748181819, 0),
                    new Vector(-69.2825, 44.0701758181819, 0),
                    new Vector(-69.328598, 44.0111358181819, 0),
                    new Vector(-69.34645399999989, 44.0159688181819, 0),
                    new Vector(-69.293651, 43.9421868181818, 0),
                    new Vector(-69.219149, 43.9467948181818, 0),
                    new Vector(-69.074456, 44.0690598181819, 0),
                    new Vector(-69.02148200000001, 44.2440918181819, 0),
                    new Vector(-68.985023, 44.2711098181818, 0),
                    new Vector(-68.95918399999999, 44.4303288181818, 0),
                    new Vector(-68.811683, 44.4945888181819, 0),
                    new Vector(-68.807903, 44.569657818182, 0),
                    new Vector(-68.860607, 44.6109768181819, 0),
                    new Vector(-68.823806, 44.6640948181819, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-68.387918, 44.3772558181819, 0),
                    new Vector(-68.402894, 44.2708038181819, 0),
                    new Vector(-68.320706, 44.2250838181819, 0),
                    new Vector(-68.30471300000001, 44.2900278181818, 0),
                    new Vector(-68.164772, 44.3344878181819, 0),
                    new Vector(-68.23870700000001, 44.4375648181819, 0),
                    new Vector(-68.355446, 44.4288528181819, 0),
                    new Vector(-68.350253, 44.3989548181819, 0),
                    new Vector(-68.387918, 44.3772558181819, 0)
                })
            }
        };
    }
}