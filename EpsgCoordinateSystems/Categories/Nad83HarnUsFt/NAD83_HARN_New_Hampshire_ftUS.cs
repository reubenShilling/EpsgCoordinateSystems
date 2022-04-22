using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Nad83HarnUsFt{public class NAD83_HARN_New_Hampshire_ftUS : IEpsgCoordinateSystem{private const int _srid = 3445; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "NAD83(HARN) / New Hampshire (ftUS)";public string Units => "US feet";
public int Srid => _srid;public string OgcWkt => "PROJCS[NAD83(HARN) / New Hampshire (ftUS),GEOGCS[NAD83(HARN),DATUM[NAD83_High_Accuracy_Regional_Network,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4152]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,42.5],PARAMETER[central_meridian,-71.66666666666667],PARAMETER[scale_factor,0.999966667],PARAMETER[false_easting,984250.0000000002],PARAMETER[false_northing,0],AUTHORITY[EPSG,3445],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83(HARN) / New Hampshire (ftUS),GEOGCS[NAD83(HARN),DATUM[D_North_American_1983_HARN,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,42.5],PARAMETER[central_meridian,-71.66666666666667],PARAMETER[scale_factor,0.999966667],PARAMETER[false_easting,984250.0000000002],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";}}