namespace EpsgCoordinateSystems.Other{public class ITRF94_geocentric : IEpsgCoordinateSystem{public string Name => "ITRF94 (geocentric)";public string Units => "Unspecified";
public long Srid => 4336;public string OgcWkt => "GEOCCS[ITRF94 (geocentric),DATUM[International Terrestrial Reference Frame 1994,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6653]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4336]]";public string EsriWkt => "GEOCCS[ITRF94 (geocentric),DATUM[D_International Terrestrial Reference Frame 1994,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[m,1.0]]";}}