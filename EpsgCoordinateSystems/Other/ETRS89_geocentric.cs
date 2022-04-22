namespace EpsgCoordinateSystems.Other{public class ETRS89_geocentric : IEpsgCoordinateSystem{public string Name => "ETRS89 (geocentric)";public string Units => "Unspecified";
public long Srid => 4346;public string OgcWkt => "GEOCCS[ETRS89 (geocentric),DATUM[European Terrestrial Reference System 1989,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4346]]";public string EsriWkt => "GEOCCS[ETRS89 (geocentric),DATUM[D_European Terrestrial Reference System 1989,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[m,1.0]]";}}