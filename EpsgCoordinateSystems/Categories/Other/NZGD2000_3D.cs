namespace EpsgCoordinateSystems.Categories.Other{public class NZGD2000_3D : IEpsgCoordinateSystem{public string Name => "NZGD2000 (3D)";public string Units => "Unspecified";
public int Srid => 4363;public string OgcWkt => "GEOGCS[NZGD2000 (3D),DATUM[New Zealand Geodetic Datum 2000,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6167]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[DMS,0.00000484813681109536],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4363]]";public string EsriWkt => "GEOGCS[NZGD2000 (3D),DATUM[D_New Zealand Geodetic Datum 2000,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[DMS,0.00000484813681109536]]";}}