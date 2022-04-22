namespace EpsgCoordinateSystems.Other
{
    public class WGS_84_SCAR_IMW_ST33_36 : IEpsgCoordinateSystem
    {
        public string Name => "WGS 84 / SCAR IMW ST33-36";
        public string Units => "Unspecified";
public long Srid => 3268;

        public string OgcWkt =>
            "PROJCS[WGS 84 / SCAR IMW ST33-36,GEOGCS[WGS 84,DATUM[WGS_1984,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4326]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,-76.66666666666667],PARAMETER[standard_parallel_2,-79.33333333333333],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,24],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3268],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[WGS 84 / SCAR IMW ST33-36,GEOGCS[WGS 84,DATUM[WGS_1984,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4326]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,-76.66666666666667],PARAMETER[standard_parallel_2,-79.33333333333333],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,24],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3268],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}