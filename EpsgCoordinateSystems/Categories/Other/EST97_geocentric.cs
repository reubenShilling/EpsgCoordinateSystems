namespace EpsgCoordinateSystems.Categories.Other{public class EST97_geocentric : IEpsgCoordinateSystem{public string Name => "EST97 (geocentric)";public string Units => "Unspecified";
public int Srid => 4342;public string OgcWkt => "GEOCCS[EST97 (geocentric),DATUM[Estonia 1997,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6180]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4342]]";public string EsriWkt => "GEOCCS[EST97 (geocentric),DATUM[D_Estonia 1997,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[m,1.0]]";}}