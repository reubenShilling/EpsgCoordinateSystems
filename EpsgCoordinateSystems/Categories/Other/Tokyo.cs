namespace EpsgCoordinateSystems.Categories.Other
{
    public class Tokyo : IEpsgCoordinateSystem
    {
        public string Name => "Tokyo";
        public string Units => "Unspecified";
public int Srid => 4301;

        public string OgcWkt =>
            "GEOGCS[Tokyo,DATUM[Tokyo,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6301]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4301]]";

        public string EsriWkt => "GEOGCS[Tokyo,DATUM[D_Tokyo,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}