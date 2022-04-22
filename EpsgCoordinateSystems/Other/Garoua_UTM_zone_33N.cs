namespace EpsgCoordinateSystems.Other
{
    public class Garoua_UTM_zone_33N : IEpsgCoordinateSystem
    {
        public string Name => "Garoua / UTM zone 33N";
        public string Units => "Unspecified";
public long Srid => 2312;

        public string OgcWkt =>
            "PROJCS[Garoua / UTM zone 33N,GEOGCS[Garoua,DATUM[Garoua,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6197]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4197]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2312],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Garoua / UTM zone 33N,GEOGCS[Garoua,DATUM[Garoua,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6197]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4197]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2312],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}