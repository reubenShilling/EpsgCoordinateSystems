namespace EpsgCoordinateSystems.Other
{
    public class Montserrat_1958_British_West_Indies_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Montserrat 1958 / British West Indies Grid";
        public long Srid => 2004;

        public string OgcWkt =>
            "PROJCS[Montserrat 1958 / British West Indies Grid,GEOGCS[Montserrat 1958,DATUM[Montserrat_1958,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[174,359,365,0,0,0,0],AUTHORITY[EPSG,6604]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4604]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-62],PARAMETER[scale_factor,0.9995],PARAMETER[false_easting,400000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2004],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Montserrat 1958 / British West Indies Grid,GEOGCS[Montserrat 1958,DATUM[Montserrat_1958,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[174,359,365,0,0,0,0],AUTHORITY[EPSG,6604]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4604]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-62],PARAMETER[scale_factor,0.9995],PARAMETER[false_easting,400000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2004],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}