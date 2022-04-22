namespace EpsgCoordinateSystems.Categories.Other
{
    public class Lisbon_1890 : IEpsgCoordinateSystem
    {
        public string Name => "Lisbon 1890";
        public string Units => "Unspecified";
public int Srid => 4666;

        public string OgcWkt =>
            "GEOGCS[Lisbon 1890,DATUM[Lisbon_1890,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6666]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4666]]";

        public string EsriWkt => "GEOGCS[Lisbon 1890,DATUM[D_Lisbon_1890,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}