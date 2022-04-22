using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories{internal class NAD83_Texas_North_Central_ftUS : IEpsgCoordinateSystem{private const int _srid = 2276; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "Texas North Central";public string Units => "US feet";
public int Srid => _srid;public string OgcWkt => "PROJCS[NAD83 / Texas North Central (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,33.96666666666667],PARAMETER[standard_parallel_2,32.13333333333333],PARAMETER[latitude_of_origin,31.66666666666667],PARAMETER[central_meridian,-98.5],PARAMETER[false_easting,1968500],PARAMETER[false_northing,6561666.667],AUTHORITY[EPSG,2276],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83 / Texas North Central (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,33.96666666666667],PARAMETER[standard_parallel_2,32.13333333333333],PARAMETER[latitude_of_origin,31.66666666666667],PARAMETER[central_meridian,-98.5],PARAMETER[false_easting,1968500],PARAMETER[false_northing,6561666.667],UNIT[Foot_US,0.30480060960121924]]";}}