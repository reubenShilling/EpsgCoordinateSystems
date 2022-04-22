using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class Combani_1950_deg : IEpsgCoordinateSystem{private const int _srid = 66326405; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Combani 1950 (deg)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[Combani 1950 (deg),DATUM[Combani 1950,SPHEROID[International 1924,6378388.0,297.0,AUTHORITY[EPSG,7022]],TOWGS84[-382.0,-59.0,-262.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6632]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,66326405]]";public string EsriWkt => "GEOGCS[Combani 1950 (deg),DATUM[D_Combani 1950,SPHEROID[International_1924,6378388.0,297.0]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}