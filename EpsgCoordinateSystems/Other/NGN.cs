namespace EpsgCoordinateSystems.Other
{
    public class NGN : IEpsgCoordinateSystem
    {
        public string Name => "NGN";
        public long Srid => 4318;

        public string OgcWkt =>
            "GEOGCS[NGN,DATUM[National_Geodetic_Network,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[-3.2,-5.7,2.8,0,0,0,0],AUTHORITY[EPSG,6318]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4318]]";

        public string EsriWkt =>
            "GEOGCS[NGN,DATUM[National_Geodetic_Network,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[-3.2,-5.7,2.8,0,0,0,0],AUTHORITY[EPSG,6318]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4318]]";
    }
}