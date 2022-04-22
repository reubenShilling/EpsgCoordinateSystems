namespace EpsgCoordinateSystems.Other
{
    public class NAD83_CSRS_MTM_zone_10 : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(CSRS) / MTM zone 10";
        public string Units => "Unspecified";
public long Srid => 2952;

        public string OgcWkt =>
            "PROJCS[NAD83(CSRS) / MTM zone 10,GEOGCS[NAD83(CSRS),DATUM[NAD83_Canadian_Spatial_Reference_System,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6140]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4617]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-79.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,304800],PARAMETER[false_northing,0],AUTHORITY[EPSG,2952],AXIS[E(X),EAST],AXIS[N(Y),NORTH]]";

        public string EsriWkt => "PROJCS[NAD83(CSRS) / MTM zone 10,GEOGCS[NAD83(CSRS),DATUM[D_North_American_1983_CSRS98,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-79.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,304800],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}