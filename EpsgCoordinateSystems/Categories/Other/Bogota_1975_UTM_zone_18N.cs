namespace EpsgCoordinateSystems.Categories.Other
{
    public class Bogota_1975_UTM_zone_18N : IEpsgCoordinateSystem
    {
        public string Name => "Bogota 1975 / UTM zone 18N";
        public string Units => "Unspecified";
public int Srid => 21818;

        public string OgcWkt =>
            "PROJCS[Bogota 1975 / UTM zone 18N,GEOGCS[Bogota 1975,DATUM[Bogota_1975,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[307,304,-318,0,0,0,0],AUTHORITY[EPSG,6218]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4218]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-75],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,21818],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Bogota 1975 / UTM zone 18N,GEOGCS[Bogota 1975,DATUM[D_Bogota,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-75],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}