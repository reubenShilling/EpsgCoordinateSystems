using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Nad83HarnUsFt{public class NAD83_HARN_Texas_Central_ftUS : IEpsgCoordinateSystem{private const int _srid = 2918; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "NAD83(HARN) / Texas Central (ftUS)";public string Units => "US feet";
public int Srid => _srid;public string OgcWkt => "PROJCS[NAD83(HARN) / Texas Central (ftUS),GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,31.88333333333333],PARAMETER[standard_parallel_2,30.11666666666667],PARAMETER[latitude_of_origin,29.66666666666667],PARAMETER[central_meridian,-100.3333333333333],PARAMETER[false_easting,2296583.333],PARAMETER[false_northing,9842500.000000002],AUTHORITY[EPSG,2918],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83(HARN) / Texas Central (ftUS),GEOGCS[NAD83(HARN),DATUM[D_North_American_1983_HARN,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,31.88333333333333],PARAMETER[standard_parallel_2,30.11666666666667],PARAMETER[latitude_of_origin,29.66666666666667],PARAMETER[central_meridian,-100.3333333333333],PARAMETER[false_easting,2296583.333],PARAMETER[false_northing,9842500.000000002],UNIT[Foot_US,0.30480060960121924]]";}}