using EpsgCoordinateSystems.Other;

namespace EpsgCoordinateSystems.Nad83UsFt{public class NAD83_Utah_Central_ftUS : IEpsgCoordinateSystem{public string Name => "Utah Central";public string Units => "US feet";
public long Srid => 3566;public string OgcWkt => "PROJCS[NAD83 / Utah Central (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,40.65],PARAMETER[standard_parallel_2,39.01666666666667],PARAMETER[latitude_of_origin,38.33333333333334],PARAMETER[central_meridian,-111.5],PARAMETER[false_easting,1640416.6667],PARAMETER[false_northing,6561666.666700001],AUTHORITY[EPSG,3566],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83 / Utah Central (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,40.65],PARAMETER[standard_parallel_2,39.01666666666667],PARAMETER[latitude_of_origin,38.33333333333334],PARAMETER[central_meridian,-111.5],PARAMETER[false_easting,1640416.6667],PARAMETER[false_northing,6561666.666700001],AUTHORITY[EPSG,3566],AXIS[X,EAST],AXIS[Y,NORTH]]";}}