namespace EpsgCoordinateSystems.Other
{
    public class WGS_84_SCAR_IMW_SR47_48 : IEpsgCoordinateSystem
    {
        public string Name => "WGS 84 / SCAR IMW SR47-48";
        public string Units => "Unspecified";
public long Srid => 3235;

        public string OgcWkt =>
            "PROJCS[WGS 84 / SCAR IMW SR47-48,GEOGCS[WGS 84,DATUM[WGS_1984,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4326]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,-68.66666666666667],PARAMETER[standard_parallel_2,-71.33333333333333],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,102],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3235],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[WGS 84 / SCAR IMW SR47-48,GEOGCS[WGS 84,DATUM[WGS_1984,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4326]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,-68.66666666666667],PARAMETER[standard_parallel_2,-71.33333333333333],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,102],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3235],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}