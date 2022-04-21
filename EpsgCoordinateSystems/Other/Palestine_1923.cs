namespace EpsgCoordinateSystems.Other
{
    public class Palestine_1923 : IEpsgCoordinateSystem
    {
        public string Name => "Palestine 1923";
        public long Srid => 4281;

        public string OgcWkt =>
            "GEOGCS[Palestine 1923,DATUM[Palestine_1923,SPHEROID[Clarke 1880 (Benoit),6378300.789,293.4663155389811,AUTHORITY[EPSG,7010]],TOWGS84[-275.722,94.7824,340.894,-8.001,-4.42,-11.821,1],AUTHORITY[EPSG,6281]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4281]]";

        public string EsriWkt =>
            "GEOGCS[Palestine 1923,DATUM[Palestine_1923,SPHEROID[Clarke 1880 (Benoit),6378300.789,293.4663155389811,AUTHORITY[EPSG,7010]],TOWGS84[-275.722,94.7824,340.894,-8.001,-4.42,-11.821,1],AUTHORITY[EPSG,6281]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4281]]";
    }
}