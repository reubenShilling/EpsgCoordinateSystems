namespace EpsgCoordinateSystems.Other
{
    public class RGFG95_UTM_zone_22N : IEpsgCoordinateSystem
    {
        public string Name => "RGFG95 / UTM zone 22N";
        public string Units => "Unspecified";
public long Srid => 2972;

        public string OgcWkt =>
            "PROJCS[RGFG95 / UTM zone 22N,GEOGCS[RGFG95,DATUM[Reseau_Geodesique_Francais_Guyane_1995,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[2,2,-2,0,0,0,0],AUTHORITY[EPSG,6624]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4624]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-51],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2972],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[RGFG95 / UTM zone 22N,GEOGCS[RGFG95,DATUM[Reseau_Geodesique_Francais_Guyane_1995,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[2,2,-2,0,0,0,0],AUTHORITY[EPSG,6624]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4624]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-51],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2972],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}