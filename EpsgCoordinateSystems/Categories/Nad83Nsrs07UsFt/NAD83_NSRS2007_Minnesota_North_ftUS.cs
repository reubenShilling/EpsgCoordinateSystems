using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Nad83Nsrs07UsFt{public class NAD83_NSRS2007_Minnesota_North_ftUS : IEpsgCoordinateSystem{private const int _srid = 26865; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "NAD83(NSRS2007) / Minnesota North (ftUS)";public string Units => "US feet";
public int Srid => _srid;public string OgcWkt => "PROJCS[NAD83(NSRS2007) / Minnesota North (ftUS),GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,48.63333333333333],PARAMETER[standard_parallel_2,47.03333333333333],PARAMETER[latitude_of_origin,46.5],PARAMETER[central_meridian,-93.1],PARAMETER[false_easting,2624666.6667],PARAMETER[false_northing,328083.3333],AUTHORITY[EPSG,26865],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83(NSRS2007) / Minnesota North (ftUS),GEOGCS[NAD83(NSRS2007),DATUM[D_,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,48.63333333333333],PARAMETER[standard_parallel_2,47.03333333333333],PARAMETER[latitude_of_origin,46.5],PARAMETER[central_meridian,-93.1],PARAMETER[false_easting,2624666.6667],PARAMETER[false_northing,328083.3333],UNIT[Foot_US,0.30480060960121924]]";}}