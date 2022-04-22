namespace EpsgCoordinateSystems.Categories.Other
{
    public class RD_83 : IEpsgCoordinateSystem
    {
        public string Name => "RD/83";
        public string Units => "Unspecified";
public int Srid => 4745;

        public string OgcWkt =>
            "GEOGCS[RD/83,DATUM[Rauenberg_Datum_83,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6745]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4745]]";

        public string EsriWkt => "GEOGCS[RD/83,DATUM[D_,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}