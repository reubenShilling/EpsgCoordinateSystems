using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Massachusetts_Mainland_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2249;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Massachusetts Mainland";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Massachusetts Mainland (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,42.68333333333333],PARAMETER[standard_parallel_2,41.71666666666667],PARAMETER[latitude_of_origin,41],PARAMETER[central_meridian,-71.5],PARAMETER[false_easting,656166.667],PARAMETER[false_northing,2460625],AUTHORITY[EPSG,2249],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Massachusetts Mainland (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,42.68333333333333],PARAMETER[standard_parallel_2,41.71666666666667],PARAMETER[latitude_of_origin,41],PARAMETER[central_meridian,-71.5],PARAMETER[false_easting,656166.667],PARAMETER[false_northing,2460625],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-71.79782899999999, 42.0042708181819, 0),
                    new Vector(-71.497427, 42.0092568181819, 0),
                    new Vector(-71.37864500000001, 42.0137118181819, 0),
                    new Vector(-71.382407, 41.9792598181818, 0),
                    new Vector(-71.383955, 41.8884408181818, 0),
                    new Vector(-71.333078, 41.8960278181818, 0),
                    new Vector(-71.34249199999999, 41.8757778181817, 0),
                    new Vector(-71.33454500000001, 41.8579038181819, 0),
                    new Vector(-71.34547999999999, 41.8131648181819, 0),
                    new Vector(-71.33980099999999, 41.7844278181818, 0),
                    new Vector(-71.319326, 41.7721968181818, 0),
                    new Vector(-71.266631, 41.7497418181818, 0),
                    new Vector(-71.22897500000001, 41.7076938181819, 0),
                    new Vector(-71.198807, 41.6784978181819, 0),
                    new Vector(-71.14120699999999, 41.6552688181819, 0),
                    new Vector(-71.117132, 41.4930618181817, 0),
                    new Vector(-71.00118500000001, 41.5201248181818, 0),
                    new Vector(-70.8921229999999, 41.6339118181818, 0),
                    new Vector(-70.839428, 41.6266938181819, 0),
                    new Vector(-70.619765, 41.7356388181818, 0),
                    new Vector(-70.664891, 41.5561248181819, 0),
                    new Vector(-70.637135, 41.5397988181819, 0),
                    new Vector(-70.43291600000001, 41.5697508181819, 0),
                    new Vector(-70.39761799999999, 41.6125728181819, 0),
                    new Vector(-69.954431, 41.671486818182, 0),
                    new Vector(-69.917783, 41.7676518181818, 0),
                    new Vector(-69.964169, 41.9040918181818, 0),
                    new Vector(-70.05047, 42.0263028181819, 0),
                    new Vector(-70.135088, 42.0724908181818, 0),
                    new Vector(-70.25514800000001, 42.0601158181818, 0),
                    new Vector(-70.10050099999989, 42.0021918181819, 0),
                    new Vector(-70.00044800000001, 41.8563558181818, 0),
                    new Vector(-70.019222, 41.7815208181818, 0),
                    new Vector(-70.20526099999999, 41.7125718181819, 0),
                    new Vector(-70.34112500000001, 41.7118068181819, 0),
                    new Vector(-70.2738319999999, 41.7216618181819, 0),
                    new Vector(-70.423511, 41.7436218181819, 0),
                    new Vector(-70.537712, 41.8057668181819, 0),
                    new Vector(-70.54034, 41.9309568181819, 0),
                    new Vector(-70.6187029999999, 41.9681898181818, 0),
                    new Vector(-70.686032, 42.1531668181818, 0),
                    new Vector(-70.7745919999999, 42.2486388181819, 0),
                    new Vector(-70.824668, 42.260509818182, 0),
                    new Vector(-70.892672, 42.2657658181818, 0),
                    new Vector(-70.92319999999999, 42.2345178181818, 0),
                    new Vector(-71.034161, 42.2856288181818, 0),
                    new Vector(-70.960622, 42.4323918181819, 0),
                    new Vector(-70.89359899999999, 42.4480698181818, 0),
                    new Vector(-70.81313, 42.5464398181819, 0),
                    new Vector(-70.633454, 42.5826468181818, 0),
                    new Vector(-70.593197, 42.6463128181818, 0),
                    new Vector(-70.7396899999999, 42.6635298181819, 0),
                    new Vector(-70.813886, 42.8670648181819, 0),
                    new Vector(-70.849733, 42.8634288181819, 0),
                    new Vector(-70.89810799999999, 42.8868828181818, 0),
                    new Vector(-70.92133699999999, 42.8851458181819, 0),
                    new Vector(-71.025431, 42.8511708181818, 0),
                    new Vector(-71.065562, 42.8043168181818, 0),
                    new Vector(-71.120597, 42.8182848181818, 0),
                    new Vector(-71.181068, 42.8073138181818, 0),
                    new Vector(-71.186342, 42.738760818182, 0),
                    new Vector(-71.240486, 42.7435578181818, 0),
                    new Vector(-71.252411, 42.7260708181818, 0),
                    new Vector(-71.287187, 42.6986028181818, 0),
                    new Vector(-71.900942, 42.7053798181819, 0),
                    new Vector(-71.93021899999999, 42.7072068181819, 0),
                    new Vector(-72.27991400000001, 42.7204638181819, 0),
                    new Vector(-72.45577400000001, 42.7258548181819, 0),
                    new Vector(-72.923, 42.7373658181818, 0),
                    new Vector(-73.019687, 42.7403988181818, 0),
                    new Vector(-73.258061, 42.7460508181819, 0),
                    new Vector(-73.350824, 42.5047518181819, 0),
                    new Vector(-73.49883800000001, 42.0774678181818, 0),
                    new Vector(-73.48423099999999, 42.0474258181819, 0),
                    new Vector(-73.04563400000001, 42.036310818182, 0),
                    new Vector(-73.00608800000001, 42.0360048181819, 0),
                    new Vector(-72.816458, 42.0335118181819, 0),
                    new Vector(-72.817682, 41.9971788181818, 0),
                    new Vector(-72.76757000000001, 42.0021648181818, 0),
                    new Vector(-72.755888, 42.0338448181819, 0),
                    new Vector(-72.60953000000001, 42.0305328181819, 0),
                    new Vector(-72.607829, 42.0228018181819, 0),
                    new Vector(-72.5819089999999, 42.0216048181818, 0),
                    new Vector(-72.571226, 42.0301278181818, 0),
                    new Vector(-72.507569, 42.0307668181819, 0),
                    new Vector(-72.136346, 42.0264018181819, 0),
                    new Vector(-72.094973, 42.0257988181819, 0),
                    new Vector(-71.802347, 42.0179778181819, 0),
                    new Vector(-71.79782899999999, 42.0042708181819, 0)
                })
            }
        };
    }
}