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
    internal class NAD83_New_York_West_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2262;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "New York West";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / New York West (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40],PARAMETER[central_meridian,-78.58333333333333],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,1148291.667],PARAMETER[false_northing,0],AUTHORITY[EPSG,2262],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / New York West (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40],PARAMETER[central_meridian,-78.58333333333333],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,1148291.667],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(42.2673228181819, -79.763234),
                    new Vector(42.0031098181819, -79.761668),
                    new Vector(42.0005808181819, -79.61236700000001),
                    new Vector(42.0011568181819, -79.059488),
                    new Vector(41.9998428181819, -78.918539),
                    new Vector(41.9994198181819, -78.30509000000001),
                    new Vector(41.9981958181819, -78.204263),
                    new Vector(41.9973408181818, -77.74501100000001),
                    new Vector(42.4712718181818, -77.72144),
                    new Vector(42.5392038181818, -77.715734),
                    new Vector(42.5409048181818, -77.655416),
                    new Vector(42.5850228181818, -77.655254),
                    new Vector(42.5830608181818, -77.495),
                    new Vector(42.6742848181819, -77.485253),
                    new Vector(42.6753288181818, -77.597627),
                    new Vector(42.7671198181819, -77.617391),
                    new Vector(42.7679478181818, -77.58744799999999),
                    new Vector(42.8562198181818, -77.587025),
                    new Vector(42.8597658181819, -77.557181),
                    new Vector(42.8790528181818, -77.550665),
                    new Vector(42.9455898181818, -77.57977099999989),
                    new Vector(42.9446628181819, -77.479511),
                    new Vector(43.0351488181819, -77.4821929999999),
                    new Vector(43.0363908181818, -77.364968),
                    new Vector(43.275709818182, -77.37731599999999),
                    new Vector(43.2415458181819, -77.575712),
                    new Vector(43.3351728181819, -77.74501100000001),
                    new Vector(43.3655748181819, -77.992007),
                    new Vector(43.3719918181819, -78.464651),
                    new Vector(43.2682218181818, -79.06223300000001),
                    new Vector(43.1447328181819, -79.039328),
                    new Vector(43.0906068181819, -79.061117),
                    new Vector(43.0666308181819, -78.92560400000001),
                    new Vector(43.0223508181819, -78.882791),
                    new Vector(42.9742278181819, -78.93655699999999),
                    new Vector(42.7927428181818, -78.859202),
                    new Vector(42.6992418181819, -79.043756),
                    new Vector(42.5746188181819, -79.142234),
                    new Vector(42.4934658181818, -79.35488599999999),
                    new Vector(42.4193598181818, -79.444022),
                    new Vector(42.2673228181819, -79.763234)
                })
            }
        };
    }
}