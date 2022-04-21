namespace EpsgCoordinateSystems.Other
{
    public class Campo_Inchauspe_UTM_zone_19S : IEpsgCoordinateSystem
    {
        public string Name => "Campo Inchauspe / UTM zone 19S";
        public long Srid => 2315;

        public string OgcWkt =>
            "PROJCS[Campo Inchauspe / UTM zone 19S,GEOGCS[Campo Inchauspe,DATUM[Campo_Inchauspe,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6221]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4221]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-69],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,2315],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Campo Inchauspe / UTM zone 19S,GEOGCS[Campo Inchauspe,DATUM[Campo_Inchauspe,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6221]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4221]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-69],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,2315],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}