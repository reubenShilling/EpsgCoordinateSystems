namespace EpsgCoordinateSystems.Other
{
    public class ST71_Belep : IEpsgCoordinateSystem
    {
        public string Name => "ST71 Belep";
        public string Units => "Unspecified";
public long Srid => 4643;

        public string OgcWkt =>
            "GEOGCS[ST71 Belep,DATUM[ST71_Belep,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-480.26,-438.32,-643.429,16.3119,20.1721,-4.0349,-111.7],AUTHORITY[EPSG,6643]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4643]]";

        public string EsriWkt =>
            "GEOGCS[ST71 Belep,DATUM[ST71_Belep,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-480.26,-438.32,-643.429,16.3119,20.1721,-4.0349,-111.7],AUTHORITY[EPSG,6643]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4643]]";
    }
}