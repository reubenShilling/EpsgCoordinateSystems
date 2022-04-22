namespace EpsgCoordinateSystems.Categories.Other
{
    public class NAD_Michigan_Michigan_Old_Central : IEpsgCoordinateSystem
    {
        public string Name => "NAD Michigan / Michigan Old Central";
        public string Units => "Unspecified";
public int Srid => 26802;

        public string OgcWkt =>
            "PROJCS[NAD Michigan / Michigan Old Central,GEOGCS[NAD27 Michigan,DATUM[NAD_Michigan,SPHEROID[Clarke 1866 Michigan,6378450.047548896,294.9786971646747,AUTHORITY[EPSG,7009]],AUTHORITY[EPSG,6268]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4268]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,41.5],PARAMETER[central_meridian,-85.75],PARAMETER[scale_factor,0.999909091],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,26802],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD Michigan / Michigan Old Central,GEOGCS[NAD27 Michigan,DATUM[D_North_American_Michigan,SPHEROID[Clarke_1866_Michigan,6378450.047548896,294.9786971646747]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,41.5],PARAMETER[central_meridian,-85.75],PARAMETER[scale_factor,0.999909091],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";
    }
}