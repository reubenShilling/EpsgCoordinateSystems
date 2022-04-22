using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class Fahud_deg : IEpsgCoordinateSystem{private const int _srid = 62326405; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Fahud (deg)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[Fahud (deg),DATUM[Fahud,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-346.0,-1.0,224.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6232]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,62326405]]";public string EsriWkt => "GEOGCS[Fahud (deg),DATUM[D_Fahud,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}