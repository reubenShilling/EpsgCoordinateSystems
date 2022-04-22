namespace EpsgCoordinateSystems.Other{public class WGS_84_3D_deg : IEpsgCoordinateSystem{public string Name => "WGS 84 (3D deg)";public string Units => "Unspecified";
public long Srid => 63266413;public string OgcWkt => "GEOGCS[WGS 84 (3D deg),DATUM[World Geodetic System 1984,SPHEROID[WGS 84,6378137.0,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,63266413]]";public string EsriWkt => "GEOGCS[WGS 84 (3D deg),DATUM[D_World Geodetic System 1984,SPHEROID[WGS_1984,6378137.0,298.257223563]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}