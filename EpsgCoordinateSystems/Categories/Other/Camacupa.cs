namespace EpsgCoordinateSystems.Categories.Other
{
    public class Camacupa : IEpsgCoordinateSystem
    {
        public string Name => "Camacupa";
        public string Units => "Unspecified";
public int Srid => 4220;

        public string OgcWkt =>
            "GEOGCS[Camacupa,DATUM[Camacupa,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6220]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4220]]";

        public string EsriWkt => "GEOGCS[Camacupa,DATUM[D_Camacupa,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}