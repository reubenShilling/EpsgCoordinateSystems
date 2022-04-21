namespace EpsgCoordinateSystems.Other
{
    public class Makassar : IEpsgCoordinateSystem
    {
        public string Name => "Makassar";
        public long Srid => 4257;

        public string OgcWkt =>
            "GEOGCS[Makassar,DATUM[Makassar,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[-587.8,519.75,145.76,0,0,0,0],AUTHORITY[EPSG,6257]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4257]]";

        public string EsriWkt =>
            "GEOGCS[Makassar,DATUM[Makassar,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[-587.8,519.75,145.76,0,0,0,0],AUTHORITY[EPSG,6257]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4257]]";
    }
}