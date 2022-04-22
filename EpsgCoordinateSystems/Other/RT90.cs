namespace EpsgCoordinateSystems.Other
{
    public class RT90 : IEpsgCoordinateSystem
    {
        public string Name => "RT90";
        public string Units => "Unspecified";
public long Srid => 4124;

        public string OgcWkt =>
            "GEOGCS[RT90,DATUM[Rikets_koordinatsystem_1990,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6124]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4124]]";

        public string EsriWkt => "GEOGCS[RT90,DATUM[D_RT_1990,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}