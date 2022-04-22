namespace EpsgCoordinateSystems.Other
{
    public class GGRS87_Greek_Grid : IEpsgCoordinateSystem
    {
        public string Name => "GGRS87 / Greek Grid";
        public string Units => "Unspecified";
public long Srid => 2100;

        public string OgcWkt =>
            "PROJCS[GGRS87 / Greek Grid,GEOGCS[GGRS87,DATUM[Greek_Geodetic_Reference_System_1987,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[-199.87,74.79,246.62,0,0,0,0],AUTHORITY[EPSG,6121]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4121]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,24],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2100],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[GGRS87 / Greek Grid,GEOGCS[GGRS87,DATUM[D_GGRS_1987,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,24],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}