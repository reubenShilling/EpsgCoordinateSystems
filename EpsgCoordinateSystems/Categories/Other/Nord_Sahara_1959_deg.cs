using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class Nord_Sahara_1959_deg : IEpsgCoordinateSystem{private const int _srid = 63076405; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Nord Sahara 1959 (deg)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[Nord Sahara 1959 (deg),DATUM[Nord Sahara 1959,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-169.559,-72.34,303.102,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6307]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,63076405]]";public string EsriWkt => "GEOGCS[Nord Sahara 1959 (deg),DATUM[D_Nord Sahara 1959,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}