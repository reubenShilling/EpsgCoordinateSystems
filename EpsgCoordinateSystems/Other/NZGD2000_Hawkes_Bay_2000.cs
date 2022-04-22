namespace EpsgCoordinateSystems.Other
{
    public class NZGD2000_Hawkes_Bay_2000 : IEpsgCoordinateSystem
    {
        public string Name => "NZGD2000 / Hawkes Bay 2000";
        public string Units => "Unspecified";
public long Srid => 2108;

        public string OgcWkt =>
            "PROJCS[NZGD2000 / Hawkes Bay 2000,GEOGCS[NZGD2000,DATUM[New_Zealand_Geodetic_Datum_2000,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6167]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4167]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-39.65083333333333],PARAMETER[central_meridian,176.6736111111111],PARAMETER[scale_factor,1],PARAMETER[false_easting,400000],PARAMETER[false_northing,800000],AUTHORITY[EPSG,2108],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[NZGD2000 / Hawkes Bay 2000,GEOGCS[NZGD2000,DATUM[D_NZGD_2000,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-39.65083333333333],PARAMETER[central_meridian,176.6736111111111],PARAMETER[scale_factor,1],PARAMETER[false_easting,400000],PARAMETER[false_northing,800000],UNIT[Meter,1]]";
    }
}