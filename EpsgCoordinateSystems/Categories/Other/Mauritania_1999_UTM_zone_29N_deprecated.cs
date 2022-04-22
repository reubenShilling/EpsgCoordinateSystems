using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class Mauritania_1999_UTM_zone_29N_deprecated : IEpsgCoordinateSystem{private const int _srid = 3104; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Mauritania 1999 / UTM zone 29N (deprecated)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "PROJCS[Mauritania 1999 / UTM zone 29N (deprecated),GEOGCS[Mauritania 1999,DATUM[Mauritania_1999,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6681]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4681]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3104],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";public string EsriWkt => "PROJCS[Mauritania 1999 / UTM zone 29N (deprecated),GEOGCS[Mauritania 1999,DATUM[D_,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";}}