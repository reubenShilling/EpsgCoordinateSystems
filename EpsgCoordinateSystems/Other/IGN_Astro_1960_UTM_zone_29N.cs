namespace EpsgCoordinateSystems.Other
{
    public class IGN_Astro_1960_UTM_zone_29N : IEpsgCoordinateSystem
    {
        public string Name => "IGN Astro 1960 / UTM zone 29N";
        public long Srid => 3368;

        public string OgcWkt =>
            "PROJCS[IGN Astro 1960 / UTM zone 29N,GEOGCS[IGN Astro 1960,DATUM[IGN_Astro_1960,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6700]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4700]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3368],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[IGN Astro 1960 / UTM zone 29N,GEOGCS[IGN Astro 1960,DATUM[IGN_Astro_1960,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6700]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4700]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3368],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}