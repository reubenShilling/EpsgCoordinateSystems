using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class JGD2000_deg : IEpsgCoordinateSystem{private const int _srid = 66126405; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "JGD2000 (deg)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[JGD2000 (deg),DATUM[Japanese Geodetic Datum 2000,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6612]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,66126405]]";public string EsriWkt => "GEOGCS[JGD2000 (deg),DATUM[D_Japanese Geodetic Datum 2000,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}