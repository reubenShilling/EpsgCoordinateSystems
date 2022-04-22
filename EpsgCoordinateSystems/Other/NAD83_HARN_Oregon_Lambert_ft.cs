namespace EpsgCoordinateSystems.Other{public class NAD83_HARN_Oregon_Lambert_ft : IEpsgCoordinateSystem{public string Name => "NAD83(HARN) / Oregon Lambert (ft)";public string Units => "Unspecified";
public long Srid => 2994;public string OgcWkt => "PROJCS[NAD83(HARN) / Oregon Lambert (ft),GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[foot,0.3048,AUTHORITY[EPSG,9002]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,43],PARAMETER[standard_parallel_2,45.5],PARAMETER[latitude_of_origin,41.75],PARAMETER[central_meridian,-120.5],PARAMETER[false_easting,1312335.958],PARAMETER[false_northing,0],AUTHORITY[EPSG,2994],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83(HARN) / Oregon Lambert (ft),GEOGCS[NAD83(HARN),DATUM[D_North_American_1983_HARN,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,43],PARAMETER[standard_parallel_2,45.5],PARAMETER[latitude_of_origin,41.75],PARAMETER[central_meridian,-120.5],PARAMETER[false_easting,1312335.958],PARAMETER[false_northing,0],UNIT[Foot,0.3048]]";}}