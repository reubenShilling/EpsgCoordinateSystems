using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class NAD83_Arizona_East_ft : IEpsgCoordinateSystem{private const int _srid = 2222; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "NAD83 / Arizona East (ft)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "PROJCS[NAD83 / Arizona East (ft),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[foot,0.3048,AUTHORITY[EPSG,9002]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,31],PARAMETER[central_meridian,-110.1666666666667],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,700000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2222],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83 / Arizona East (ft),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,31],PARAMETER[central_meridian,-110.1666666666667],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,700000],PARAMETER[false_northing,0],UNIT[Foot,0.3048]]";}}