namespace EpsgCoordinateSystems.Other
{
    public class Padang : IEpsgCoordinateSystem
    {
        public string Name => "Padang";
        public string Units => "Unspecified";
public long Srid => 4280;

        public string OgcWkt =>
            "GEOGCS[Padang,DATUM[Padang_1884,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6280]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4280]]";

        public string EsriWkt => "GEOGCS[Padang,DATUM[D_Padang_1884,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}