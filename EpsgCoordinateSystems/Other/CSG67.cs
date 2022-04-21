namespace EpsgCoordinateSystems.Other
{
    public class CSG67 : IEpsgCoordinateSystem
    {
        public string Name => "CSG67";
        public long Srid => 4623;

        public string OgcWkt =>
            "GEOGCS[CSG67,DATUM[Centre_Spatial_Guyanais_1967,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-186,230,110,0,0,0,0],AUTHORITY[EPSG,6623]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4623]]";

        public string EsriWkt =>
            "GEOGCS[CSG67,DATUM[Centre_Spatial_Guyanais_1967,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-186,230,110,0,0,0,0],AUTHORITY[EPSG,6623]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4623]]";
    }
}