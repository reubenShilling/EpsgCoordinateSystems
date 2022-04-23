using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_New_York_West_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2262;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "New York West";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / New York West (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40],PARAMETER[central_meridian,-78.58333333333333],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,1148291.667],PARAMETER[false_northing,0],AUTHORITY[EPSG,2262],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / New York West (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40],PARAMETER[central_meridian,-78.58333333333333],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,1148291.667],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-79.763234, 42.2673228181819, 0),
                    new Vector(-79.761668, 42.0031098181819, 0),
                    new Vector(-79.61236700000001, 42.0005808181819, 0),
                    new Vector(-79.059488, 42.0011568181819, 0),
                    new Vector(-78.918539, 41.9998428181819, 0),
                    new Vector(-78.30509000000001, 41.9994198181819, 0),
                    new Vector(-78.204263, 41.9981958181819, 0),
                    new Vector(-77.74501100000001, 41.9973408181818, 0),
                    new Vector(-77.72144, 42.4712718181818, 0),
                    new Vector(-77.715734, 42.5392038181818, 0),
                    new Vector(-77.655416, 42.5409048181818, 0),
                    new Vector(-77.655254, 42.5850228181818, 0),
                    new Vector(-77.495, 42.5830608181818, 0),
                    new Vector(-77.485253, 42.6742848181819, 0),
                    new Vector(-77.597627, 42.6753288181818, 0),
                    new Vector(-77.617391, 42.7671198181819, 0),
                    new Vector(-77.58744799999999, 42.7679478181818, 0),
                    new Vector(-77.587025, 42.8562198181818, 0),
                    new Vector(-77.557181, 42.8597658181819, 0),
                    new Vector(-77.550665, 42.8790528181818, 0),
                    new Vector(-77.57977099999989, 42.9455898181818, 0),
                    new Vector(-77.479511, 42.9446628181819, 0),
                    new Vector(-77.4821929999999, 43.0351488181819, 0),
                    new Vector(-77.364968, 43.0363908181818, 0),
                    new Vector(-77.37731599999999, 43.275709818182, 0),
                    new Vector(-77.575712, 43.2415458181819, 0),
                    new Vector(-77.74501100000001, 43.3351728181819, 0),
                    new Vector(-77.992007, 43.3655748181819, 0),
                    new Vector(-78.464651, 43.3719918181819, 0),
                    new Vector(-79.06223300000001, 43.2682218181818, 0),
                    new Vector(-79.039328, 43.1447328181819, 0),
                    new Vector(-79.061117, 43.0906068181819, 0),
                    new Vector(-78.92560400000001, 43.0666308181819, 0),
                    new Vector(-78.882791, 43.0223508181819, 0),
                    new Vector(-78.93655699999999, 42.9742278181819, 0),
                    new Vector(-78.859202, 42.7927428181818, 0),
                    new Vector(-79.043756, 42.6992418181819, 0),
                    new Vector(-79.142234, 42.5746188181819, 0),
                    new Vector(-79.35488599999999, 42.4934658181818, 0),
                    new Vector(-79.444022, 42.4193598181818, 0),
                    new Vector(-79.763234, 42.2673228181819, 0)
                })
            }
        };
    }
}