namespace EpsgCoordinateSystems.Other
{
    public class Afgooye : IEpsgCoordinateSystem
    {
        public string Name => "Afgooye";
        public long Srid => 4205;

        public string OgcWkt =>
            "GEOGCS[Afgooye,DATUM[Afgooye,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[-43,-163,45,0,0,0,0],AUTHORITY[EPSG,6205]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4205]]";

        public string EsriWkt =>
            "GEOGCS[Afgooye,DATUM[Afgooye,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[-43,-163,45,0,0,0,0],AUTHORITY[EPSG,6205]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4205]]";
    }
}