namespace EpsgCoordinateSystems.Other
{
    public class Serindung : IEpsgCoordinateSystem
    {
        public string Name => "Serindung";
        public string Units => "Unspecified";
public long Srid => 4295;

        public string OgcWkt =>
            "GEOGCS[Serindung,DATUM[Serindung,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6295]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4295]]";

        public string EsriWkt => "GEOGCS[Serindung,DATUM[D_Serindung,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}