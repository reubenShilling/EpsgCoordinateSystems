namespace EpsgCoordinateSystems.Other
{
    public class Nord_Sahara_1959_UTM_zone_30N : IEpsgCoordinateSystem
    {
        public string Name => "Nord Sahara 1959 / UTM zone 30N";
        public string Units => "Unspecified";
public long Srid => 30730;

        public string OgcWkt =>
            "PROJCS[Nord Sahara 1959 / UTM zone 30N,GEOGCS[Nord Sahara 1959,DATUM[Nord_Sahara_1959,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6307]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4307]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-3],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,30730],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Nord Sahara 1959 / UTM zone 30N,GEOGCS[Nord Sahara 1959,DATUM[Nord_Sahara_1959,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6307]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4307]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-3],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,30730],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}