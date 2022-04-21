namespace EpsgCoordinateSystems.Other
{
    public class Hjorsey_1955 : IEpsgCoordinateSystem
    {
        public string Name => "Hjorsey 1955";
        public long Srid => 4658;

        public string OgcWkt =>
            "GEOGCS[Hjorsey 1955,DATUM[Hjorsey_1955,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-73,46,-86,0,0,0,0],AUTHORITY[EPSG,6658]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4658]]";

        public string EsriWkt =>
            "GEOGCS[Hjorsey 1955,DATUM[Hjorsey_1955,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-73,46,-86,0,0,0,0],AUTHORITY[EPSG,6658]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4658]]";
    }
}