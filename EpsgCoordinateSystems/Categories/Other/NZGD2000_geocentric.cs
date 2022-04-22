using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class NZGD2000_geocentric : IEpsgCoordinateSystem{private const int _srid = 4364; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "NZGD2000 (geocentric)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOCCS[NZGD2000 (geocentric),DATUM[New Zealand Geodetic Datum 2000,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6167]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4364]]";public string EsriWkt => "GEOCCS[NZGD2000 (geocentric),DATUM[D_New Zealand Geodetic Datum 2000,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[m,1.0]]";}}