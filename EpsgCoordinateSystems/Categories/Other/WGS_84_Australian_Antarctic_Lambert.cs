using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class WGS_84_Australian_Antarctic_Lambert : IEpsgCoordinateSystem
    {private const int _srid = 3033; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "WGS 84 / Australian Antarctic Lambert";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[WGS 84 / Australian Antarctic Lambert,GEOGCS[WGS 84,DATUM[WGS_1984,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4326]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,-68.5],PARAMETER[standard_parallel_2,-74.5],PARAMETER[latitude_of_origin,-50],PARAMETER[central_meridian,70],PARAMETER[false_easting,6000000],PARAMETER[false_northing,6000000],AUTHORITY[EPSG,3033],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[WGS 84 / Australian Antarctic Lambert,GEOGCS[GCS_WGS_1984,DATUM[D_WGS_1984,SPHEROID[WGS_1984,6378137,298.257223563]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,-68.5],PARAMETER[standard_parallel_2,-74.5],PARAMETER[latitude_of_origin,-50],PARAMETER[central_meridian,70],PARAMETER[false_easting,6000000],PARAMETER[false_northing,6000000],UNIT[Meter,1]]";
    }
}