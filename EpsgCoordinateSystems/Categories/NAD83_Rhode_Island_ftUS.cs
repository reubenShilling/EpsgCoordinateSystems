using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Rhode_Island_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 3438;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Rhode Island";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Rhode Island (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,41.08333333333334],PARAMETER[central_meridian,-71.5],PARAMETER[scale_factor,0.99999375],PARAMETER[false_easting,328083.3333],PARAMETER[false_northing,0],AUTHORITY[EPSG,3438],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Rhode Island (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,41.08333333333334],PARAMETER[central_meridian,-71.5],PARAMETER[scale_factor,0.99999375],PARAMETER[false_easting,328083.3333],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(41.7215988181819, -71.78824400000001),
                    new Vector(41.6417508181818, -71.7926089999999),
                    new Vector(41.6013048181818, -71.790188),
                    new Vector(41.4158238181819, -71.80274300000001),
                    new Vector(41.4038538181817, -71.845997),
                    new Vector(41.3419608181818, -71.836871),
                    new Vector(41.3253468181819, -71.84777),
                    new Vector(41.3227728181819, -71.866679),
                    new Vector(41.3272638181818, -71.72226499999989),
                    new Vector(41.3920818181819, -71.48989400000001),
                    new Vector(41.486689818182, -71.427317),
                    new Vector(41.6522088181819, -71.41924400000001),
                    new Vector(41.7032928181819, -71.369006),
                    new Vector(41.7611538181819, -71.393585),
                    new Vector(41.7413538181819, -71.367395),
                    new Vector(41.6795418181819, -71.284001),
                    new Vector(41.7076938181819, -71.22897500000001),
                    new Vector(41.7497418181818, -71.266631),
                    new Vector(41.7721968181818, -71.319326),
                    new Vector(41.7844278181818, -71.33980099999999),
                    new Vector(41.8131648181819, -71.34547999999999),
                    new Vector(41.8579038181819, -71.33454500000001),
                    new Vector(41.8757778181817, -71.34249199999999),
                    new Vector(41.8960278181818, -71.333078),
                    new Vector(41.8884408181818, -71.383955),
                    new Vector(41.9792598181818, -71.382407),
                    new Vector(42.0137118181819, -71.37864500000001),
                    new Vector(42.0092568181819, -71.497427),
                    new Vector(42.0042708181819, -71.79782899999999),
                    new Vector(41.7215988181819, -71.78824400000001)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(41.6784978181819, -71.198807),
                    new Vector(41.4633168181818, -71.199932),
                    new Vector(41.4930618181817, -71.117132),
                    new Vector(41.6552688181819, -71.14120699999999),
                    new Vector(41.6784978181819, -71.198807)
                })
            },
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(41.6212758181818, -71.26916900000001),
                    new Vector(41.4458568181818, -71.34953),
                    new Vector(41.4836208181819, -71.2880059999999),
                    new Vector(41.474845818182, -71.2386769999999),
                    new Vector(41.6356488181819, -71.219444),
                    new Vector(41.6212758181818, -71.26916900000001)
                })
            }
        };
    }
}