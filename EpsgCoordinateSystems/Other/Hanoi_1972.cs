namespace EpsgCoordinateSystems.Other
{
    public class Hanoi_1972 : IEpsgCoordinateSystem
    {
        public string Name => "Hanoi 1972";
        public long Srid => 4147;

        public string OgcWkt =>
            "GEOGCS[Hanoi 1972,DATUM[Hanoi_1972,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[-17.51,-108.32,-62.39,0,0,0,0],AUTHORITY[EPSG,6147]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4147]]";

        public string EsriWkt =>
            "GEOGCS[Hanoi 1972,DATUM[Hanoi_1972,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[-17.51,-108.32,-62.39,0,0,0,0],AUTHORITY[EPSG,6147]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4147]]";
    }
}