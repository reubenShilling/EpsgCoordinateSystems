namespace EpsgCoordinateSystems.Other
{
    public class Greek : IEpsgCoordinateSystem
    {
        public string Name => "Greek";
        public long Srid => 4120;

        public string OgcWkt =>
            "GEOGCS[Greek,DATUM[Greek,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6120]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4120]]";

        public string EsriWkt =>
            "GEOGCS[Greek,DATUM[Greek,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6120]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4120]]";
    }
}