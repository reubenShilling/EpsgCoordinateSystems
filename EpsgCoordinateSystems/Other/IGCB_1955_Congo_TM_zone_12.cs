namespace EpsgCoordinateSystems.Other
{
    public class IGCB_1955_Congo_TM_zone_12 : IEpsgCoordinateSystem
    {
        public string Name => "IGCB 1955 / Congo TM zone 12";
        public long Srid => 3339;

        public string OgcWkt =>
            "PROJCS[IGCB 1955 / Congo TM zone 12,GEOGCS[IGCB 1955,DATUM[Institut_Geographique_du_Congo_Belge_1955,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-79.9,-158,-168.9,0,0,0,0],AUTHORITY[EPSG,6701]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4701]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,12],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3339],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[IGCB 1955 / Congo TM zone 12,GEOGCS[IGCB 1955,DATUM[Institut_Geographique_du_Congo_Belge_1955,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-79.9,-158,-168.9,0,0,0,0],AUTHORITY[EPSG,6701]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4701]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,12],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3339],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}