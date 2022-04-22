namespace EpsgCoordinateSystems.Categories{internal class NAD83_Virginia_South_ftUS : IEpsgCoordinateSystem{public string Name => "Virginia South";public string Units => "US feet";
public int Srid => 2284;public string OgcWkt => "PROJCS[NAD83 / Virginia South (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,37.96666666666667],PARAMETER[standard_parallel_2,36.76666666666667],PARAMETER[latitude_of_origin,36.33333333333334],PARAMETER[central_meridian,-78.5],PARAMETER[false_easting,11482916.667],PARAMETER[false_northing,3280833.333],AUTHORITY[EPSG,2284],AXIS[X,EAST],AXIS[Y,NORTH]]";public string EsriWkt => "PROJCS[NAD83 / Virginia South (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,37.96666666666667],PARAMETER[standard_parallel_2,36.76666666666667],PARAMETER[latitude_of_origin,36.33333333333334],PARAMETER[central_meridian,-78.5],PARAMETER[false_easting,11482916.667],PARAMETER[false_northing,3280833.333],UNIT[Foot_US,0.30480060960121924]]";}}