using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Dom;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Kentucky_Single_Zone_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 3089;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Kentucky Single Zone";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Kentucky Single Zone (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,37.08333333333334],PARAMETER[standard_parallel_2,38.66666666666666],PARAMETER[latitude_of_origin,36.33333333333334],PARAMETER[central_meridian,-85.75],PARAMETER[false_easting,4921250],PARAMETER[false_northing,3280833.333],AUTHORITY[EPSG,3089],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Kentucky Single Zone (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,37.08333333333334],PARAMETER[standard_parallel_2,38.66666666666666],PARAMETER[latitude_of_origin,36.33333333333334],PARAMETER[central_meridian,-85.75],PARAMETER[false_easting,4921250],PARAMETER[false_northing,3280833.333],UNIT[Foot_US,0.30480060960121924]]";

        // TODO locate WGS boundary data for this coordinate system
        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>();
    }
}