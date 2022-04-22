namespace EpsgCoordinateSystems.Categories.Other
{
    public class S_JTSK : IEpsgCoordinateSystem
    {
        public string Name => "S-JTSK";
        public string Units => "Unspecified";
public int Srid => 4156;

        public string OgcWkt =>
            "GEOGCS[S-JTSK,DATUM[Jednotne_Trigonometricke_Site_Katastralni,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6156]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4156]]";

        public string EsriWkt => "GEOGCS[S-JTSK,DATUM[D_S_JTSK,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}