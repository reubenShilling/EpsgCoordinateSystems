using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Nad83Nsrs07UsFt{public class NAD83_NSRS2007_California_zone_5_ftUS : IEpsgCoordinateSystem{private const int _srid = 3498; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "NAD83(NSRS2007) / California zone 5 (ftUS)";public string Units => "US feet";
public int Srid => _srid;public string OgcWkt => "PROJCS[NAD83(NSRS2007) / California zone 5 (ftUS),GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,35.46666666666667],PARAMETER[standard_parallel_2,34.03333333333333],PARAMETER[latitude_of_origin,33.5],PARAMETER[central_meridian,-118],PARAMETER[false_easting,6561666.667],PARAMETER[false_northing,1640416.667],AUTHORITY[EPSG,3498],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83(NSRS2007) / California zone 5 (ftUS),GEOGCS[NAD83(NSRS2007),DATUM[D_,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,35.46666666666667],PARAMETER[standard_parallel_2,34.03333333333333],PARAMETER[latitude_of_origin,33.5],PARAMETER[central_meridian,-118],PARAMETER[false_easting,6561666.667],PARAMETER[false_northing,1640416.667],UNIT[Foot_US,0.30480060960121924]]";}}