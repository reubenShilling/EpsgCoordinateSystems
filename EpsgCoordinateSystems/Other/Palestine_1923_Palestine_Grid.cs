namespace EpsgCoordinateSystems.Other
{
    public class Palestine_1923_Palestine_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Palestine 1923 / Palestine Grid";
        public string Units => "Unspecified";
public long Srid => 28191;

        public string OgcWkt =>
            "PROJCS[Palestine 1923 / Palestine Grid,GEOGCS[Palestine 1923,DATUM[Palestine_1923,SPHEROID[Clarke 1880 (Benoit),6378300.789,293.4663155389811,AUTHORITY[EPSG,7010]],TOWGS84[-275.722,94.7824,340.894,-8.001,-4.42,-11.821,1],AUTHORITY[EPSG,6281]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4281]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Cassini_Soldner],PARAMETER[latitude_of_origin,31.73409694444445],PARAMETER[central_meridian,35.21208055555556],PARAMETER[false_easting,170251.555],PARAMETER[false_northing,126867.909],AUTHORITY[EPSG,28191],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Palestine 1923 / Palestine Grid,GEOGCS[Palestine 1923,DATUM[Palestine_1923,SPHEROID[Clarke 1880 (Benoit),6378300.789,293.4663155389811,AUTHORITY[EPSG,7010]],TOWGS84[-275.722,94.7824,340.894,-8.001,-4.42,-11.821,1],AUTHORITY[EPSG,6281]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4281]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Cassini_Soldner],PARAMETER[latitude_of_origin,31.73409694444445],PARAMETER[central_meridian,35.21208055555556],PARAMETER[false_easting,170251.555],PARAMETER[false_northing,126867.909],AUTHORITY[EPSG,28191],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}