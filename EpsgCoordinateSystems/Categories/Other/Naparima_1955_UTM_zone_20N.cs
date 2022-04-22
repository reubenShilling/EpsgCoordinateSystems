namespace EpsgCoordinateSystems.Categories.Other
{
    public class Naparima_1955_UTM_zone_20N : IEpsgCoordinateSystem
    {
        public string Name => "Naparima 1955 / UTM zone 20N";
        public string Units => "Unspecified";
public int Srid => 2067;

        public string OgcWkt =>
            "PROJCS[Naparima 1955 / UTM zone 20N,GEOGCS[Naparima 1955,DATUM[Naparima_1955,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6158]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4158]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-63],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2067],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Naparima 1955 / UTM zone 20N,GEOGCS[Naparima 1955,DATUM[D_Naparima_1955,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-63],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}