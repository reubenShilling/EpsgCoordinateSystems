namespace EpsgCoordinateSystems.Other
{
    public class GDA94_Australian_Albers : IEpsgCoordinateSystem
    {
        public string Name => "GDA94 / Australian Albers";
        public string Units => "Unspecified";
public long Srid => 3577;

        public string OgcWkt =>
            "PROJCS[GDA94 / Australian Albers,GEOGCS[GDA94,DATUM[Geocentric_Datum_of_Australia_1994,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6283]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4283]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,-18],PARAMETER[standard_parallel_2,-36],PARAMETER[latitude_of_center,0],PARAMETER[longitude_of_center,132],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3577],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[GDA94 / Australian Albers,GEOGCS[GDA94,DATUM[Geocentric_Datum_of_Australia_1994,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6283]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4283]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Albers_Conic_Equal_Area],PARAMETER[standard_parallel_1,-18],PARAMETER[standard_parallel_2,-36],PARAMETER[latitude_of_center,0],PARAMETER[longitude_of_center,132],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3577],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}