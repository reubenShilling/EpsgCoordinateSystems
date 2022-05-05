using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Dom;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Louisiana_Offshore_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 3453;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Louisiana Offshore";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Louisiana Offshore (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,27.83333333333333],PARAMETER[standard_parallel_2,26.16666666666667],PARAMETER[latitude_of_origin,25.5],PARAMETER[central_meridian,-91.33333333333333],PARAMETER[false_easting,3280833.333300001],PARAMETER[false_northing,0],AUTHORITY[EPSG,3453],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Louisiana Offshore (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,27.83333333333333],PARAMETER[standard_parallel_2,26.16666666666667],PARAMETER[latitude_of_origin,25.5],PARAMETER[central_meridian,-91.33333333333333],PARAMETER[false_easting,3280833.333300001],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        // TODO locate WGS boundary data for this coordinate system
        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>();
    }
}