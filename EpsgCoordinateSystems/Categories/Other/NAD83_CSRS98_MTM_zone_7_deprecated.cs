using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class NAD83_CSRS98_MTM_zone_7_deprecated : IEpsgCoordinateSystem{private const int _srid = 2144; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "NAD83(CSRS98) / MTM zone 7 (deprecated)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "PROJCS[NAD83(CSRS98) / MTM zone 7 (deprecated),GEOGCS[NAD83(CSRS98),DATUM[NAD83_Canadian_Spatial_Reference_System,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6140]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4140]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-70.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,304800],PARAMETER[false_northing,0],AUTHORITY[EPSG,2144],AXIS[E(X),EAST],AXIS[N(Y),NORTH]]";public string EsriWkt => "PROJCS[NAD83(CSRS98) / MTM zone 7 (deprecated),GEOGCS[NAD83(CSRS98),DATUM[D_North_American_1983_CSRS98,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-70.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,304800],PARAMETER[false_northing,0],UNIT[Meter,1]]";}}