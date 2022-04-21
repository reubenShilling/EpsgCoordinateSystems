using EpsgCoordinateSystems.Other;

namespace EpsgCoordinateSystems.Nad83UsFt{public class NAD83_BLM_14N_ftUS : IEpsgCoordinateSystem{public string Name => "NAD83 / BLM 14N (ftUS)";public long Srid => 32164;public string OgcWkt => "PROJCS[NAD83 / BLM 14N (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-99],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,1640416.67],PARAMETER[false_northing,0],AUTHORITY[EPSG,32164],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83 / BLM 14N (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-99],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,1640416.67],PARAMETER[false_northing,0],AUTHORITY[EPSG,32164],AXIS[X,EAST],AXIS[Y,NORTH]]";}}