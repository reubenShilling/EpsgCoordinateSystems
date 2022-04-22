namespace EpsgCoordinateSystems.Other{public class Pointe_Noire_deg : IEpsgCoordinateSystem{public string Name => "Pointe Noire (deg)";public string Units => "Unspecified";
public long Srid => 62826405;public string OgcWkt => "GEOGCS[Pointe Noire (deg),DATUM[Congo 1960 Pointe Noire,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-178.3,-316.7,-131.5,5.278,6.077,10.979,3.953271276531849],AUTHORITY[EPSG,6282]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,62826405]]";public string EsriWkt => "GEOGCS[Pointe Noire (deg),DATUM[D_Congo 1960 Pointe Noire,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}