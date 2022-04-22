namespace EpsgCoordinateSystems.Other
{
    public class JAD2001_Jamaica_Metric_Grid : IEpsgCoordinateSystem
    {
        public string Name => "JAD2001 / Jamaica Metric Grid";
        public string Units => "Unspecified";
public long Srid => 3448;

        public string OgcWkt =>
            "PROJCS[JAD2001 / Jamaica Metric Grid,GEOGCS[JAD2001,DATUM[Jamaica_2001,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6758]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4758]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,18],PARAMETER[central_meridian,-77],PARAMETER[scale_factor,1],PARAMETER[false_easting,750000],PARAMETER[false_northing,650000],AUTHORITY[EPSG,3448],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[JAD2001 / Jamaica Metric Grid,GEOGCS[JAD2001,DATUM[Jamaica_2001,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6758]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4758]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,18],PARAMETER[central_meridian,-77],PARAMETER[scale_factor,1],PARAMETER[false_easting,750000],PARAMETER[false_northing,650000],AUTHORITY[EPSG,3448],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}