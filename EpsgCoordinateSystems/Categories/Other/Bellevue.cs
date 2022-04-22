namespace EpsgCoordinateSystems.Categories.Other
{
    public class Bellevue : IEpsgCoordinateSystem
    {
        public string Name => "Bellevue";
        public string Units => "Unspecified";
public int Srid => 4714;

        public string OgcWkt =>
            "GEOGCS[Bellevue,DATUM[Bellevue,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-127,-769,472,0,0,0,0],AUTHORITY[EPSG,6714]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4714]]";

        public string EsriWkt => "GEOGCS[Bellevue,DATUM[D_Bellevue_IGN,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}