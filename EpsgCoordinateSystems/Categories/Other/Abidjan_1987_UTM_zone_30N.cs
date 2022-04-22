namespace EpsgCoordinateSystems.Categories.Other
{
    public class Abidjan_1987_UTM_zone_30N : IEpsgCoordinateSystem
    {
        public string Name => "Abidjan 1987 / UTM zone 30N";
        public string Units => "Unspecified";
public int Srid => 2041;

        public string OgcWkt =>
            "PROJCS[Abidjan 1987 / UTM zone 30N,GEOGCS[Abidjan 1987,DATUM[Abidjan_1987,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-124.76,53,466.79,0,0,0,0],AUTHORITY[EPSG,6143]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4143]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-3],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2041],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Abidjan 1987 / UTM zone 30N,GEOGCS[Abidjan 1987,DATUM[D_Abidjan_1987,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-3],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}