namespace EpsgCoordinateSystems.Other
{
    public class RGNC91_93_UTM_zone_59S : IEpsgCoordinateSystem
    {
        public string Name => "RGNC91-93 / UTM zone 59S";
        public string Units => "Unspecified";
public long Srid => 3171;

        public string OgcWkt =>
            "PROJCS[RGNC91-93 / UTM zone 59S,GEOGCS[RGNC91-93,DATUM[Reseau_Geodesique_de_Nouvelle_Caledonie_91_93,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6749]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4749]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,171],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3171],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[RGNC91-93 / UTM zone 59S,GEOGCS[RGNC91-93,DATUM[Reseau_Geodesique_de_Nouvelle_Caledonie_91_93,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6749]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4749]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,171],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3171],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}