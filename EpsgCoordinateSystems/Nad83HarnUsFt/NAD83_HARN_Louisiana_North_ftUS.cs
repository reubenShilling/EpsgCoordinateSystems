using EpsgCoordinateSystems.Other;

namespace EpsgCoordinateSystems.Nad83HarnUsFt{public class NAD83_HARN_Louisiana_North_ftUS : IEpsgCoordinateSystem{public string Name => "NAD83(HARN) / Louisiana North (ftUS)";public string Units => "US feet";
public long Srid => 3456;public string OgcWkt => "PROJCS[NAD83(HARN) / Louisiana North (ftUS),GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,32.66666666666666],PARAMETER[standard_parallel_2,31.16666666666667],PARAMETER[latitude_of_origin,30.5],PARAMETER[central_meridian,-92.5],PARAMETER[false_easting,3280833.333300001],PARAMETER[false_northing,0],AUTHORITY[EPSG,3456],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83(HARN) / Louisiana North (ftUS),GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,32.66666666666666],PARAMETER[standard_parallel_2,31.16666666666667],PARAMETER[latitude_of_origin,30.5],PARAMETER[central_meridian,-92.5],PARAMETER[false_easting,3280833.333300001],PARAMETER[false_northing,0],AUTHORITY[EPSG,3456],AXIS[X,EAST],AXIS[Y,NORTH]]";}}