namespace EpsgCoordinateSystems.Other
{
    public class ETRS89_Kp2000_Jutland : IEpsgCoordinateSystem
    {
        public string Name => "ETRS89 / Kp2000 Jutland";
        public string Units => "Unspecified";
public long Srid => 2196;

        public string OgcWkt =>
            "PROJCS[ETRS89 / Kp2000 Jutland,GEOGCS[ETRS89,DATUM[European_Terrestrial_Reference_System_1989,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4258]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,9.5],PARAMETER[scale_factor,0.99995],PARAMETER[false_easting,200000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2196],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[ETRS89 / Kp2000 Jutland,GEOGCS[ETRS89,DATUM[D_ETRS_1989,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,9.5],PARAMETER[scale_factor,0.99995],PARAMETER[false_easting,200000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}