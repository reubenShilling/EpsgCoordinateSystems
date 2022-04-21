namespace EpsgCoordinateSystems.Other
{
    public class Monte_Mario_Italy_zone_2 : IEpsgCoordinateSystem
    {
        public string Name => "Monte Mario / Italy zone 2";
        public long Srid => 3004;

        public string OgcWkt =>
            "PROJCS[Monte Mario / Italy zone 2,GEOGCS[Monte Mario,DATUM[Monte_Mario,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6265]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4265]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,2520000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3004],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Monte Mario / Italy zone 2,GEOGCS[Monte Mario,DATUM[Monte_Mario,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6265]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4265]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,2520000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3004],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}