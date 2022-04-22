using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class Afgooye_deg : IEpsgCoordinateSystem{private const int _srid = 62056405; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Afgooye (deg)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[Afgooye (deg),DATUM[Afgooye,SPHEROID[Krassowsky 1940,6378245.0,298.3,AUTHORITY[EPSG,7024]],TOWGS84[-43.0,-163.0,45.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6205]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,62056405]]";public string EsriWkt => "GEOGCS[Afgooye (deg),DATUM[D_Afgooye,SPHEROID[Krassowsky_1940,6378245.0,298.3]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}