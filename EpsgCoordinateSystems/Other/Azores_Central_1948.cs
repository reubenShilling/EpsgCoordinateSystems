namespace EpsgCoordinateSystems.Other
{
    public class Azores_Central_1948 : IEpsgCoordinateSystem
    {
        public string Name => "Azores Central 1948";
        public string Units => "Unspecified";
public long Srid => 4183;

        public string OgcWkt =>
            "GEOGCS[Azores Central 1948,DATUM[Azores_Central_Islands_1948,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-104,167,-38,0,0,0,0],AUTHORITY[EPSG,6183]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4183]]";

        public string EsriWkt => "GEOGCS[Azores Central 1948,DATUM[D_Azores_Central_Islands_1948,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}