namespace EpsgCoordinateSystems.Other{public class WGS_84_geocentric : IEpsgCoordinateSystem{public string Name => "WGS 84 (geocentric)";public long Srid => 4328;public string OgcWkt => "GEOCCS[WGS 84 (geocentric),DATUM[World Geodetic System 1984,SPHEROID[WGS 84,6378137.0,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4328]]";public string EsriWkt => "GEOCCS[WGS 84 (geocentric),DATUM[World Geodetic System 1984,SPHEROID[WGS 84,6378137.0,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4328]]";}}