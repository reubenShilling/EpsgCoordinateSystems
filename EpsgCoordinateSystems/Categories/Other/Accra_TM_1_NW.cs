namespace EpsgCoordinateSystems.Categories.Other
{
    public class Accra_TM_1_NW : IEpsgCoordinateSystem
    {
        public string Name => "Accra / TM 1 NW";
        public string Units => "Unspecified";
        public int Srid => 2137;

        public string OgcWkt =>
            "PROJCS[Accra / TM 1 NW,GEOGCS[Accra,DATUM[Accra,SPHEROID[War Office,6378300,296,AUTHORITY[EPSG,7029]],TOWGS84[-199,32,322,0,0,0,0],AUTHORITY[EPSG,6168]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4168]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-1],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2137],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Accra / TM 1 NW,GEOGCS[Accra,DATUM[D_Accra,SPHEROID[War_Office,6378300,296]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-1],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}