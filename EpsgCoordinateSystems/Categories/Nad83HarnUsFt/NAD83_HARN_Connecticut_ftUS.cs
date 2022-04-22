namespace EpsgCoordinateSystems.Categories.Nad83HarnUsFt{public class NAD83_HARN_Connecticut_ftUS : IEpsgCoordinateSystem{public string Name => "NAD83(HARN) / Connecticut (ftUS)";public string Units => "US feet";
public int Srid => 2879;public string OgcWkt => "PROJCS[NAD83(HARN) / Connecticut (ftUS),GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,41.86666666666667],PARAMETER[standard_parallel_2,41.2],PARAMETER[latitude_of_origin,40.83333333333334],PARAMETER[central_meridian,-72.75],PARAMETER[false_easting,1000000],PARAMETER[false_northing,500000],AUTHORITY[EPSG,2879],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83(HARN) / Connecticut (ftUS),GEOGCS[NAD83(HARN),DATUM[D_North_American_1983_HARN,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,41.86666666666667],PARAMETER[standard_parallel_2,41.2],PARAMETER[latitude_of_origin,40.83333333333334],PARAMETER[central_meridian,-72.75],PARAMETER[false_easting,1000000],PARAMETER[false_northing,500000],UNIT[Foot_US,0.30480060960121924]]";}}