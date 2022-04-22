using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class NTF_Paris : IEpsgCoordinateSystem{private const int _srid = 4807; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "NTF (Paris)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[NTF (Paris),DATUM[Nouvelle_Triangulation_Francaise_Paris,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-168,-60,320,0,0,0,0],AUTHORITY[EPSG,6807]],PRIMEM[Paris,2.33722917,AUTHORITY[EPSG,8903]],UNIT[grad,0.01570796326794897,AUTHORITY[EPSG,9105]],AUTHORITY[EPSG,4807]]";public string EsriWkt => "GEOGCS[NTF (Paris),DATUM[D_NTF,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Paris,2.33722917],UNIT[grad,0.01570796326794897]]";}}