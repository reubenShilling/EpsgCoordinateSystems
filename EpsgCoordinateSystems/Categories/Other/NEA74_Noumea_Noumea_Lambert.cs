namespace EpsgCoordinateSystems.Categories.Other
{
    public class NEA74_Noumea_Noumea_Lambert : IEpsgCoordinateSystem
    {
        public string Name => "NEA74 Noumea / Noumea Lambert";
        public string Units => "Unspecified";
public int Srid => 3165;

        public string OgcWkt =>
            "PROJCS[NEA74 Noumea / Noumea Lambert,GEOGCS[NEA74 Noumea,DATUM[NEA74_Noumea,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6644]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4644]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,-22.24469175],PARAMETER[standard_parallel_2,-22.29469175],PARAMETER[latitude_of_origin,-22.26969175],PARAMETER[central_meridian,166.44242575],PARAMETER[false_easting,0.66],PARAMETER[false_northing,1.02],AUTHORITY[EPSG,3165],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NEA74 Noumea / Noumea Lambert,GEOGCS[NEA74 Noumea,DATUM[D_NEA74_Noumea,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,-22.24469175],PARAMETER[standard_parallel_2,-22.29469175],PARAMETER[latitude_of_origin,-22.26969175],PARAMETER[central_meridian,166.44242575],PARAMETER[false_easting,0.66],PARAMETER[false_northing,1.02],UNIT[Meter,1]]";
    }
}