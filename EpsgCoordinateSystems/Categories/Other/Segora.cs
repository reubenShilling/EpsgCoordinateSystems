namespace EpsgCoordinateSystems.Categories.Other
{
    public class Segora : IEpsgCoordinateSystem
    {
        public string Name => "Segora";
        public string Units => "Unspecified";
public int Srid => 4294;

        public string OgcWkt =>
            "GEOGCS[Segora,DATUM[Segora,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6294]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4294]]";

        public string EsriWkt => "GEOGCS[Segora,DATUM[D_Segora,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}