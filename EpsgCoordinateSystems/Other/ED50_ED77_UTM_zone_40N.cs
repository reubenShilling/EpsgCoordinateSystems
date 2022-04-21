namespace EpsgCoordinateSystems.Other
{
    public class ED50_ED77_UTM_zone_40N : IEpsgCoordinateSystem
    {
        public string Name => "ED50(ED77) / UTM zone 40N";
        public long Srid => 2060;

        public string OgcWkt =>
            "PROJCS[ED50(ED77) / UTM zone 40N,GEOGCS[ED50(ED77),DATUM[European_Datum_1950_1977,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6154]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4154]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,57],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2060],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[ED50(ED77) / UTM zone 40N,GEOGCS[ED50(ED77),DATUM[European_Datum_1950_1977,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6154]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4154]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,57],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2060],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}