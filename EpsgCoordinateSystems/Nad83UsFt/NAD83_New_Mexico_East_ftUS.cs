using EpsgCoordinateSystems.Other;

namespace EpsgCoordinateSystems.Nad83UsFt{public class NAD83_New_Mexico_East_ftUS : IEpsgCoordinateSystem{public string Name => "New Mexico East";public string Units => "US feet";
public long Srid => 2257;public string OgcWkt => "PROJCS[NAD83 / New Mexico East (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,31],PARAMETER[central_meridian,-104.3333333333333],PARAMETER[scale_factor,0.999909091],PARAMETER[false_easting,541337.5],PARAMETER[false_northing,0],AUTHORITY[EPSG,2257],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83 / New Mexico East (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,31],PARAMETER[central_meridian,-104.3333333333333],PARAMETER[scale_factor,0.999909091],PARAMETER[false_easting,541337.5],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";}}