namespace EpsgCoordinateSystems.Other
{
    public class Vanua_Levu_1915 : IEpsgCoordinateSystem
    {
        public string Name => "Vanua Levu 1915";
        public string Units => "Unspecified";
public long Srid => 4748;

        public string OgcWkt =>
            "GEOGCS[Vanua Levu 1915,DATUM[Vanua_Levu_1915,SPHEROID[Clarke 1880 (international foot),6378306.3696,293.4663076556361,AUTHORITY[EPSG,7055]],TOWGS84[51,391,-36,0,0,0,0],AUTHORITY[EPSG,6748]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4748]]";

        public string EsriWkt =>
            "GEOGCS[Vanua Levu 1915,DATUM[Vanua_Levu_1915,SPHEROID[Clarke 1880 (international foot),6378306.3696,293.4663076556361,AUTHORITY[EPSG,7055]],TOWGS84[51,391,-36,0,0,0,0],AUTHORITY[EPSG,6748]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4748]]";
    }
}