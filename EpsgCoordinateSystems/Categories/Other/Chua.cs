namespace EpsgCoordinateSystems.Categories.Other
{
    public class Chua : IEpsgCoordinateSystem
    {
        public string Name => "Chua";
        public string Units => "Unspecified";
public int Srid => 4224;

        public string OgcWkt =>
            "GEOGCS[Chua,DATUM[Chua,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-134,229,-29,0,0,0,0],AUTHORITY[EPSG,6224]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4224]]";

        public string EsriWkt => "GEOGCS[Chua,DATUM[D_Chua,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}