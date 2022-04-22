namespace EpsgCoordinateSystems.Other
{
    public class Vanua_Levu_1915_Vanua_Levu_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Vanua Levu 1915 / Vanua Levu Grid";
        public string Units => "Unspecified";
public long Srid => 3139;

        public string OgcWkt =>
            "PROJCS[Vanua Levu 1915 / Vanua Levu Grid,GEOGCS[Vanua Levu 1915,DATUM[Vanua_Levu_1915,SPHEROID[Clarke 1880 (international foot),6378306.3696,293.4663076556361,AUTHORITY[EPSG,7055]],TOWGS84[51,391,-36,0,0,0,0],AUTHORITY[EPSG,6748]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4748],AXIS[Latitude,NORTH],AXIS[Longitude,EAST]],UNIT[link,0.201168,AUTHORITY[EPSG,9098]]]";

        public string EsriWkt =>
            "PROJCS[Vanua Levu 1915 / Vanua Levu Grid,GEOGCS[Vanua Levu 1915,DATUM[Vanua_Levu_1915,SPHEROID[Clarke 1880 (international foot),6378306.3696,293.4663076556361,AUTHORITY[EPSG,7055]],TOWGS84[51,391,-36,0,0,0,0],AUTHORITY[EPSG,6748]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4748],AXIS[Latitude,NORTH],AXIS[Longitude,EAST]],UNIT[link,0.201168,AUTHORITY[EPSG,9098]]]";
    }
}