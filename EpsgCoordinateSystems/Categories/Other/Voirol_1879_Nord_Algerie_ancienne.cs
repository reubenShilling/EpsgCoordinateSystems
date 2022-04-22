using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class Voirol_1879_Nord_Algerie_ancienne : IEpsgCoordinateSystem{private const int _srid = 30493; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Voirol 1879 / Nord Algerie (ancienne)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "PROJCS[Voirol 1879 / Nord Algerie (ancienne),GEOGCS[Voirol 1879,DATUM[Voirol_1879,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6671]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4671]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,36],PARAMETER[central_meridian,2.7],PARAMETER[scale_factor,0.999625544],PARAMETER[false_easting,500000],PARAMETER[false_northing,300000],AUTHORITY[EPSG,30493],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[Voirol 1879 / Nord Algerie (ancienne),GEOGCS[Voirol 1879,DATUM[D_Voirol_1879,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,36],PARAMETER[central_meridian,2.7],PARAMETER[scale_factor,0.999625544],PARAMETER[false_easting,500000],PARAMETER[false_northing,300000],UNIT[Meter,1]]";}}