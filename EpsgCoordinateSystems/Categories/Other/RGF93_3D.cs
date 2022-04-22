using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class RGF93_3D : IEpsgCoordinateSystem{private const int _srid = 4369; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "RGF93 (3D)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "GEOGCS[RGF93 (3D),DATUM[Reseau Geodesique Francais 1993,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6171]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[DMS,0.00000484813681109536],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4369]]";public string EsriWkt => "GEOGCS[RGF93 (3D),DATUM[D_Reseau Geodesique Francais 1993,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[DMS,0.00000484813681109536]]";}}