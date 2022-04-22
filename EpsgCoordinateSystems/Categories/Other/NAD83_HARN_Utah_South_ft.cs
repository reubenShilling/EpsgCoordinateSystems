namespace EpsgCoordinateSystems.Categories.Other{public class NAD83_HARN_Utah_South_ft : IEpsgCoordinateSystem{public string Name => "NAD83(HARN) / Utah South (ft)";public string Units => "Unspecified";
public int Srid => 2923;public string OgcWkt => "PROJCS[NAD83(HARN) / Utah South (ft),GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[foot,0.3048,AUTHORITY[EPSG,9002]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,38.35],PARAMETER[standard_parallel_2,37.21666666666667],PARAMETER[latitude_of_origin,36.66666666666666],PARAMETER[central_meridian,-111.5],PARAMETER[false_easting,1640419.948],PARAMETER[false_northing,9842519.685],AUTHORITY[EPSG,2923],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83(HARN) / Utah South (ft),GEOGCS[NAD83(HARN),DATUM[D_North_American_1983_HARN,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,38.35],PARAMETER[standard_parallel_2,37.21666666666667],PARAMETER[latitude_of_origin,36.66666666666666],PARAMETER[central_meridian,-111.5],PARAMETER[false_easting,1640419.948],PARAMETER[false_northing,9842519.685],UNIT[Foot,0.3048]]";}}