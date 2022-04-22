namespace EpsgCoordinateSystems.Other
{
    public class Adindan : IEpsgCoordinateSystem
    {
        public string Name => "Adindan";
        public string Units => "Unspecified";
public long Srid => 4201;

        public string OgcWkt =>
            "GEOGCS[Adindan,DATUM[Adindan,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6201]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4201]]";

        public string EsriWkt => "GEOGCS[Adindan,DATUM[D_Adindan,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}