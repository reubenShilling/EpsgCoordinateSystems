namespace EpsgCoordinateSystems.Other{public class NAD83_CSRS_3D : IEpsgCoordinateSystem{public string Name => "NAD83(CSRS) (3D)";public string Units => "Unspecified";
public long Srid => 4359;public string OgcWkt => "GEOGCS[NAD83(CSRS) (3D),DATUM[NAD83 Canadian Spatial Reference System,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[-0.991,1.9072,0.5129,0.0257899075194932,-0.009650098960270402,-0.011659943232342112,0.0],AUTHORITY[EPSG,6140]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[DMS,0.00000484813681109536],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4359]]";public string EsriWkt => "GEOGCS[NAD83(CSRS) (3D),DATUM[D_NAD83 Canadian Spatial Reference System,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[DMS,0.00000484813681109536]]";}}