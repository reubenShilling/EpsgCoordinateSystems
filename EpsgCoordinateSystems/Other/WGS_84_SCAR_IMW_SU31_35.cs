namespace EpsgCoordinateSystems.Other
{
    public class WGS_84_SCAR_IMW_SU31_35 : IEpsgCoordinateSystem
    {
        public string Name => "WGS 84 / SCAR IMW SU31-35";
        public string Units => "Unspecified";
public long Srid => 3281;

        public string OgcWkt =>
            "PROJCS[WGS 84 / SCAR IMW SU31-35,GEOGCS[WGS 84,DATUM[WGS_1984,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4326]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Polar_Stereographic],PARAMETER[latitude_of_origin,-80.23861111111111],PARAMETER[central_meridian,15],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3281],AXIS[Easting,UNKNOWN],AXIS[Northing,UNKNOWN]]";

        public string EsriWkt => "PROJCS[WGS 84 / SCAR IMW SU31-35,GEOGCS[GCS_WGS_1984,DATUM[D_WGS_1984,SPHEROID[WGS_1984,6378137,298.257223563]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Stereographic_South_Pole],PARAMETER[standard_parallel_1,-80.23861111111111],PARAMETER[central_meridian,15],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}