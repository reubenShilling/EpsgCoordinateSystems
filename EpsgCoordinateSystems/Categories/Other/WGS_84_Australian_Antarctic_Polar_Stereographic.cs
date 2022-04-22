namespace EpsgCoordinateSystems.Categories.Other
{
    public class WGS_84_Australian_Antarctic_Polar_Stereographic : IEpsgCoordinateSystem
    {
        public string Name => "WGS 84 / Australian Antarctic Polar Stereographic";
        public string Units => "Unspecified";
public int Srid => 3032;

        public string OgcWkt =>
            "PROJCS[WGS 84 / Australian Antarctic Polar Stereographic,GEOGCS[WGS 84,DATUM[WGS_1984,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4326]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Polar_Stereographic],PARAMETER[latitude_of_origin,-71],PARAMETER[central_meridian,70],PARAMETER[scale_factor,1],PARAMETER[false_easting,6000000],PARAMETER[false_northing,6000000],AUTHORITY[EPSG,3032],AXIS[Easting,UNKNOWN],AXIS[Northing,UNKNOWN]]";

        public string EsriWkt => "PROJCS[WGS 84 / Australian Antarctic Polar Stereographic,GEOGCS[GCS_WGS_1984,DATUM[D_WGS_1984,SPHEROID[WGS_1984,6378137,298.257223563]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Stereographic_South_Pole],PARAMETER[standard_parallel_1,-71],PARAMETER[central_meridian,70],PARAMETER[scale_factor,1],PARAMETER[false_easting,6000000],PARAMETER[false_northing,6000000],UNIT[Meter,1]]";
    }
}