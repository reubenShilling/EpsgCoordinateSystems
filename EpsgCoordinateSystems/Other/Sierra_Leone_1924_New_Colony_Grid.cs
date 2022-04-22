namespace EpsgCoordinateSystems.Other
{
    public class Sierra_Leone_1924_New_Colony_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Sierra Leone 1924 / New Colony Grid";
        public string Units => "Unspecified";
public long Srid => 2159;

        public string OgcWkt =>
            "PROJCS[Sierra Leone 1924 / New Colony Grid,GEOGCS[Sierra Leone 1924,DATUM[Sierra_Leone_Colony_1924,SPHEROID[War Office,6378300,296,AUTHORITY[EPSG,7029]],AUTHORITY[EPSG,6174]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4174]],UNIT[Gold Coast foot,0.3047997101815088,AUTHORITY[EPSG,9094]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,6.666666666666667],PARAMETER[central_meridian,-12],PARAMETER[scale_factor,1],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2159],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Sierra Leone 1924 / New Colony Grid,GEOGCS[Sierra Leone 1924,DATUM[D_Sierra_Leone_1924,SPHEROID[War_Office,6378300,296]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,6.666666666666667],PARAMETER[central_meridian,-12],PARAMETER[scale_factor,1],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Gold Coast foot,0.3047997101815088]]";
    }
}