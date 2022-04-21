namespace EpsgCoordinateSystems.Other
{
    public class Beijing_1954_Gauss_Kruger_zone_16 : IEpsgCoordinateSystem
    {
        public string Name => "Beijing 1954 / Gauss-Kruger zone 16";
        public long Srid => 21416;

        public string OgcWkt =>
            "PROJCS[Beijing 1954 / Gauss-Kruger zone 16,GEOGCS[Beijing 1954,DATUM[Beijing_1954,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6214]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4214]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,93],PARAMETER[scale_factor,1],PARAMETER[false_easting,16500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,21416],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Beijing 1954 / Gauss-Kruger zone 16,GEOGCS[Beijing 1954,DATUM[Beijing_1954,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6214]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4214]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,93],PARAMETER[scale_factor,1],PARAMETER[false_easting,16500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,21416],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}