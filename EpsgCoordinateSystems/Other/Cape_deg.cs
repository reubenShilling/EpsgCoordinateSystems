namespace EpsgCoordinateSystems.Other{public class Cape_deg : IEpsgCoordinateSystem{public string Name => "Cape (deg)";public string Units => "Unspecified";
public long Srid => 62226405;public string OgcWkt => "GEOGCS[Cape (deg),DATUM[Cape,SPHEROID[Clarke 1880 (Arc),6378249.145,293.4663077,AUTHORITY[EPSG,7013]],TOWGS84[-136.0,-108.0,-292.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6222]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,62226405]]";public string EsriWkt => "GEOGCS[Cape (deg),DATUM[D_Cape,SPHEROID[Clarke_1880_Arc,6378249.145,293.4663077]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}