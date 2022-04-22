namespace EpsgCoordinateSystems.Categories.Other
{
    public class IGCB_1955_UTM_zone_33S : IEpsgCoordinateSystem
    {
        public string Name => "IGCB 1955 / UTM zone 33S";
        public string Units => "Unspecified";
public int Srid => 3342;

        public string OgcWkt =>
            "PROJCS[IGCB 1955 / UTM zone 33S,GEOGCS[IGCB 1955,DATUM[Institut_Geographique_du_Congo_Belge_1955,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-79.9,-158,-168.9,0,0,0,0],AUTHORITY[EPSG,6701]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4701]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3342],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[IGCB 1955 / UTM zone 33S,GEOGCS[IGCB 1955,DATUM[D_Institut_Geographique_du_Congo_Belge_1955,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}