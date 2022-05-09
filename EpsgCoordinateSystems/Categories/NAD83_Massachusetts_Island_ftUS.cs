using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Massachusetts_Island_ftUS : IEpsgCoordinateSystem
    {
        private const int _srid = 2250;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Massachusetts Island";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Massachusetts Island (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,41.48333333333333],PARAMETER[standard_parallel_2,41.28333333333333],PARAMETER[latitude_of_origin,41],PARAMETER[central_meridian,-70.5],PARAMETER[false_easting,1640416.667],PARAMETER[false_northing,0],AUTHORITY[EPSG,2250],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Massachusetts Island (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,41.48333333333333],PARAMETER[standard_parallel_2,41.28333333333333],PARAMETER[latitude_of_origin,41],PARAMETER[central_meridian,-70.5],PARAMETER[false_easting,1640416.667],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(41.4296658181819, -70.60433),
                    new Vector(41.4746658181818, -70.605842),
                    new Vector(41.4549378181818, -70.667492),
                    new Vector(41.3821728181818, -70.751777),
                    new Vector(41.3249778181819, -70.770929),
                    new Vector(41.3525178181818, -70.78252999999999),
                    new Vector(41.3486028181819, -70.843919),
                    new Vector(41.2981668181818, -70.769705),
                    new Vector(41.3341578181818, -70.73867300000001),
                    new Vector(41.3415648181819, -70.486142),
                    new Vector(41.3986608181818, -70.515158),
                    new Vector(41.4102798181818, -70.57585400000001),
                    new Vector(41.4173898181819, -70.552832),
                    new Vector(41.4645678181819, -70.567691),
                    new Vector(41.4296658181819, -70.60433)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(41.3119278181818, -70.03171399999999),
                    new Vector(41.2776288181819, -70.09787299999989),
                    new Vector(41.2940898181818, -70.207097),
                    new Vector(41.2702128181819, -70.21327100000001),
                    new Vector(41.2382808181818, -70.103111),
                    new Vector(41.251816818182, -69.96844400000001),
                    new Vector(41.2948908181818, -69.96597800000001),
                    new Vector(41.3919648181818, -70.04926399999999),
                    new Vector(41.3497188181819, -70.034486),
                    new Vector(41.2968438181818, -70.08763999999999),
                    new Vector(41.3372088181819, -70.02661999999989),
                    new Vector(41.3247708181818, -70.006505),
                    new Vector(41.3119278181818, -70.03171399999999)
                })
            }
        };
    }
}