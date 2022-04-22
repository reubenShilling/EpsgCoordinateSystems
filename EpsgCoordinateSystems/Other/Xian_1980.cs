namespace EpsgCoordinateSystems.Other
{
    public class Xian_1980 : IEpsgCoordinateSystem
    {
        public string Name => "Xian 1980";
        public string Units => "Unspecified";
public long Srid => 4610;

        public string OgcWkt =>
            "GEOGCS[Xian 1980,DATUM[Xian_1980,SPHEROID[Xian 1980,6378140,298.257,AUTHORITY[EPSG,7049]],AUTHORITY[EPSG,6610]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4610]]";

        public string EsriWkt =>
            "GEOGCS[Xian 1980,DATUM[Xian_1980,SPHEROID[Xian 1980,6378140,298.257,AUTHORITY[EPSG,7049]],AUTHORITY[EPSG,6610]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4610]]";
    }
}