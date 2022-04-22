using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class NAD83_CSRS_Alberta_10_TM_Forest : IEpsgCoordinateSystem{private const int _srid = 3402; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "NAD83(CSRS) / Alberta 10-TM (Forest)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "PROJCS[NAD83(CSRS) / Alberta 10-TM (Forest),GEOGCS[NAD83(CSRS),DATUM[NAD83_Canadian_Spatial_Reference_System,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6140]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4617]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-115],PARAMETER[scale_factor,0.9992],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3402],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";public string EsriWkt => "PROJCS[NAD83(CSRS) / Alberta 10-TM (Forest),GEOGCS[NAD83(CSRS),DATUM[D_North_American_1983_CSRS98,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-115],PARAMETER[scale_factor,0.9992],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";}}