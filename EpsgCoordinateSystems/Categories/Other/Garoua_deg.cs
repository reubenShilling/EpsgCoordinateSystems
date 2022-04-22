using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class Garoua_deg : IEpsgCoordinateSystem{private const int _srid = 61976405; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Garoua (deg)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[Garoua (deg),DATUM[Garoua,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6197]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,61976405]]";public string EsriWkt => "GEOGCS[Garoua (deg),DATUM[D_,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}