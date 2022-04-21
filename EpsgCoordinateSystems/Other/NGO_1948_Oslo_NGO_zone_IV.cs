namespace EpsgCoordinateSystems.Other
{
    public class NGO_1948_Oslo_NGO_zone_IV : IEpsgCoordinateSystem
    {
        public string Name => "NGO 1948 (Oslo) / NGO zone IV";
        public long Srid => 27394;

        public string OgcWkt =>
            "PROJCS[NGO 1948 (Oslo) / NGO zone IV,GEOGCS[NGO 1948 (Oslo),DATUM[NGO_1948_Oslo,SPHEROID[Bessel Modified,6377492.018,299.1528128,AUTHORITY[EPSG,7005]],TOWGS84[278.3,93,474.5,7.889,0.05,-6.61,6.21],AUTHORITY[EPSG,6817]],PRIMEM[Oslo,10.72291666666667,AUTHORITY[EPSG,8913]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4817]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,58],PARAMETER[central_meridian,2.5],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,27394],AXIS[y,EAST],AXIS[x,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NGO 1948 (Oslo) / NGO zone IV,GEOGCS[NGO 1948 (Oslo),DATUM[NGO_1948_Oslo,SPHEROID[Bessel Modified,6377492.018,299.1528128,AUTHORITY[EPSG,7005]],TOWGS84[278.3,93,474.5,7.889,0.05,-6.61,6.21],AUTHORITY[EPSG,6817]],PRIMEM[Oslo,10.72291666666667,AUTHORITY[EPSG,8913]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4817]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,58],PARAMETER[central_meridian,2.5],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,27394],AXIS[y,EAST],AXIS[x,NORTH]]";
    }
}