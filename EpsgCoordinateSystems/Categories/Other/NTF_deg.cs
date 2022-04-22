namespace EpsgCoordinateSystems.Categories.Other{public class NTF_deg : IEpsgCoordinateSystem{public string Name => "NTF (deg)";public string Units => "Unspecified";
public int Srid => 62756405;public string OgcWkt => "GEOGCS[NTF (deg),DATUM[Nouvelle Triangulation Francaise,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-168.0,-60.0,320.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6275]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,62756405]]";public string EsriWkt => "GEOGCS[NTF (deg),DATUM[D_Nouvelle Triangulation Francaise,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}