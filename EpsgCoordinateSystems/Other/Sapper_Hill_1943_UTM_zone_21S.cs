namespace EpsgCoordinateSystems.Other
{
    public class Sapper_Hill_1943_UTM_zone_21S : IEpsgCoordinateSystem
    {
        public string Name => "Sapper Hill 1943 / UTM zone 21S";
        public string Units => "Unspecified";
public long Srid => 29221;

        public string OgcWkt =>
            "PROJCS[Sapper Hill 1943 / UTM zone 21S,GEOGCS[Sapper Hill 1943,DATUM[Sapper_Hill_1943,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-355,21,72,0,0,0,0],AUTHORITY[EPSG,6292]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4292]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-57],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,29221],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Sapper Hill 1943 / UTM zone 21S,GEOGCS[Sapper Hill 1943,DATUM[D_Sapper_Hill_1943,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-57],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}