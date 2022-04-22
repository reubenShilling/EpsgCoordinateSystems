using EpsgCoordinateSystems.Other;

namespace EpsgCoordinateSystems.Nad83Nsrs07UsFt{public class NAD83_NSRS2007_New_York_Long_Island_ftUS : IEpsgCoordinateSystem{public string Name => "NAD83(NSRS2007) / New York Long Island (ftUS)";public string Units => "US feet";
public long Srid => 3628;public string OgcWkt => "PROJCS[NAD83(NSRS2007) / New York Long Island (ftUS),GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,41.03333333333333],PARAMETER[standard_parallel_2,40.66666666666666],PARAMETER[latitude_of_origin,40.16666666666666],PARAMETER[central_meridian,-74],PARAMETER[false_easting,984250.0000000002],PARAMETER[false_northing,0],AUTHORITY[EPSG,3628],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83(NSRS2007) / New York Long Island (ftUS),GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,41.03333333333333],PARAMETER[standard_parallel_2,40.66666666666666],PARAMETER[latitude_of_origin,40.16666666666666],PARAMETER[central_meridian,-74],PARAMETER[false_easting,984250.0000000002],PARAMETER[false_northing,0],AUTHORITY[EPSG,3628],AXIS[X,EAST],AXIS[Y,NORTH]]";}}