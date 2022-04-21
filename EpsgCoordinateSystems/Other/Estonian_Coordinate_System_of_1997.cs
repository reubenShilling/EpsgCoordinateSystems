namespace EpsgCoordinateSystems.Other
{
    public class Estonian_Coordinate_System_of_1997 : IEpsgCoordinateSystem
    {
        public string Name => "Estonian Coordinate System of 1997";
        public long Srid => 3301;

        public string OgcWkt =>
            "PROJCS[Estonian Coordinate System of 1997,GEOGCS[EST97,DATUM[Estonia_1997,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6180]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4180]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,59.33333333333334],PARAMETER[standard_parallel_2,58],PARAMETER[latitude_of_origin,57.51755393055556],PARAMETER[central_meridian,24],PARAMETER[false_easting,500000],PARAMETER[false_northing,6375000],AUTHORITY[EPSG,3301],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Estonian Coordinate System of 1997,GEOGCS[EST97,DATUM[Estonia_1997,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6180]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4180]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,59.33333333333334],PARAMETER[standard_parallel_2,58],PARAMETER[latitude_of_origin,57.51755393055556],PARAMETER[central_meridian,24],PARAMETER[false_easting,500000],PARAMETER[false_northing,6375000],AUTHORITY[EPSG,3301],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}