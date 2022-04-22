namespace EpsgCoordinateSystems.Other
{
    public class Lome_UTM_zone_31N : IEpsgCoordinateSystem
    {
        public string Name => "Lome / UTM zone 31N";
        public string Units => "Unspecified";
public long Srid => 25231;

        public string OgcWkt =>
            "PROJCS[Lome / UTM zone 31N,GEOGCS[Lome,DATUM[Lome,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6252]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4252]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,3],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,25231],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Lome / UTM zone 31N,GEOGCS[Lome,DATUM[Lome,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6252]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4252]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,3],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,25231],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}