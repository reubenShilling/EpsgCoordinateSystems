namespace EpsgCoordinateSystems.Categories.Other
{
    public class RGPF_UTM_zone_5S : IEpsgCoordinateSystem
    {
        public string Name => "RGPF / UTM zone 5S";
        public string Units => "Unspecified";
public int Srid => 3296;

        public string OgcWkt =>
            "PROJCS[RGPF / UTM zone 5S,GEOGCS[RGPF,DATUM[Reseau_Geodesique_de_la_Polynesie_Francaise,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6687]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4687]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-153],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3296],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[RGPF / UTM zone 5S,GEOGCS[RGPF,DATUM[D_Reseau_Geodesique_de_la_Polynesie_Francaise,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-153],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}