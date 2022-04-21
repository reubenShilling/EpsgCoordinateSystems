namespace EpsgCoordinateSystems.Other
{
    public class NZGD49_New_Zealand_Map_Grid : IEpsgCoordinateSystem
    {
        public string Name => "NZGD49 / New Zealand Map Grid";
        public long Srid => 27200;

        public string OgcWkt =>
            "PROJCS[NZGD49 / New Zealand Map Grid,GEOGCS[NZGD49,DATUM[New_Zealand_Geodetic_Datum_1949,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[59.47,-5.04,187.44,0.47,-0.1,1.024,-4.5993],AUTHORITY[EPSG,6272]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4272]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[New_Zealand_Map_Grid],PARAMETER[latitude_of_origin,-41],PARAMETER[central_meridian,173],PARAMETER[false_easting,2510000],PARAMETER[false_northing,6023150],AUTHORITY[EPSG,27200],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NZGD49 / New Zealand Map Grid,GEOGCS[NZGD49,DATUM[New_Zealand_Geodetic_Datum_1949,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[59.47,-5.04,187.44,0.47,-0.1,1.024,-4.5993],AUTHORITY[EPSG,6272]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4272]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[New_Zealand_Map_Grid],PARAMETER[latitude_of_origin,-41],PARAMETER[central_meridian,173],PARAMETER[false_easting,2510000],PARAMETER[false_northing,6023150],AUTHORITY[EPSG,27200],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}