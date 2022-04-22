namespace EpsgCoordinateSystems.Categories.Other
{
    public class GDM2000_Kelantan_Grid : IEpsgCoordinateSystem
    {
        public string Name => "GDM2000 / Kelantan Grid";
        public string Units => "Unspecified";
public int Srid => 3385;

        public string OgcWkt =>
            "PROJCS[GDM2000 / Kelantan Grid,GEOGCS[GDM2000,DATUM[Geodetic_Datum_of_Malaysia_2000,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6742]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4742]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Cassini_Soldner],PARAMETER[latitude_of_origin,5.972543658333334],PARAMETER[central_meridian,102.2952416694444],PARAMETER[false_easting,13227.851],PARAMETER[false_northing,8739.894],AUTHORITY[EPSG,3385],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[GDM2000 / Kelantan Grid,GEOGCS[GDM2000,DATUM[D_GDM_2000,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Cassini],PARAMETER[latitude_of_origin,5.972543658333334],PARAMETER[central_meridian,102.2952416694444],PARAMETER[false_easting,13227.851],PARAMETER[false_northing,8739.894],UNIT[Meter,1]]";
    }
}