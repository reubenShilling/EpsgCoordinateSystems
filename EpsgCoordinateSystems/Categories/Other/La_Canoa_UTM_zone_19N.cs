namespace EpsgCoordinateSystems.Categories.Other
{
    public class La_Canoa_UTM_zone_19N : IEpsgCoordinateSystem
    {
        public string Name => "La Canoa / UTM zone 19N";
        public string Units => "Unspecified";
public int Srid => 24719;

        public string OgcWkt =>
            "PROJCS[La Canoa / UTM zone 19N,GEOGCS[La Canoa,DATUM[La_Canoa,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-273.5,110.6,-357.9,0,0,0,0],AUTHORITY[EPSG,6247]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4247]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-69],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,24719],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[La Canoa / UTM zone 19N,GEOGCS[La Canoa,DATUM[D_La_Canoa,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-69],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}