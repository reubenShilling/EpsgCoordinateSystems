using EpsgCoordinateSystems.Other;

namespace EpsgCoordinateSystems.Nad83Nsrs07UsFt{public class NAD83_NSRS2007_California_zone_4_ftUS : IEpsgCoordinateSystem{public string Name => "NAD83(NSRS2007) / California zone 4 (ftUS)";public string Units => "US feet";
public long Srid => 3496;public string OgcWkt => "PROJCS[NAD83(NSRS2007) / California zone 4 (ftUS),GEOGCS[NAD83(NSRS2007),DATUM[NAD83_National_Spatial_Reference_System_2007,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6759]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4759]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,37.25],PARAMETER[standard_parallel_2,36],PARAMETER[latitude_of_origin,35.33333333333334],PARAMETER[central_meridian,-119],PARAMETER[false_easting,6561666.667],PARAMETER[false_northing,1640416.667],AUTHORITY[EPSG,3496],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83(NSRS2007) / California zone 4 (ftUS),GEOGCS[NAD83(NSRS2007),DATUM[D_,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,37.25],PARAMETER[standard_parallel_2,36],PARAMETER[latitude_of_origin,35.33333333333334],PARAMETER[central_meridian,-119],PARAMETER[false_easting,6561666.667],PARAMETER[false_northing,1640416.667],UNIT[Foot_US,0.30480060960121924]]";}}