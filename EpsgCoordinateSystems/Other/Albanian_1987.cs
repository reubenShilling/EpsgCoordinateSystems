namespace EpsgCoordinateSystems.Other
{
    public class Albanian_1987 : IEpsgCoordinateSystem
    {
        public string Name => "Albanian 1987";
        public string Units => "Unspecified";
public long Srid => 4191;

        public string OgcWkt =>
            "GEOGCS[Albanian 1987,DATUM[Albanian_1987,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6191]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4191]]";

        public string EsriWkt =>
            "GEOGCS[Albanian 1987,DATUM[Albanian_1987,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6191]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4191]]";
    }
}