using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other{public class NAD83_Oregon_South_ft : IEpsgCoordinateSystem{private const int _srid = 2270; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);public string Name => "NAD83 / Oregon South (ft)";public string Units => "Unspecified";
public int Srid => _srid;public string OgcWkt => "PROJCS[NAD83 / Oregon South (ft),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[foot,0.3048,AUTHORITY[EPSG,9002]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,44],PARAMETER[standard_parallel_2,42.33333333333334],PARAMETER[latitude_of_origin,41.66666666666666],PARAMETER[central_meridian,-120.5],PARAMETER[false_easting,4921259.843],PARAMETER[false_northing,0],AUTHORITY[EPSG,2270],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83 / Oregon South (ft),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,44],PARAMETER[standard_parallel_2,42.33333333333334],PARAMETER[latitude_of_origin,41.66666666666666],PARAMETER[central_meridian,-120.5],PARAMETER[false_easting,4921259.843],PARAMETER[false_northing,0],UNIT[Foot,0.3048]]";}}