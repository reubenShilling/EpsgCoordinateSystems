namespace EpsgCoordinateSystems.Other{public class SIRGAS_3D : IEpsgCoordinateSystem{public string Name => "SIRGAS (3D)";public string Units => "Unspecified";
public long Srid => 4375;public string OgcWkt => "GEOGCS[SIRGAS (3D),DATUM[Sistema de Referencia Geocentrico para America del Sur 1995,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6170]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[DMS,0.00000484813681109536],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4375]]";public string EsriWkt => "GEOGCS[SIRGAS (3D),DATUM[D_Sistema de Referencia Geocentrico para America del Sur 1995,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[DMS,0.00000484813681109536]]";}}