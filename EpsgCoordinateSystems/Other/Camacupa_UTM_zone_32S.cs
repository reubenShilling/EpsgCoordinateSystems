namespace EpsgCoordinateSystems.Other
{
    public class Camacupa_UTM_zone_32S : IEpsgCoordinateSystem
    {
        public string Name => "Camacupa / UTM zone 32S";
        public string Units => "Unspecified";
public long Srid => 22032;

        public string OgcWkt =>
            "PROJCS[Camacupa / UTM zone 32S,GEOGCS[Camacupa,DATUM[Camacupa,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6220]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4220]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,22032],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Camacupa / UTM zone 32S,GEOGCS[Camacupa,DATUM[Camacupa,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6220]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4220]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,22032],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}