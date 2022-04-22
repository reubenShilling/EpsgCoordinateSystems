namespace EpsgCoordinateSystems.Other
{
    public class TC_1948_UTM_zone_39N : IEpsgCoordinateSystem
    {
        public string Name => "TC(1948) / UTM zone 39N";
        public string Units => "Unspecified";
public long Srid => 30339;

        public string OgcWkt =>
            "PROJCS[TC(1948) / UTM zone 39N,GEOGCS[TC(1948),DATUM[Trucial_Coast_1948,SPHEROID[Helmert 1906,6378200,298.3,AUTHORITY[EPSG,7020]],AUTHORITY[EPSG,6303]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4303]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,51],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,30339],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[TC(1948) / UTM zone 39N,GEOGCS[TC(1948),DATUM[D_Trucial_Coast_1948,SPHEROID[Helmert_1906,6378200,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,51],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}