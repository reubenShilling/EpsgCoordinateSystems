namespace EpsgCoordinateSystems.Other
{
    public class Rassadiran : IEpsgCoordinateSystem
    {
        public string Name => "Rassadiran";
        public string Units => "Unspecified";
public long Srid => 4153;

        public string OgcWkt =>
            "GEOGCS[Rassadiran,DATUM[Rassadiran,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-133.63,-157.5,-158.62,0,0,0,0],AUTHORITY[EPSG,6153]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4153]]";

        public string EsriWkt =>
            "GEOGCS[Rassadiran,DATUM[Rassadiran,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-133.63,-157.5,-158.62,0,0,0,0],AUTHORITY[EPSG,6153]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4153]]";
    }
}