using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class NAD83_deg : IEpsgCoordinateSystem{private const int _srid = 62696405; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "NAD83 (deg)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[NAD83 (deg),DATUM[North American Datum 1983,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[1.0,1.0,-1.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,62696405]]";public string EsriWkt => "GEOGCS[NAD83 (deg),DATUM[D_North American Datum 1983,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}