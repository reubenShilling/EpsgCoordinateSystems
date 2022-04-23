using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories{internal class NAD83_Indiana_West_ftUS : INad83StatePlaneUsFtCoordinateSystem{private const int _srid = 2966; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Indiana West";public string Units => "US feet";
public int Srid => _srid;public string OgcWkt => "PROJCS[NAD83 / Indiana West (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,37.5],PARAMETER[central_meridian,-87.08333333333333],PARAMETER[scale_factor,0.999966667],PARAMETER[false_easting,2952750],PARAMETER[false_northing,820208.3330000002],AUTHORITY[EPSG,2966],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83 / Indiana West (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,37.5],PARAMETER[central_meridian,-87.08333333333333],PARAMETER[scale_factor,0.999966667],PARAMETER[false_easting,2952750],PARAMETER[false_northing,820208.3330000002],UNIT[Foot_US,0.30480060960121924]]";}}