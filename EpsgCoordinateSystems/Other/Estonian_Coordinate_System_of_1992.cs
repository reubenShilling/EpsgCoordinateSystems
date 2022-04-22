namespace EpsgCoordinateSystems.Other
{
    public class Estonian_Coordinate_System_of_1992 : IEpsgCoordinateSystem
    {
        public string Name => "Estonian Coordinate System of 1992";
        public string Units => "Unspecified";
public long Srid => 3300;

        public string OgcWkt =>
            "PROJCS[Estonian Coordinate System of 1992,GEOGCS[EST92,DATUM[Estonia_1992,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.055,-0.541,-0.185,0.0183,-0.0003,-0.007,-0.014],AUTHORITY[EPSG,6133]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4133]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,59.33333333333334],PARAMETER[standard_parallel_2,58],PARAMETER[latitude_of_origin,57.51755393055556],PARAMETER[central_meridian,24],PARAMETER[false_easting,500000],PARAMETER[false_northing,6375000],AUTHORITY[EPSG,3300],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Estonian Coordinate System of 1992,GEOGCS[EST92,DATUM[Estonia_1992,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.055,-0.541,-0.185,0.0183,-0.0003,-0.007,-0.014],AUTHORITY[EPSG,6133]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4133]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,59.33333333333334],PARAMETER[standard_parallel_2,58],PARAMETER[latitude_of_origin,57.51755393055556],PARAMETER[central_meridian,24],PARAMETER[false_easting,500000],PARAMETER[false_northing,6375000],AUTHORITY[EPSG,3300],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}