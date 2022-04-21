namespace EpsgCoordinateSystems.Other
{
    public class Corrego_Alegre : IEpsgCoordinateSystem
    {
        public string Name => "Corrego Alegre";
        public long Srid => 4225;

        public string OgcWkt =>
            "GEOGCS[Corrego Alegre,DATUM[Corrego_Alegre,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-206,172,-6,0,0,0,0],AUTHORITY[EPSG,6225]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4225]]";

        public string EsriWkt =>
            "GEOGCS[Corrego Alegre,DATUM[Corrego_Alegre,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-206,172,-6,0,0,0,0],AUTHORITY[EPSG,6225]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4225]]";
    }
}