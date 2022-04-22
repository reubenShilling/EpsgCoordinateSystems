namespace EpsgCoordinateSystems.Categories.Other
{
    public class Pointe_Noire_UTM_zone_32S : IEpsgCoordinateSystem
    {
        public string Name => "Pointe Noire / UTM zone 32S";
        public string Units => "Unspecified";
public int Srid => 28232;

        public string OgcWkt =>
            "PROJCS[Pointe Noire / UTM zone 32S,GEOGCS[Pointe Noire,DATUM[Congo_1960_Pointe_Noire,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6282]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4282]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,28232],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Pointe Noire / UTM zone 32S,GEOGCS[Pointe Noire,DATUM[D_Pointe_Noire,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,9],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}