namespace EpsgCoordinateSystems.Categories.Other{public class RT90_deg : IEpsgCoordinateSystem{public string Name => "RT90 (deg)";public string Units => "Unspecified";
public int Srid => 61246405;public string OgcWkt => "GEOGCS[RT90 (deg),DATUM[Rikets koordinatsystem 1990,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[414.1,41.3,603.1,-0.855,-2.141,7.023,0.0],AUTHORITY[EPSG,6124]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,61246405]]";public string EsriWkt => "GEOGCS[RT90 (deg),DATUM[D_Rikets koordinatsystem 1990,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}