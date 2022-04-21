namespace EpsgCoordinateSystems.Other
{
    public class RT38 : IEpsgCoordinateSystem
    {
        public string Name => "RT38";
        public long Srid => 4308;

        public string OgcWkt =>
            "GEOGCS[RT38,DATUM[Stockholm_1938,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6308]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4308]]";

        public string EsriWkt =>
            "GEOGCS[RT38,DATUM[Stockholm_1938,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6308]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4308]]";
    }
}