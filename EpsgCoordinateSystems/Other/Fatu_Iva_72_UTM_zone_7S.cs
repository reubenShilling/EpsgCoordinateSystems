namespace EpsgCoordinateSystems.Other
{
    public class Fatu_Iva_72_UTM_zone_7S : IEpsgCoordinateSystem
    {
        public string Name => "Fatu Iva 72 / UTM zone 7S";
        public string Units => "Unspecified";
public long Srid => 3303;

        public string OgcWkt =>
            "PROJCS[Fatu Iva 72 / UTM zone 7S,GEOGCS[Fatu Iva 72,DATUM[Fatu_Iva_72,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[347.103,1078.12,2623.92,-33.8875,70.6773,-9.3943,186.074],AUTHORITY[EPSG,6688]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4688]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-141],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3303],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Fatu Iva 72 / UTM zone 7S,GEOGCS[Fatu Iva 72,DATUM[D_Fatu_Iva_1972,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-141],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}