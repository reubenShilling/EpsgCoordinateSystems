namespace EpsgCoordinateSystems.Other
{
    public class WGS_84_SCAR_IMW_SP21_22 : IEpsgCoordinateSystem
    {
        public string Name => "WGS 84 / SCAR IMW SP21-22";
        public string Units => "Unspecified";
public long Srid => 3205;

        public string OgcWkt =>
            "PROJCS[WGS 84 / SCAR IMW SP21-22,GEOGCS[WGS 84,DATUM[WGS_1984,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4326]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,-60.66666666666666],PARAMETER[standard_parallel_2,-63.33333333333334],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,-54],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3205],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[WGS 84 / SCAR IMW SP21-22,GEOGCS[WGS 84,DATUM[WGS_1984,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4326]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,-60.66666666666666],PARAMETER[standard_parallel_2,-63.33333333333334],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,-54],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3205],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}