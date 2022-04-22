using EpsgCoordinateSystems.Other;

namespace EpsgCoordinateSystems.Nad83HarnUsFt{public class NAD83_HARN_Texas_South_ftUS : IEpsgCoordinateSystem{public string Name => "NAD83(HARN) / Texas South (ftUS)";public string Units => "US feet";
public long Srid => 2920;public string OgcWkt => "PROJCS[NAD83(HARN) / Texas South (ftUS),GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,27.83333333333333],PARAMETER[standard_parallel_2,26.16666666666667],PARAMETER[latitude_of_origin,25.66666666666667],PARAMETER[central_meridian,-98.5],PARAMETER[false_easting,984250.0000000002],PARAMETER[false_northing,16404166.667],AUTHORITY[EPSG,2920],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83(HARN) / Texas South (ftUS),GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,27.83333333333333],PARAMETER[standard_parallel_2,26.16666666666667],PARAMETER[latitude_of_origin,25.66666666666667],PARAMETER[central_meridian,-98.5],PARAMETER[false_easting,984250.0000000002],PARAMETER[false_northing,16404166.667],AUTHORITY[EPSG,2920],AXIS[X,EAST],AXIS[Y,NORTH]]";}}