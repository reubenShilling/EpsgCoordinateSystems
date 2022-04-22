namespace EpsgCoordinateSystems.Categories.Other
{
    public class GDA94_Geoscience_Australia_Lambert : IEpsgCoordinateSystem
    {
        public string Name => "GDA94 / Geoscience Australia Lambert";
        public string Units => "Unspecified";
public int Srid => 3112;

        public string OgcWkt =>
            "PROJCS[GDA94 / Geoscience Australia Lambert,GEOGCS[GDA94,DATUM[Geocentric_Datum_of_Australia_1994,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6283]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4283]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,-18],PARAMETER[standard_parallel_2,-36],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,134],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3112],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[GDA94 / Geoscience Australia Lambert,GEOGCS[GDA94,DATUM[D_GDA_1994,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,-18],PARAMETER[standard_parallel_2,-36],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,134],PARAMETER[false_easting,0],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}