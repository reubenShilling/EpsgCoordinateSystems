using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class WGS_84_Mercator_41 : IEpsgCoordinateSystem
    {private const int _srid = 3994; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "WGS 84 / Mercator 41";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[WGS 84 / Mercator 41,GEOGCS[WGS 84,DATUM[World Geodetic System 1984,SPHEROID[WGS 84,6378137.0,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4326]],PROJECTION[Mercator (2SP),AUTHORITY[EPSG,9805]],PARAMETER[standard_parallel_1,41.0],PARAMETER[latitude_of_origin,0.0],PARAMETER[central_meridian,100.0],PARAMETER[false_easting,0.0],PARAMETER[false_northing,0.0],UNIT[m,1.0],AXIS[Easting,EAST],AXIS[Northing,NORTH],AUTHORITY[EPSG,3994]]";

        public string EsriWkt => "PROJCS[WGS 84 / Mercator 41,GEOGCS[GCS_WGS_1984,DATUM[D_World Geodetic System 1984,SPHEROID[WGS_1984,6378137.0,298.257223563]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]],PROJECTION[Mercator (2SP)],PARAMETER[standard_parallel_1,41.0],PARAMETER[latitude_of_origin,0.0],PARAMETER[central_meridian,100.0],PARAMETER[false_easting,0.0],PARAMETER[false_northing,0.0],UNIT[m,1.0]]";
    }
}