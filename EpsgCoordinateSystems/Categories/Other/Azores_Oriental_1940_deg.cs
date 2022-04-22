using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class Azores_Oriental_1940_deg : IEpsgCoordinateSystem{private const int _srid = 61846405; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Azores Oriental 1940 (deg)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[Azores Oriental 1940 (deg),DATUM[Azores Oriental Islands 1940,SPHEROID[International 1924,6378388.0,297.0,AUTHORITY[EPSG,7022]],TOWGS84[-203.0,141.0,53.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6184]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,61846405]]";public string EsriWkt => "GEOGCS[Azores Oriental 1940 (deg),DATUM[D_Azores Oriental Islands 1940,SPHEROID[International_1924,6378388.0,297.0]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}