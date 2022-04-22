namespace EpsgCoordinateSystems.Other
{
    public class South_Yemen_Gauss_Kruger_zone_8 : IEpsgCoordinateSystem
    {
        public string Name => "South Yemen / Gauss-Kruger zone 8";
        public string Units => "Unspecified";
public long Srid => 2395;

        public string OgcWkt =>
            "PROJCS[South Yemen / Gauss-Kruger zone 8,GEOGCS[South Yemen,DATUM[South_Yemen,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[-76,-138,67,0,0,0,0],AUTHORITY[EPSG,6164]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4164]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,45],PARAMETER[scale_factor,1],PARAMETER[false_easting,8500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2395],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[South Yemen / Gauss-Kruger zone 8,GEOGCS[South Yemen,DATUM[South_Yemen,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[-76,-138,67,0,0,0,0],AUTHORITY[EPSG,6164]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4164]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,45],PARAMETER[scale_factor,1],PARAMETER[false_easting,8500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2395],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}