namespace EpsgCoordinateSystems.Other
{
    public class NZGD2000_New_Zealand_Transverse_Mercator_2000 : IEpsgCoordinateSystem
    {
        public string Name => "NZGD2000 / New Zealand Transverse Mercator 2000";
        public string Units => "Unspecified";
public long Srid => 2193;

        public string OgcWkt =>
            "PROJCS[NZGD2000 / New Zealand Transverse Mercator 2000,GEOGCS[NZGD2000,DATUM[New_Zealand_Geodetic_Datum_2000,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6167]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4167]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,173],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,1600000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,2193],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[NZGD2000 / New Zealand Transverse Mercator 2000,GEOGCS[NZGD2000,DATUM[D_NZGD_2000,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,173],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,1600000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}