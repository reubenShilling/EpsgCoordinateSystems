namespace EpsgCoordinateSystems.Categories.Other
{
    public class Mahe_1971 : IEpsgCoordinateSystem
    {
        public string Name => "Mahe 1971";
        public string Units => "Unspecified";
public int Srid => 4256;

        public string OgcWkt =>
            "GEOGCS[Mahe 1971,DATUM[Mahe_1971,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[41,-220,-134,0,0,0,0],AUTHORITY[EPSG,6256]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4256]]";

        public string EsriWkt => "GEOGCS[Mahe 1971,DATUM[D_Mahe_1971,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}