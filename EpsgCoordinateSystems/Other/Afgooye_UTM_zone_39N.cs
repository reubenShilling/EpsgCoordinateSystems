namespace EpsgCoordinateSystems.Other
{
    public class Afgooye_UTM_zone_39N : IEpsgCoordinateSystem
    {
        public string Name => "Afgooye / UTM zone 39N";
        public long Srid => 20539;

        public string OgcWkt =>
            "PROJCS[Afgooye / UTM zone 39N,GEOGCS[Afgooye,DATUM[Afgooye,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[-43,-163,45,0,0,0,0],AUTHORITY[EPSG,6205]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4205]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,51],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,20539],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Afgooye / UTM zone 39N,GEOGCS[Afgooye,DATUM[Afgooye,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[-43,-163,45,0,0,0,0],AUTHORITY[EPSG,6205]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4205]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,51],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,20539],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}