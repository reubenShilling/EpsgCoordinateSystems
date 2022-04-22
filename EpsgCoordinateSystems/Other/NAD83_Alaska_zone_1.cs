namespace EpsgCoordinateSystems.Other
{
    public class NAD83_Alaska_zone_1 : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / Alaska zone 1";
        public string Units => "Unspecified";
public long Srid => 26931;

        public string OgcWkt =>
            "PROJCS[NAD83 / Alaska zone 1,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Hotine_Oblique_Mercator],PARAMETER[latitude_of_center,57],PARAMETER[longitude_of_center,-133.6666666666667],PARAMETER[azimuth,323.1301023611111],PARAMETER[rectified_grid_angle,323.1301023611111],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,5000000],PARAMETER[false_northing,-5000000],AUTHORITY[EPSG,26931],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Alaska zone 1,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Hotine_Oblique_Mercator],PARAMETER[latitude_of_center,57],PARAMETER[longitude_of_center,-133.6666666666667],PARAMETER[azimuth,323.1301023611111],PARAMETER[rectified_grid_angle,323.1301023611111],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,5000000],PARAMETER[false_northing,-5000000],AUTHORITY[EPSG,26931],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}