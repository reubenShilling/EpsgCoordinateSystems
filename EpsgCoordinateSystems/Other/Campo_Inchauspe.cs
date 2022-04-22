namespace EpsgCoordinateSystems.Other
{
    public class Campo_Inchauspe : IEpsgCoordinateSystem
    {
        public string Name => "Campo Inchauspe";
        public string Units => "Unspecified";
public long Srid => 4221;

        public string OgcWkt =>
            "GEOGCS[Campo Inchauspe,DATUM[Campo_Inchauspe,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6221]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4221]]";

        public string EsriWkt => "GEOGCS[Campo Inchauspe,DATUM[D_Campo_Inchauspe,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}