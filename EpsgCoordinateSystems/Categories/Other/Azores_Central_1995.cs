namespace EpsgCoordinateSystems.Categories.Other
{
    public class Azores_Central_1995 : IEpsgCoordinateSystem
    {
        public string Name => "Azores Central 1995";
        public string Units => "Unspecified";
public int Srid => 4665;

        public string OgcWkt =>
            "GEOGCS[Azores Central 1995,DATUM[Azores_Central_Islands_1995,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6665]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4665]]";

        public string EsriWkt => "GEOGCS[Azores Central 1995,DATUM[D_Azores_Central_Islands_1995,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}