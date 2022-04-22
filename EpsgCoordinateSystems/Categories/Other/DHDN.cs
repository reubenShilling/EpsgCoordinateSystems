namespace EpsgCoordinateSystems.Categories.Other
{
    public class DHDN : IEpsgCoordinateSystem
    {
        public string Name => "DHDN";
        public string Units => "Unspecified";
public int Srid => 4314;

        public string OgcWkt =>
            "GEOGCS[DHDN,DATUM[Deutsches_Hauptdreiecksnetz,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6314]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4314]]";

        public string EsriWkt => "GEOGCS[DHDN,DATUM[D_Deutsches_Hauptdreiecksnetz,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}