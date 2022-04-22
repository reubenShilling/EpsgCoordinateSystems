using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class Monte_Mario_Rome_Italy_zone_2_deprecated : IEpsgCoordinateSystem{private const int _srid = 26592; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Monte Mario (Rome) / Italy zone 2 (deprecated)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "PROJCS[Monte Mario (Rome) / Italy zone 2 (deprecated),GEOGCS[Monte Mario (Rome),DATUM[Monte_Mario_Rome,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6806]],PRIMEM[Rome,12.45233333333333,AUTHORITY[EPSG,8906]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4806]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,2.54766666666666],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,2520000],PARAMETER[false_northing,0],AUTHORITY[EPSG,26592],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[Monte Mario (Rome) / Italy zone 2 (deprecated),GEOGCS[Monte Mario (Rome),DATUM[D_Monte_Mario,SPHEROID[International_1924,6378388,297]],PRIMEM[Rome,12.45233333333333],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,2.54766666666666],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,2520000],PARAMETER[false_northing,0],UNIT[Meter,1]]";}}