using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class Moznet_deg : IEpsgCoordinateSystem{private const int _srid = 61306405; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Moznet (deg)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[Moznet (deg),DATUM[Moznet (ITRF94),SPHEROID[WGS 84,6378137.0,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0.0,0.0,0.0,-0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6130]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,61306405]]";public string EsriWkt => "GEOGCS[Moznet (deg),DATUM[D_Moznet (ITRF94),SPHEROID[WGS_1984,6378137.0,298.257223563]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}