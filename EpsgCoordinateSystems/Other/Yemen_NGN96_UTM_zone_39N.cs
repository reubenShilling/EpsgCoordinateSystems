namespace EpsgCoordinateSystems.Other
{
    public class Yemen_NGN96_UTM_zone_39N : IEpsgCoordinateSystem
    {
        public string Name => "Yemen NGN96 / UTM zone 39N";
        public string Units => "Unspecified";
public long Srid => 2090;

        public string OgcWkt =>
            "PROJCS[Yemen NGN96 / UTM zone 39N,GEOGCS[Yemen NGN96,DATUM[Yemen_National_Geodetic_Network_1996,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6163]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4163]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,51],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2090],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Yemen NGN96 / UTM zone 39N,GEOGCS[Yemen NGN96,DATUM[Yemen_National_Geodetic_Network_1996,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6163]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4163]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,51],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2090],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}