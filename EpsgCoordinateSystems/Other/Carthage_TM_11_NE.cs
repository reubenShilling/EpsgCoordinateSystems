namespace EpsgCoordinateSystems.Other
{
    public class Carthage_TM_11_NE : IEpsgCoordinateSystem
    {
        public string Name => "Carthage / TM 11 NE";
        public string Units => "Unspecified";
public long Srid => 2088;

        public string OgcWkt =>
            "PROJCS[Carthage / TM 11 NE,GEOGCS[Carthage,DATUM[Carthage,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6223]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4223]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,11],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2088],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Carthage / TM 11 NE,GEOGCS[Carthage,DATUM[Carthage,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6223]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4223]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,11],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2088],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}