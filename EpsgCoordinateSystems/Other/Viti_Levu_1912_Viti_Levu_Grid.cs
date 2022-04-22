namespace EpsgCoordinateSystems.Other
{
    public class Viti_Levu_1912_Viti_Levu_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Viti Levu 1912 / Viti Levu Grid";
        public string Units => "Unspecified";
public long Srid => 3140;

        public string OgcWkt =>
            "PROJCS[Viti Levu 1912 / Viti Levu Grid,GEOGCS[Viti Levu 1912,DATUM[Viti_Levu_1912,SPHEROID[Clarke 1880 (international foot),6378306.3696,293.4663076556361,AUTHORITY[EPSG,7055]],TOWGS84[51,391,-36,0,0,0,0],AUTHORITY[EPSG,6752]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4752]],UNIT[link,0.201168,AUTHORITY[EPSG,9098]],PROJECTION[Cassini_Soldner],PARAMETER[latitude_of_origin,-18],PARAMETER[central_meridian,178],PARAMETER[false_easting,544000],PARAMETER[false_northing,704000],AUTHORITY[EPSG,3140],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Viti Levu 1912 / Viti Levu Grid,GEOGCS[Viti Levu 1912,DATUM[Viti_Levu_1912,SPHEROID[Clarke 1880 (international foot),6378306.3696,293.4663076556361,AUTHORITY[EPSG,7055]],TOWGS84[51,391,-36,0,0,0,0],AUTHORITY[EPSG,6752]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4752]],UNIT[link,0.201168,AUTHORITY[EPSG,9098]],PROJECTION[Cassini_Soldner],PARAMETER[latitude_of_origin,-18],PARAMETER[central_meridian,178],PARAMETER[false_easting,544000],PARAMETER[false_northing,704000],AUTHORITY[EPSG,3140],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}