namespace EpsgCoordinateSystems.Other
{
    public class Albanian_1987_Gauss_Kruger_zone_4 : IEpsgCoordinateSystem
    {
        public string Name => "Albanian 1987 / Gauss-Kruger zone 4";
        public string Units => "Unspecified";
public long Srid => 2462;

        public string OgcWkt =>
            "PROJCS[Albanian 1987 / Gauss-Kruger zone 4,GEOGCS[Albanian 1987,DATUM[Albanian_1987,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6191]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4191]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,21],PARAMETER[scale_factor,1],PARAMETER[false_easting,4500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2462],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[Albanian 1987 / Gauss-Kruger zone 4,GEOGCS[Albanian 1987,DATUM[D_Albanian_1987,SPHEROID[Krassowsky_1940,6378245,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,21],PARAMETER[scale_factor,1],PARAMETER[false_easting,4500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}