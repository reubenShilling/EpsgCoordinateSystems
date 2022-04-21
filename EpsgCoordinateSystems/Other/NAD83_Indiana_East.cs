namespace EpsgCoordinateSystems.Other
{
    public class NAD83_Indiana_East : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / Indiana East";
        public long Srid => 26973;

        public string OgcWkt =>
            "PROJCS[NAD83 / Indiana East,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,37.5],PARAMETER[central_meridian,-85.66666666666667],PARAMETER[scale_factor,0.999966667],PARAMETER[false_easting,100000],PARAMETER[false_northing,250000],AUTHORITY[EPSG,26973],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Indiana East,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,37.5],PARAMETER[central_meridian,-85.66666666666667],PARAMETER[scale_factor,0.999966667],PARAMETER[false_easting,100000],PARAMETER[false_northing,250000],AUTHORITY[EPSG,26973],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}