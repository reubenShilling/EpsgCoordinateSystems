using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class Arc_1950_deg : IEpsgCoordinateSystem{private const int _srid = 62096405; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Arc 1950 (deg)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[Arc 1950 (deg),DATUM[Arc 1950,SPHEROID[Clarke 1880 (Arc),6378249.145,293.4663077,AUTHORITY[EPSG,7013]],TOWGS84[-138.0,-105.0,-289.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6209]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,62096405]]";public string EsriWkt => "GEOGCS[Arc 1950 (deg),DATUM[D_Arc 1950,SPHEROID[Clarke_1880_Arc,6378249.145,293.4663077]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}