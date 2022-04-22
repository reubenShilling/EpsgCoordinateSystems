namespace EpsgCoordinateSystems.Other{public class OSGB70_deg : IEpsgCoordinateSystem{public string Name => "OSGB70 (deg)";public string Units => "Unspecified";
public long Srid => 62786405;public string OgcWkt => "GEOGCS[OSGB70 (deg),DATUM[OSGB 1970 (SN),SPHEROID[Airy 1830,6377563.396,299.3249646,AUTHORITY[EPSG,7001]],AUTHORITY[EPSG,6278]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,62786405]]";public string EsriWkt => "GEOGCS[OSGB70 (deg),DATUM[D_OSGB 1970 (SN),SPHEROID[Airy_1830,6377563.396,299.3249646]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}