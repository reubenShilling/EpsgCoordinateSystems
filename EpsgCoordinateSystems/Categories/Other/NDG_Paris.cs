using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class NDG_Paris : IEpsgCoordinateSystem{private const int _srid = 4902; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "NDG (Paris)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[NDG (Paris),DATUM[Nord_de_Guerre_Paris,SPHEROID[Plessis 1817,6376523,308.64,AUTHORITY[EPSG,7027]],AUTHORITY[EPSG,6902]],PRIMEM[Paris,2.33722917,AUTHORITY[EPSG,8903]],UNIT[grad,0.01570796326794897,AUTHORITY[EPSG,9105]],AUTHORITY[EPSG,4902]]";public string EsriWkt => "GEOGCS[NDG (Paris),DATUM[D_Nord_de_Guerre,SPHEROID[Plessis_1817,6376523,308.64]],PRIMEM[Paris,2.33722917],UNIT[grad,0.01570796326794897]]";}}