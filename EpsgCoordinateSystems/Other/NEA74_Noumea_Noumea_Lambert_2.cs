namespace EpsgCoordinateSystems.Other
{
    public class NEA74_Noumea_Noumea_Lambert_2 : IEpsgCoordinateSystem
    {
        public string Name => "NEA74 Noumea / Noumea Lambert 2";
        public string Units => "Unspecified";
public long Srid => 3166;

        public string OgcWkt =>
            "PROJCS[NEA74 Noumea / Noumea Lambert 2,GEOGCS[NEA74 Noumea,DATUM[NEA74_Noumea,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6644]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4644]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,-22.24472222222222],PARAMETER[standard_parallel_2,-22.29472222222222],PARAMETER[latitude_of_origin,-22.26972222222222],PARAMETER[central_meridian,166.4425],PARAMETER[false_easting,8.313],PARAMETER[false_northing,-2.354],AUTHORITY[EPSG,3166],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NEA74 Noumea / Noumea Lambert 2,GEOGCS[NEA74 Noumea,DATUM[D_NEA74_Noumea,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,-22.24472222222222],PARAMETER[standard_parallel_2,-22.29472222222222],PARAMETER[latitude_of_origin,-22.26972222222222],PARAMETER[central_meridian,166.4425],PARAMETER[false_easting,8.313],PARAMETER[false_northing,-2.354],UNIT[Meter,1]]";
    }
}