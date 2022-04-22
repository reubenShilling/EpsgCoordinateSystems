namespace EpsgCoordinateSystems.Other
{
    public class HTRS96_Croatia_LCC : IEpsgCoordinateSystem
    {
        public string Name => "HTRS96 / Croatia LCC";
        public string Units => "Unspecified";
public long Srid => 3766;

        public string OgcWkt =>
            "PROJCS[HTRS96 / Croatia LCC,GEOGCS[HTRS96,DATUM[Croatian_Terrestrial_Reference_System,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6761]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4761]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,45.91666666666666],PARAMETER[standard_parallel_2,43.08333333333334],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,16.5],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3766],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[HTRS96 / Croatia LCC,GEOGCS[HTRS96,DATUM[Croatian_Terrestrial_Reference_System,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6761]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4761]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,45.91666666666666],PARAMETER[standard_parallel_2,43.08333333333334],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,16.5],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3766],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}