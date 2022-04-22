using EpsgCoordinateSystems.Other;

namespace EpsgCoordinateSystems.Nad83HarnUsFt{public class NAD83_HARN_Indiana_East_ftUS : IEpsgCoordinateSystem{public string Name => "NAD83(HARN) / Indiana East (ftUS)";public string Units => "US feet";
public long Srid => 2967;public string OgcWkt => "PROJCS[NAD83(HARN) / Indiana East (ftUS),GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,37.5],PARAMETER[central_meridian,-85.66666666666667],PARAMETER[scale_factor,0.999966667],PARAMETER[false_easting,328083.333],PARAMETER[false_northing,820208.3330000002],AUTHORITY[EPSG,2967],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83(HARN) / Indiana East (ftUS),GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,37.5],PARAMETER[central_meridian,-85.66666666666667],PARAMETER[scale_factor,0.999966667],PARAMETER[false_easting,328083.333],PARAMETER[false_northing,820208.3330000002],AUTHORITY[EPSG,2967],AXIS[X,EAST],AXIS[Y,NORTH]]";}}