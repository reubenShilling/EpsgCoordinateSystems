namespace EpsgCoordinateSystems.Other
{
    public class Massawa : IEpsgCoordinateSystem
    {
        public string Name => "Massawa";
        public long Srid => 4262;

        public string OgcWkt =>
            "GEOGCS[Massawa,DATUM[Massawa,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[639,405,60,0,0,0,0],AUTHORITY[EPSG,6262]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4262]]";

        public string EsriWkt =>
            "GEOGCS[Massawa,DATUM[Massawa,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[639,405,60,0,0,0,0],AUTHORITY[EPSG,6262]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4262]]";
    }
}