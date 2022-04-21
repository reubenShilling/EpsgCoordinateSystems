namespace EpsgCoordinateSystems.Other
{
    public class Pampa_del_Castillo : IEpsgCoordinateSystem
    {
        public string Name => "Pampa del Castillo";
        public long Srid => 4161;

        public string OgcWkt =>
            "GEOGCS[Pampa del Castillo,DATUM[Pampa_del_Castillo,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[27.5,14,186.4,0,0,0,0],AUTHORITY[EPSG,6161]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4161]]";

        public string EsriWkt =>
            "GEOGCS[Pampa del Castillo,DATUM[Pampa_del_Castillo,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[27.5,14,186.4,0,0,0,0],AUTHORITY[EPSG,6161]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4161]]";
    }
}