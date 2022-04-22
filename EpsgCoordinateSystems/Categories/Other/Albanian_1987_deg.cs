using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class Albanian_1987_deg : IEpsgCoordinateSystem{private const int _srid = 61916405; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Albanian 1987 (deg)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[Albanian 1987 (deg),DATUM[Albanian 1987,SPHEROID[Krassowsky 1940,6378245.0,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6191]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,61916405]]";public string EsriWkt => "GEOGCS[Albanian 1987 (deg),DATUM[D_Albanian 1987,SPHEROID[Krassowsky_1940,6378245.0,298.3]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}