namespace EpsgCoordinateSystems.Other
{
    public class NAD27_Alaska_zone_1 : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 / Alaska zone 1";
        public string Units => "Unspecified";
public long Srid => 26731;

        public string OgcWkt =>
            "PROJCS[NAD27 / Alaska zone 1,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Hotine_Oblique_Mercator],PARAMETER[latitude_of_center,57],PARAMETER[longitude_of_center,-133.6666666666667],PARAMETER[azimuth,323.1301023611111],PARAMETER[rectified_grid_angle,323.1301023611111],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,16404166.67],PARAMETER[false_northing,-16404166.67],AUTHORITY[EPSG,26731],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD27 / Alaska zone 1,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Hotine_Oblique_Mercator],PARAMETER[latitude_of_center,57],PARAMETER[longitude_of_center,-133.6666666666667],PARAMETER[azimuth,323.1301023611111],PARAMETER[rectified_grid_angle,323.1301023611111],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,16404166.67],PARAMETER[false_northing,-16404166.67],AUTHORITY[EPSG,26731],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}