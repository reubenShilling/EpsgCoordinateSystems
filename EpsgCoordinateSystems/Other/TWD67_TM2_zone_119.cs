namespace EpsgCoordinateSystems.Other
{
    public class TWD67_TM2_zone_119 : IEpsgCoordinateSystem
    {
        public string Name => "TWD67 / TM2 zone 119";
        public string Units => "Unspecified";
public long Srid => 3827;

        public string OgcWkt =>
            "PROJCS[TWD67 / TM2 zone 119,GEOGCS[TWD67,DATUM[Taiwan Datum 1967,SPHEROID[GRS 1967 Modified,6378160.0,298.25,AUTHORITY[EPSG,7050]],AUTHORITY[EPSG,1025]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,3821]],PROJECTION[Transverse Mercator,AUTHORITY[EPSG,9807]],PARAMETER[central_meridian,119.0],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,250000.0],PARAMETER[false_northing,0.0],UNIT[m,1.0],AXIS[Easting,EAST],AXIS[Northing,NORTH],AUTHORITY[EPSG,3827]]";

        public string EsriWkt =>
            "PROJCS[TWD67 / TM2 zone 119,GEOGCS[TWD67,DATUM[Taiwan Datum 1967,SPHEROID[GRS 1967 Modified,6378160.0,298.25,AUTHORITY[EPSG,7050]],AUTHORITY[EPSG,1025]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,3821]],PROJECTION[Transverse Mercator,AUTHORITY[EPSG,9807]],PARAMETER[central_meridian,119.0],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,250000.0],PARAMETER[false_northing,0.0],UNIT[m,1.0],AXIS[Easting,EAST],AXIS[Northing,NORTH],AUTHORITY[EPSG,3827]]";
    }
}