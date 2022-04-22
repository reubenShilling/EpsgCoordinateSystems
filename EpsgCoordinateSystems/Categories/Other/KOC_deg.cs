using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class KOC_deg : IEpsgCoordinateSystem{private const int _srid = 62466405; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "KOC (deg)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[KOC (deg),DATUM[Kuwait Oil Company,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-294.7,-200.1,525.5,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6246]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,62466405]]";public string EsriWkt => "GEOGCS[KOC (deg),DATUM[D_Kuwait Oil Company,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}