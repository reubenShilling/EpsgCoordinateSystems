using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Rhode_Island_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 3438;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Rhode Island";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Rhode Island (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,41.08333333333334],PARAMETER[central_meridian,-71.5],PARAMETER[scale_factor,0.99999375],PARAMETER[false_easting,328083.3333],PARAMETER[false_northing,0],AUTHORITY[EPSG,3438],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Rhode Island (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,41.08333333333334],PARAMETER[central_meridian,-71.5],PARAMETER[scale_factor,0.99999375],PARAMETER[false_easting,328083.3333],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-71.78824400000001, 41.7215988181819, 0),
                    new Vector(-71.7926089999999, 41.6417508181818, 0),
                    new Vector(-71.790188, 41.6013048181818, 0),
                    new Vector(-71.80274300000001, 41.4158238181819, 0),
                    new Vector(-71.845997, 41.4038538181817, 0),
                    new Vector(-71.836871, 41.3419608181818, 0),
                    new Vector(-71.84777, 41.3253468181819, 0),
                    new Vector(-71.866679, 41.3227728181819, 0),
                    new Vector(-71.72226499999989, 41.3272638181818, 0),
                    new Vector(-71.48989400000001, 41.3920818181819, 0),
                    new Vector(-71.427317, 41.486689818182, 0),
                    new Vector(-71.41924400000001, 41.6522088181819, 0),
                    new Vector(-71.369006, 41.7032928181819, 0),
                    new Vector(-71.393585, 41.7611538181819, 0),
                    new Vector(-71.367395, 41.7413538181819, 0),
                    new Vector(-71.284001, 41.6795418181819, 0),
                    new Vector(-71.22897500000001, 41.7076938181819, 0),
                    new Vector(-71.266631, 41.7497418181818, 0),
                    new Vector(-71.319326, 41.7721968181818, 0),
                    new Vector(-71.33980099999999, 41.7844278181818, 0),
                    new Vector(-71.34547999999999, 41.8131648181819, 0),
                    new Vector(-71.33454500000001, 41.8579038181819, 0),
                    new Vector(-71.34249199999999, 41.8757778181817, 0),
                    new Vector(-71.333078, 41.8960278181818, 0),
                    new Vector(-71.383955, 41.8884408181818, 0),
                    new Vector(-71.382407, 41.9792598181818, 0),
                    new Vector(-71.37864500000001, 42.0137118181819, 0),
                    new Vector(-71.497427, 42.0092568181819, 0),
                    new Vector(-71.79782899999999, 42.0042708181819, 0),
                    new Vector(-71.78824400000001, 41.7215988181819, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-71.198807, 41.6784978181819, 0),
                    new Vector(-71.199932, 41.4633168181818, 0),
                    new Vector(-71.117132, 41.4930618181817, 0),
                    new Vector(-71.14120699999999, 41.6552688181819, 0),
                    new Vector(-71.198807, 41.6784978181819, 0)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-71.26916900000001, 41.6212758181818, 0),
                    new Vector(-71.34953, 41.4458568181818, 0),
                    new Vector(-71.2880059999999, 41.4836208181819, 0),
                    new Vector(-71.2386769999999, 41.474845818182, 0),
                    new Vector(-71.219444, 41.6356488181819, 0),
                    new Vector(-71.26916900000001, 41.6212758181818, 0)
                })
            }
        };
    }
}