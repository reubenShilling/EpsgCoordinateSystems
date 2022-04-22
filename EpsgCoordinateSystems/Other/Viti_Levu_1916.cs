namespace EpsgCoordinateSystems.Other
{
    public class Viti_Levu_1916 : IEpsgCoordinateSystem
    {
        public string Name => "Viti Levu 1916";
        public string Units => "Unspecified";
public long Srid => 4731;

        public string OgcWkt =>
            "GEOGCS[Viti Levu 1916,DATUM[Viti_Levu_1916,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[51,391,-36,0,0,0,0],AUTHORITY[EPSG,6731]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4731]]";

        public string EsriWkt =>
            "GEOGCS[Viti Levu 1916,DATUM[Viti_Levu_1916,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[51,391,-36,0,0,0,0],AUTHORITY[EPSG,6731]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4731]]";
    }
}