using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class Greek_deg : IEpsgCoordinateSystem{private const int _srid = 61206405; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Greek (deg)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[Greek (deg),DATUM[Greek,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6120]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,61206405]]";public string EsriWkt => "GEOGCS[Greek (deg),DATUM[D_Greek,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}