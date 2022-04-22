using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class IRENET95_geocentric : IEpsgCoordinateSystem{private const int _srid = 4352; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "IRENET95 (geocentric)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOCCS[IRENET95 (geocentric),DATUM[IRENET95,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6173]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4352]]";public string EsriWkt => "GEOCCS[IRENET95 (geocentric),DATUM[D_IRENET95,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[m,1.0]]";}}