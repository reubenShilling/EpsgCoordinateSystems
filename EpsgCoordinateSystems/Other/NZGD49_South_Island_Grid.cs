namespace EpsgCoordinateSystems.Other
{
    public class NZGD49_South_Island_Grid : IEpsgCoordinateSystem
    {
        public string Name => "NZGD49 / South Island Grid";
        public long Srid => 27292;

        public string OgcWkt =>
            "PROJCS[NZGD49 / South Island Grid,GEOGCS[NZGD49,DATUM[New_Zealand_Geodetic_Datum_1949,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[59.47,-5.04,187.44,0.47,-0.1,1.024,-4.5993],AUTHORITY[EPSG,6272]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4272]],UNIT[British yard (Sears 1922),0.9143984146160287,AUTHORITY[EPSG,9040]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-44],PARAMETER[central_meridian,171.5],PARAMETER[scale_factor,1],PARAMETER[false_easting,500000],PARAMETER[false_northing,500000],AUTHORITY[EPSG,27292],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NZGD49 / South Island Grid,GEOGCS[NZGD49,DATUM[New_Zealand_Geodetic_Datum_1949,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[59.47,-5.04,187.44,0.47,-0.1,1.024,-4.5993],AUTHORITY[EPSG,6272]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4272]],UNIT[British yard (Sears 1922),0.9143984146160287,AUTHORITY[EPSG,9040]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-44],PARAMETER[central_meridian,171.5],PARAMETER[scale_factor,1],PARAMETER[false_easting,500000],PARAMETER[false_northing,500000],AUTHORITY[EPSG,27292],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}