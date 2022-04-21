namespace EpsgCoordinateSystems.Other
{
    public class ELD79_Libya_zone_13 : IEpsgCoordinateSystem
    {
        public string Name => "ELD79 / Libya zone 13";
        public long Srid => 2076;

        public string OgcWkt =>
            "PROJCS[ELD79 / Libya zone 13,GEOGCS[ELD79,DATUM[European_Libyan_Datum_1979,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6159]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4159]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,25],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,200000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2076],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[ELD79 / Libya zone 13,GEOGCS[ELD79,DATUM[European_Libyan_Datum_1979,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6159]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4159]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,25],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,200000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2076],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}