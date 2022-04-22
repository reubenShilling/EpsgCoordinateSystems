namespace EpsgCoordinateSystems.Other
{
    public class Hong_Kong_1963_Grid_System : IEpsgCoordinateSystem
    {
        public string Name => "Hong Kong 1963 Grid System";
        public string Units => "Unspecified";
public long Srid => 3407;

        public string OgcWkt =>
            "PROJCS[Hong Kong 1963 Grid System,GEOGCS[Hong Kong 1963,DATUM[Hong_Kong_1963,SPHEROID[Clarke 1858,6378293.645208759,294.2606763692654,AUTHORITY[EPSG,7007]],AUTHORITY[EPSG,6738]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4738]],UNIT[Clarke's foot,0.3047972654,AUTHORITY[EPSG,9005]],PROJECTION[Cassini_Soldner],PARAMETER[latitude_of_origin,22.31213333333334],PARAMETER[central_meridian,114.1785555555556],PARAMETER[false_easting,132033.92],PARAMETER[false_northing,62565.96],AUTHORITY[EPSG,3407],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Hong Kong 1963 Grid System,GEOGCS[Hong Kong 1963,DATUM[D_Hong_Kong_1963,SPHEROID[Clarke_1858,6378293.645208759,294.2606763692654]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Cassini],PARAMETER[latitude_of_origin,22.31213333333334],PARAMETER[central_meridian,114.1785555555556],PARAMETER[false_easting,132033.92],PARAMETER[false_northing,62565.96],UNIT[Clarke's foot,0.3047972654]]";
    }
}