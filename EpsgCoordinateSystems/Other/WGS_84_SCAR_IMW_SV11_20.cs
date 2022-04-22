namespace EpsgCoordinateSystems.Other
{
    public class WGS_84_SCAR_IMW_SV11_20 : IEpsgCoordinateSystem
    {
        public string Name => "WGS 84 / SCAR IMW SV11-20";
        public string Units => "Unspecified";
public long Srid => 3288;

        public string OgcWkt =>
            "PROJCS[WGS 84 / SCAR IMW SV11-20,GEOGCS[WGS 84,DATUM[WGS_1984,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4326]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Polar_Stereographic],PARAMETER[latitude_of_origin,-80.23861111111111],PARAMETER[central_meridian,-90],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3288],AXIS[Easting,UNKNOWN],AXIS[Northing,UNKNOWN]]";

        public string EsriWkt => "PROJCS[WGS 84 / SCAR IMW SV11-20,GEOGCS[GCS_WGS_1984,DATUM[D_WGS_1984,SPHEROID[WGS_1984,6378137,298.257223563]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Stereographic_South_Pole],PARAMETER[standard_parallel_1,-80.23861111111111],PARAMETER[central_meridian,-90],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}