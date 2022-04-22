using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class St_Lucia_1955_deg : IEpsgCoordinateSystem{private const int _srid = 66066405; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "St. Lucia 1955 (deg)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[St. Lucia 1955 (deg),DATUM[St. Lucia 1955,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-149.0,128.0,296.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6606]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,66066405]]";public string EsriWkt => "GEOGCS[St. Lucia 1955 (deg),DATUM[D_St. Lucia 1955,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}