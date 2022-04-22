namespace EpsgCoordinateSystems.Other
{
    public class Batavia : IEpsgCoordinateSystem
    {
        public string Name => "Batavia";
        public string Units => "Unspecified";
public long Srid => 4211;

        public string OgcWkt =>
            "GEOGCS[Batavia,DATUM[Batavia,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6211]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4211]]";

        public string EsriWkt => "GEOGCS[Batavia,DATUM[D_Batavia,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}