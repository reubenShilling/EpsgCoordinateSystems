namespace EpsgCoordinateSystems.Categories.Other
{
    public class TWD97_TM2_zone_121 : IEpsgCoordinateSystem
    {
        public string Name => "TWD97 / TM2 zone 121";
        public string Units => "Unspecified";
public int Srid => 3826;

        public string OgcWkt =>
            "PROJCS[TWD97 / TM2 zone 121,GEOGCS[TWD97,DATUM[Taiwan Datum 1997,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,1026]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,3824]],PROJECTION[Transverse Mercator,AUTHORITY[EPSG,9807]],PARAMETER[central_meridian,121.0],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,250000.0],PARAMETER[false_northing,0.0],UNIT[m,1.0],AXIS[Easting,EAST],AXIS[Northing,NORTH],AUTHORITY[EPSG,3826]]";

        public string EsriWkt => "PROJCS[TWD97 / TM2 zone 121,GEOGCS[TWD97,DATUM[D_Taiwan Datum 1997,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse Mercator],PARAMETER[central_meridian,121.0],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,250000.0],PARAMETER[false_northing,0.0],UNIT[m,1.0]]";
    }
}