using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class REGVEN_deg : IEpsgCoordinateSystem{private const int _srid = 61896405; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "REGVEN (deg)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[REGVEN (deg),DATUM[Red Geodesica Venezolana,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6189]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,61896405]]";public string EsriWkt => "GEOGCS[REGVEN (deg),DATUM[D_Red Geodesica Venezolana,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}