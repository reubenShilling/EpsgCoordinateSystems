using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class Tete_deg : IEpsgCoordinateSystem{private const int _srid = 61276405; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Tete (deg)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[Tete (deg),DATUM[Tete,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],TOWGS84[-82.875,-57.097,-156.768,-2.158,-1.524,0.982,-0.07404906544270759],AUTHORITY[EPSG,6127]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,61276405]]";public string EsriWkt => "GEOGCS[Tete (deg),DATUM[D_Tete,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";}}