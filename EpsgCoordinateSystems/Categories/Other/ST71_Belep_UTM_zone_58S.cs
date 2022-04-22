namespace EpsgCoordinateSystems.Categories.Other
{
    public class ST71_Belep_UTM_zone_58S : IEpsgCoordinateSystem
    {
        public string Name => "ST71 Belep / UTM zone 58S";
        public string Units => "Unspecified";
public int Srid => 2997;

        public string OgcWkt =>
            "PROJCS[ST71 Belep / UTM zone 58S,GEOGCS[ST71 Belep,DATUM[ST71_Belep,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-480.26,-438.32,-643.429,16.3119,20.1721,-4.0349,-111.7],AUTHORITY[EPSG,6643]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4643]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,165],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,2997],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[ST71 Belep / UTM zone 58S,GEOGCS[ST71 Belep,DATUM[D_ST71_Belep,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,165],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}