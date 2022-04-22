namespace EpsgCoordinateSystems.Other{public class CHTRF95_geocentric : IEpsgCoordinateSystem{public string Name => "CHTRF95 (geocentric)";public string Units => "Unspecified";
public long Srid => 4344;public string OgcWkt => "GEOCCS[CHTRF95 (geocentric),DATUM[Swiss Terrestrial Reference Frame 1995,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6151]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4344]]";public string EsriWkt => "GEOCCS[CHTRF95 (geocentric),DATUM[D_Swiss Terrestrial Reference Frame 1995,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[m,1.0]]";}}