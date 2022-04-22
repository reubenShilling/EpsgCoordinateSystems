namespace EpsgCoordinateSystems.Other
{
    public class Viti_Levu_1912 : IEpsgCoordinateSystem
    {
        public string Name => "Viti Levu 1912";
        public string Units => "Unspecified";
public long Srid => 4752;

        public string OgcWkt =>
            "GEOGCS[Viti Levu 1912,DATUM[Viti_Levu_1912,SPHEROID[Clarke 1880 (international foot),6378306.3696,293.4663076556361,AUTHORITY[EPSG,7055]],TOWGS84[51,391,-36,0,0,0,0],AUTHORITY[EPSG,6752]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4752]]";

        public string EsriWkt =>
            "GEOGCS[Viti Levu 1912,DATUM[Viti_Levu_1912,SPHEROID[Clarke 1880 (international foot),6378306.3696,293.4663076556361,AUTHORITY[EPSG,7055]],TOWGS84[51,391,-36,0,0,0,0],AUTHORITY[EPSG,6752]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4752]]";
    }
}