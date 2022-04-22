namespace EpsgCoordinateSystems.Other
{
    public class WGS_72_UTM_zone_55S : IEpsgCoordinateSystem
    {
        public string Name => "WGS 72 / UTM zone 55S";
        public string Units => "Unspecified";
public long Srid => 32355;

        public string OgcWkt =>
            "PROJCS[WGS 72 / UTM zone 55S,GEOGCS[WGS 72,DATUM[WGS_1972,SPHEROID[WGS 72,6378135,298.26,AUTHORITY[EPSG,7043]],AUTHORITY[EPSG,6322]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4322]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,147],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,32355],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[WGS 72 / UTM zone 55S,GEOGCS[WGS 72,DATUM[WGS_1972,SPHEROID[WGS 72,6378135,298.26,AUTHORITY[EPSG,7043]],AUTHORITY[EPSG,6322]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4322]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,147],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,32355],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}