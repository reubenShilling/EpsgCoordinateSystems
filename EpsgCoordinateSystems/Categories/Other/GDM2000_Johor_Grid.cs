namespace EpsgCoordinateSystems.Categories.Other
{
    public class GDM2000_Johor_Grid : IEpsgCoordinateSystem
    {
        public string Name => "GDM2000 / Johor Grid";
        public string Units => "Unspecified";
public int Srid => 3377;

        public string OgcWkt =>
            "PROJCS[GDM2000 / Johor Grid,GEOGCS[GDM2000,DATUM[Geodetic_Datum_of_Malaysia_2000,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6742]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4742]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Cassini_Soldner],PARAMETER[latitude_of_origin,2.121679744444445],PARAMETER[central_meridian,103.4279362361111],PARAMETER[false_easting,-14810.562],PARAMETER[false_northing,8758.32],AUTHORITY[EPSG,3377],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[GDM2000 / Johor Grid,GEOGCS[GDM2000,DATUM[D_GDM_2000,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Cassini],PARAMETER[latitude_of_origin,2.121679744444445],PARAMETER[central_meridian,103.4279362361111],PARAMETER[false_easting,-14810.562],PARAMETER[false_northing,8758.32],UNIT[Meter,1]]";
    }
}