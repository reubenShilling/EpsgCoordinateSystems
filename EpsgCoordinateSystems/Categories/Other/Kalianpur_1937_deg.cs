using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class Kalianpur_1937_deg : IEpsgCoordinateSystem{private const int _srid = 61446405; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Kalianpur 1937 (deg)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[Kalianpur 1937 (deg),DATUM[Kalianpur 1937,SPHEROID[Everest 1830 (1937 Adjustment),6377276.345,300.8017,AUTHORITY[EPSG,7015]],TOWGS84[214.0,804.0,268.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6144]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,61446405]]";public string EsriWkt => "GEOGCS[Kalianpur 1937 (deg),DATUM[D_Kalianpur 1937,SPHEROID[Everest_1830_1937_Adjustment,6377276.345,300.8017]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}