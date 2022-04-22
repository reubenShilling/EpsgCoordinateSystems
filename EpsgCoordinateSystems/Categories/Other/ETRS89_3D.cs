namespace EpsgCoordinateSystems.Categories.Other{public class ETRS89_3D : IEpsgCoordinateSystem{public string Name => "ETRS89 (3D)";public string Units => "Unspecified";
public int Srid => 4345;public string OgcWkt => "GEOGCS[ETRS89 (3D),DATUM[European Terrestrial Reference System 1989,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[DMS,0.00000484813681109536],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4345]]";public string EsriWkt => "GEOGCS[ETRS89 (3D),DATUM[D_European Terrestrial Reference System 1989,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[DMS,0.00000484813681109536]]";}}