using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class LKS94_ETRS89 : IEpsgCoordinateSystem{private const int _srid = 4126; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "LKS94 (ETRS89)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[LKS94 (ETRS89),DATUM[Lithuania_1994_ETRS89,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6126]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4126]]";public string EsriWkt => "GEOGCS[LKS94 (ETRS89),DATUM[D_Lithuania_1994,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";}}