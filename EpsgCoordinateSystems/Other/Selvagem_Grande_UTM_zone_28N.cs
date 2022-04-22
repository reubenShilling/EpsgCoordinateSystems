namespace EpsgCoordinateSystems.Other
{
    public class Selvagem_Grande_UTM_zone_28N : IEpsgCoordinateSystem
    {
        public string Name => "Selvagem Grande / UTM zone 28N";
        public string Units => "Unspecified";
public long Srid => 2943;

        public string OgcWkt =>
            "PROJCS[Selvagem Grande / UTM zone 28N,GEOGCS[Selvagem Grande,DATUM[Selvagem_Grande,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6616]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4616]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2943],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Selvagem Grande / UTM zone 28N,GEOGCS[Selvagem Grande,DATUM[D_,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}