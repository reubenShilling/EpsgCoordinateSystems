namespace EpsgCoordinateSystems.Other
{
    public class Combani_1950 : IEpsgCoordinateSystem
    {
        public string Name => "Combani 1950";
        public string Units => "Unspecified";
public long Srid => 4632;

        public string OgcWkt =>
            "GEOGCS[Combani 1950,DATUM[Combani_1950,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-382,-59,-262,0,0,0,0],AUTHORITY[EPSG,6632]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4632]]";

        public string EsriWkt =>
            "GEOGCS[Combani 1950,DATUM[Combani_1950,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-382,-59,-262,0,0,0,0],AUTHORITY[EPSG,6632]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4632]]";
    }
}