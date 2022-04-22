namespace EpsgCoordinateSystems.Categories.Other
{
    public class Samboja : IEpsgCoordinateSystem
    {
        public string Name => "Samboja";
        public string Units => "Unspecified";
public int Srid => 4125;

        public string OgcWkt =>
            "GEOGCS[Samboja,DATUM[Samboja,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[-404.78,685.68,45.47,0,0,0,0],AUTHORITY[EPSG,6125]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4125]]";

        public string EsriWkt => "GEOGCS[Samboja,DATUM[D_Samboja,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}