using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class RGFG95_geocentric : IEpsgCoordinateSystem{private const int _srid = 4372; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "RGFG95 (geocentric)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOCCS[RGFG95 (geocentric),DATUM[Reseau Geodesique Francais Guyane 1995,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[2.0,2.0,-2.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6624]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4372]]";public string EsriWkt => "GEOCCS[RGFG95 (geocentric),DATUM[D_Reseau Geodesique Francais Guyane 1995,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[m,1.0]]";}}