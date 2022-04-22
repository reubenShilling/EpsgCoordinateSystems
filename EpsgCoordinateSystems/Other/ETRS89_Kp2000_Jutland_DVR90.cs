namespace EpsgCoordinateSystems.Other
{
    public class ETRS89_Kp2000_Jutland_DVR90 : IEpsgCoordinateSystem
    {
        public string Name => "ETRS89 / Kp2000 Jutland + DVR90";
        public string Units => "Unspecified";
public long Srid => 7418;

        public string OgcWkt =>
            "COMPD_CS[ETRS89 / Kp2000 Jutland + DVR90,PROJCS[ETRS89 / Kp2000 Jutland,GEOGCS[ETRS89,DATUM[European Terrestrial Reference System 1989,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4258]],PROJECTION[Transverse Mercator,AUTHORITY[EPSG,9807]],PARAMETER[central_meridian,9.5],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,0.99995],PARAMETER[false_easting,200000.0],PARAMETER[false_northing,0.0],UNIT[m,1.0],AXIS[Easting,EAST],AXIS[Northing,NORTH],AUTHORITY[EPSG,2196]],VERT_CS[DVR90,VERT_DATUM[Dansk Vertikal Reference 1990,2005,AUTHORITY[EPSG,5206]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5799]],AUTHORITY[EPSG,7418]]";

        public string EsriWkt => "COMPD_CS[ETRS89 / Kp2000 Jutland + DVR90,PROJCS[ETRS89 / Kp2000 Jutland,GEOGCS[ETRS89,DATUM[D_European Terrestrial Reference System 1989,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse Mercator],PARAMETER[central_meridian,9.5],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,0.99995],PARAMETER[false_easting,200000.0],PARAMETER[false_northing,0.0],UNIT[m,1.0]],VERT_CS[DVR90,VERT_DATUM[Dansk Vertikal Reference 1990,2005],UNIT[m,1.0]]]";
    }
}