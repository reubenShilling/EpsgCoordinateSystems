using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class OSGB_1936_deg : IEpsgCoordinateSystem{private const int _srid = 62776405; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "OSGB 1936 (deg)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[OSGB 1936 (deg),DATUM[OSGB 1936,SPHEROID[Airy 1830,6377563.396,299.3249646,AUTHORITY[EPSG,7001]],TOWGS84[446.448,-125.157,542.06,0.15,0.247,0.842,-4.2261596151967575],AUTHORITY[EPSG,6277]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,62776405]]";public string EsriWkt => "GEOGCS[OSGB 1936 (deg),DATUM[D_OSGB 1936,SPHEROID[Airy_1830,6377563.396,299.3249646]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}