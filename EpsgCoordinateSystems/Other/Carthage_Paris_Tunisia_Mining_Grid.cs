namespace EpsgCoordinateSystems.Other
{
    public class Carthage_Paris_Tunisia_Mining_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Carthage (Paris) / Tunisia Mining Grid";
        public string Units => "Unspecified";
public long Srid => 22300;

        public string OgcWkt =>
            "PROJCS[Carthage (Paris) / Tunisia Mining Grid,GEOGCS[Carthage (Paris),DATUM[Carthage_Paris,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6816]],PRIMEM[Paris,2.33722917,AUTHORITY[EPSG,8903]],UNIT[grad,0.01570796326794897,AUTHORITY[EPSG,9105]],AUTHORITY[EPSG,4816]],UNIT[kilometre,1000,AUTHORITY[EPSG,9036]],PROJECTION[Tunisia_Mining_Grid],PARAMETER[latitude_of_origin,38.81973],PARAMETER[central_meridian,7.83445],PARAMETER[false_easting,270],PARAMETER[false_northing,582],AUTHORITY[EPSG,22300],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Carthage (Paris) / Tunisia Mining Grid,GEOGCS[Carthage (Paris),DATUM[Carthage_Paris,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6816]],PRIMEM[Paris,2.33722917,AUTHORITY[EPSG,8903]],UNIT[grad,0.01570796326794897,AUTHORITY[EPSG,9105]],AUTHORITY[EPSG,4816]],UNIT[kilometre,1000,AUTHORITY[EPSG,9036]],PROJECTION[Tunisia_Mining_Grid],PARAMETER[latitude_of_origin,38.81973],PARAMETER[central_meridian,7.83445],PARAMETER[false_easting,270],PARAMETER[false_northing,582],AUTHORITY[EPSG,22300],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}