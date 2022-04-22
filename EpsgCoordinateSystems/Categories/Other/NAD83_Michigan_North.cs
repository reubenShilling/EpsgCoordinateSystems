using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class NAD83_Michigan_North : IEpsgCoordinateSystem
    {private const int _srid = 26988; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NAD83 / Michigan North";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Michigan North,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,47.08333333333334],PARAMETER[standard_parallel_2,45.48333333333333],PARAMETER[latitude_of_origin,44.78333333333333],PARAMETER[central_meridian,-87],PARAMETER[false_easting,8000000],PARAMETER[false_northing,0],AUTHORITY[EPSG,26988],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83 / Michigan North,GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,47.08333333333334],PARAMETER[standard_parallel_2,45.48333333333333],PARAMETER[latitude_of_origin,44.78333333333333],PARAMETER[central_meridian,-87],PARAMETER[false_easting,8000000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}