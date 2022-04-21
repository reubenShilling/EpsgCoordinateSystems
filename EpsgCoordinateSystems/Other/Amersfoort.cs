namespace EpsgCoordinateSystems.Other
{
    public class Amersfoort : IEpsgCoordinateSystem
    {
        public string Name => "Amersfoort";
        public long Srid => 4289;

        public string OgcWkt =>
            "GEOGCS[Amersfoort,DATUM[Amersfoort,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6289]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4289]]";

        public string EsriWkt =>
            "GEOGCS[Amersfoort,DATUM[Amersfoort,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6289]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4289]]";
    }
}