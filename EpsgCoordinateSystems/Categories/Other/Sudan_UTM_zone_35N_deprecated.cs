using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class Sudan_UTM_zone_35N_deprecated : IEpsgCoordinateSystem{private const int _srid = 29635; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Sudan / UTM zone 35N (deprecated)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "PROJCS[Sudan / UTM zone 35N (deprecated),GEOGCS[Sudan,DATUM[Sudan,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6296]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4296]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,27],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,29635],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";public string EsriWkt => "PROJCS[Sudan / UTM zone 35N (deprecated),GEOGCS[Sudan,DATUM[D_Sudan,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,27],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";}}