using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class NAD83_CSRS_New_Brunswick_Stereo : IEpsgCoordinateSystem
    {private const int _srid = 2953; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NAD83(CSRS) / New Brunswick Stereo";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83(CSRS) / New Brunswick Stereo,GEOGCS[NAD83(CSRS),DATUM[NAD83_Canadian_Spatial_Reference_System,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6140]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4617]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Oblique_Stereographic],PARAMETER[latitude_of_origin,46.5],PARAMETER[central_meridian,-66.5],PARAMETER[scale_factor,0.999912],PARAMETER[false_easting,2500000],PARAMETER[false_northing,7500000],AUTHORITY[EPSG,2953],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83(CSRS) / New Brunswick Stereo,GEOGCS[NAD83(CSRS),DATUM[D_North_American_1983_CSRS98,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Stereographic_North_Pole],PARAMETER[standard_parallel_1,46.5],PARAMETER[central_meridian,-66.5],PARAMETER[scale_factor,0.999912],PARAMETER[false_easting,2500000],PARAMETER[false_northing,7500000],UNIT[Meter,1]]";
    }
}