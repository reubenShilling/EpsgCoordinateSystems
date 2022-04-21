namespace EpsgCoordinateSystems.Other
{
    public class Barbados_1938_British_West_Indies_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Barbados 1938 / British West Indies Grid";
        public long Srid => 21291;

        public string OgcWkt =>
            "PROJCS[Barbados 1938 / British West Indies Grid,GEOGCS[Barbados 1938,DATUM[Barbados_1938,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[31.95,300.99,419.19,0,0,0,0],AUTHORITY[EPSG,6212]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4212]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-62],PARAMETER[scale_factor,0.9995],PARAMETER[false_easting,400000],PARAMETER[false_northing,0],AUTHORITY[EPSG,21291],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Barbados 1938 / British West Indies Grid,GEOGCS[Barbados 1938,DATUM[Barbados_1938,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[31.95,300.99,419.19,0,0,0,0],AUTHORITY[EPSG,6212]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4212]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-62],PARAMETER[scale_factor,0.9995],PARAMETER[false_easting,400000],PARAMETER[false_northing,0],AUTHORITY[EPSG,21291],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}