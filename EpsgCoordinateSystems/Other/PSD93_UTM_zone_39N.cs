namespace EpsgCoordinateSystems.Other
{
    public class PSD93_UTM_zone_39N : IEpsgCoordinateSystem
    {
        public string Name => "PSD93 / UTM zone 39N";
        public string Units => "Unspecified";
public long Srid => 3439;

        public string OgcWkt =>
            "PROJCS[PSD93 / UTM zone 39N,GEOGCS[PDO Survey Datum 1993,DATUM[PDO_Survey_Datum_1993,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6134]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4134]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,51],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3439],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[PSD93 / UTM zone 39N,GEOGCS[PDO Survey Datum 1993,DATUM[PDO_Survey_Datum_1993,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6134]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4134]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,51],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3439],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}