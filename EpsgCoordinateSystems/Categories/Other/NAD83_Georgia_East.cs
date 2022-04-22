using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class NAD83_Georgia_East : IEpsgCoordinateSystem
    {private const int _srid = 26966; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NAD83 / Georgia East";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Georgia East,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,30],PARAMETER[central_meridian,-82.16666666666667],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,200000],PARAMETER[false_northing,0],AUTHORITY[EPSG,26966],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83 / Georgia East,GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,30],PARAMETER[central_meridian,-82.16666666666667],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,200000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}