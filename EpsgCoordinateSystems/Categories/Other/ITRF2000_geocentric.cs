namespace EpsgCoordinateSystems.Categories.Other{public class ITRF2000_geocentric : IEpsgCoordinateSystem{public string Name => "ITRF2000 (geocentric)";public string Units => "Unspecified";
public int Srid => 4385;public string OgcWkt => "GEOCCS[ITRF2000 (geocentric),DATUM[International Terrestrial Reference Frame 2000,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6656]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4385]]";public string EsriWkt => "GEOCCS[ITRF2000 (geocentric),DATUM[D_International Terrestrial Reference Frame 2000,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[m,1.0]]";}}