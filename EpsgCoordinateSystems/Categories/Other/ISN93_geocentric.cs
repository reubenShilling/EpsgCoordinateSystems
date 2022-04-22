namespace EpsgCoordinateSystems.Categories.Other{public class ISN93_geocentric : IEpsgCoordinateSystem{public string Name => "ISN93 (geocentric)";public string Units => "Unspecified";
public int Srid => 4387;public string OgcWkt => "GEOCCS[ISN93 (geocentric),DATUM[Islands Network 1993,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6659]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4387]]";public string EsriWkt => "GEOCCS[ISN93 (geocentric),DATUM[D_Islands Network 1993,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[m,1.0]]";}}