namespace EpsgCoordinateSystems.Other{public class WGS_84_geographic_3D : IEpsgCoordinateSystem{public string Name => "WGS 84 (geographic 3D)";public string Units => "Unspecified";
public long Srid => 4327;public string OgcWkt => "GEOGCS[WGS 84 (geographic 3D),DATUM[World Geodetic System 1984,SPHEROID[WGS 84,6378137.0,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[DMS,0.00000484813681109536],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4327]]";public string EsriWkt => "GEOGCS[WGS 84 (geographic 3D),DATUM[D_World Geodetic System 1984,SPHEROID[WGS_1984,6378137.0,298.257223563]],PRIMEM[Greenwich,0.0],UNIT[DMS,0.00000484813681109536]]";}}