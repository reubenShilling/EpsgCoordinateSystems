namespace EpsgCoordinateSystems.Categories.Other
{
    public class Fort_Marigot_UTM_zone_20N : IEpsgCoordinateSystem
    {
        public string Name => "Fort Marigot / UTM zone 20N";
        public string Units => "Unspecified";
public int Srid => 2969;

        public string OgcWkt =>
            "PROJCS[Fort Marigot / UTM zone 20N,GEOGCS[Fort Marigot,DATUM[Fort_Marigot,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[137,248,-430,0,0,0,0],AUTHORITY[EPSG,6621]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4621]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-63],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2969],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Fort Marigot / UTM zone 20N,GEOGCS[Fort Marigot,DATUM[D_Fort_Marigot,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-63],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}