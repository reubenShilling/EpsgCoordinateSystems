namespace EpsgCoordinateSystems.Other
{
    public class Cape_UTM_zone_35S : IEpsgCoordinateSystem
    {
        public string Name => "Cape / UTM zone 35S";
        public string Units => "Unspecified";
public long Srid => 22235;

        public string OgcWkt =>
            "PROJCS[Cape / UTM zone 35S,GEOGCS[Cape,DATUM[Cape,SPHEROID[Clarke 1880 (Arc),6378249.145,293.4663077,AUTHORITY[EPSG,7013]],AUTHORITY[EPSG,6222]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4222]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,27],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,22235],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Cape / UTM zone 35S,GEOGCS[Cape,DATUM[D_Cape,SPHEROID[Clarke_1880_Arc,6378249.145,293.4663077]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,27],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}