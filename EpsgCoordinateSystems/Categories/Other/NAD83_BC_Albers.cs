using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class NAD83_BC_Albers : IEpsgCoordinateSystem
    {private const int _srid = 3005; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NAD83 / BC Albers";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / BC Albers,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,50],PARAMETER[standard_parallel_2,58.5],PARAMETER[latitude_of_center,45],PARAMETER[longitude_of_center,-126],PARAMETER[false_easting,1000000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3005],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83 / BC Albers,GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Albers],PARAMETER[standard_parallel_1,50],PARAMETER[standard_parallel_2,58.5],PARAMETER[latitude_of_origin,45],PARAMETER[central_meridian,-126],PARAMETER[false_easting,1000000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}