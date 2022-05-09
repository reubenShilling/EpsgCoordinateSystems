using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Massachusetts_Mainland_ftUS : IEpsgCoordinateSystem
    {
        private const int _srid = 2249;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Massachusetts Mainland";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Massachusetts Mainland (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,42.68333333333333],PARAMETER[standard_parallel_2,41.71666666666667],PARAMETER[latitude_of_origin,41],PARAMETER[central_meridian,-71.5],PARAMETER[false_easting,656166.667],PARAMETER[false_northing,2460625],AUTHORITY[EPSG,2249],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Massachusetts Mainland (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,42.68333333333333],PARAMETER[standard_parallel_2,41.71666666666667],PARAMETER[latitude_of_origin,41],PARAMETER[central_meridian,-71.5],PARAMETER[false_easting,656166.667],PARAMETER[false_northing,2460625],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(42.0042708181819, -71.79782899999999),
                    new Vector(42.0092568181819, -71.497427),
                    new Vector(42.0137118181819, -71.37864500000001),
                    new Vector(41.9792598181818, -71.382407),
                    new Vector(41.8884408181818, -71.383955),
                    new Vector(41.8960278181818, -71.333078),
                    new Vector(41.8757778181817, -71.34249199999999),
                    new Vector(41.8579038181819, -71.33454500000001),
                    new Vector(41.8131648181819, -71.34547999999999),
                    new Vector(41.7844278181818, -71.33980099999999),
                    new Vector(41.7721968181818, -71.319326),
                    new Vector(41.7497418181818, -71.266631),
                    new Vector(41.7076938181819, -71.22897500000001),
                    new Vector(41.6784978181819, -71.198807),
                    new Vector(41.6552688181819, -71.14120699999999),
                    new Vector(41.4930618181817, -71.117132),
                    new Vector(41.5201248181818, -71.00118500000001),
                    new Vector(41.6339118181818, -70.8921229999999),
                    new Vector(41.6266938181819, -70.839428),
                    new Vector(41.7356388181818, -70.619765),
                    new Vector(41.5561248181819, -70.664891),
                    new Vector(41.5397988181819, -70.637135),
                    new Vector(41.5697508181819, -70.43291600000001),
                    new Vector(41.6125728181819, -70.39761799999999),
                    new Vector(41.671486818182, -69.954431),
                    new Vector(41.7676518181818, -69.917783),
                    new Vector(41.9040918181818, -69.964169),
                    new Vector(42.0263028181819, -70.05047),
                    new Vector(42.0724908181818, -70.135088),
                    new Vector(42.0601158181818, -70.25514800000001),
                    new Vector(42.0021918181819, -70.10050099999989),
                    new Vector(41.8563558181818, -70.00044800000001),
                    new Vector(41.7815208181818, -70.019222),
                    new Vector(41.7125718181819, -70.20526099999999),
                    new Vector(41.7118068181819, -70.34112500000001),
                    new Vector(41.7216618181819, -70.2738319999999),
                    new Vector(41.7436218181819, -70.423511),
                    new Vector(41.8057668181819, -70.537712),
                    new Vector(41.9309568181819, -70.54034),
                    new Vector(41.9681898181818, -70.6187029999999),
                    new Vector(42.1531668181818, -70.686032),
                    new Vector(42.2486388181819, -70.7745919999999),
                    new Vector(42.260509818182, -70.824668),
                    new Vector(42.2657658181818, -70.892672),
                    new Vector(42.2345178181818, -70.92319999999999),
                    new Vector(42.2856288181818, -71.034161),
                    new Vector(42.4323918181819, -70.960622),
                    new Vector(42.4480698181818, -70.89359899999999),
                    new Vector(42.5464398181819, -70.81313),
                    new Vector(42.5826468181818, -70.633454),
                    new Vector(42.6463128181818, -70.593197),
                    new Vector(42.6635298181819, -70.7396899999999),
                    new Vector(42.8670648181819, -70.813886),
                    new Vector(42.8634288181819, -70.849733),
                    new Vector(42.8868828181818, -70.89810799999999),
                    new Vector(42.8851458181819, -70.92133699999999),
                    new Vector(42.8511708181818, -71.025431),
                    new Vector(42.8043168181818, -71.065562),
                    new Vector(42.8182848181818, -71.120597),
                    new Vector(42.8073138181818, -71.181068),
                    new Vector(42.738760818182, -71.186342),
                    new Vector(42.7435578181818, -71.240486),
                    new Vector(42.7260708181818, -71.252411),
                    new Vector(42.6986028181818, -71.287187),
                    new Vector(42.7053798181819, -71.900942),
                    new Vector(42.7072068181819, -71.93021899999999),
                    new Vector(42.7204638181819, -72.27991400000001),
                    new Vector(42.7258548181819, -72.45577400000001),
                    new Vector(42.7373658181818, -72.923),
                    new Vector(42.7403988181818, -73.019687),
                    new Vector(42.7460508181819, -73.258061),
                    new Vector(42.5047518181819, -73.350824),
                    new Vector(42.0774678181818, -73.49883800000001),
                    new Vector(42.0474258181819, -73.48423099999999),
                    new Vector(42.036310818182, -73.04563400000001),
                    new Vector(42.0360048181819, -73.00608800000001),
                    new Vector(42.0335118181819, -72.816458),
                    new Vector(41.9971788181818, -72.817682),
                    new Vector(42.0021648181818, -72.76757000000001),
                    new Vector(42.0338448181819, -72.755888),
                    new Vector(42.0305328181819, -72.60953000000001),
                    new Vector(42.0228018181819, -72.607829),
                    new Vector(42.0216048181818, -72.5819089999999),
                    new Vector(42.0301278181818, -72.571226),
                    new Vector(42.0307668181819, -72.507569),
                    new Vector(42.0264018181819, -72.136346),
                    new Vector(42.0257988181819, -72.094973),
                    new Vector(42.0179778181819, -71.802347),
                    new Vector(42.0042708181819, -71.79782899999999)
                })
            }
        };
    }
}