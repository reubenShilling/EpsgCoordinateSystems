namespace EpsgCoordinateSystems.Other
{
    public class NEA74_Noumea_UTM_zone_58S : IEpsgCoordinateSystem
    {
        public string Name => "NEA74 Noumea / UTM zone 58S";
        public string Units => "Unspecified";
public long Srid => 2998;

        public string OgcWkt =>
            "PROJCS[NEA74 Noumea / UTM zone 58S,GEOGCS[NEA74 Noumea,DATUM[NEA74_Noumea,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6644]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4644]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,165],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,2998],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[NEA74 Noumea / UTM zone 58S,GEOGCS[NEA74 Noumea,DATUM[D_NEA74_Noumea,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,165],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}