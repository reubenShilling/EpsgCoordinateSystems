namespace EpsgCoordinateSystems.Categories.Other
{
    public class Combani_1950_UTM_zone_38S : IEpsgCoordinateSystem
    {
        public string Name => "Combani 1950 / UTM zone 38S";
        public string Units => "Unspecified";
public int Srid => 2980;

        public string OgcWkt =>
            "PROJCS[Combani 1950 / UTM zone 38S,GEOGCS[Combani 1950,DATUM[Combani_1950,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-382,-59,-262,0,0,0,0],AUTHORITY[EPSG,6632]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4632]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,45],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,2980],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Combani 1950 / UTM zone 38S,GEOGCS[Combani 1950,DATUM[D_Combani_1950,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,45],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}