namespace EpsgCoordinateSystems.Other
{
    public class Barbados_1938_Barbados_National_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Barbados 1938 / Barbados National Grid";
        public string Units => "Unspecified";
public long Srid => 21292;

        public string OgcWkt =>
            "PROJCS[Barbados 1938 / Barbados National Grid,GEOGCS[Barbados 1938,DATUM[Barbados_1938,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[31.95,300.99,419.19,0,0,0,0],AUTHORITY[EPSG,6212]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4212]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,13.17638888888889],PARAMETER[central_meridian,-59.55972222222222],PARAMETER[scale_factor,0.9999986],PARAMETER[false_easting,30000],PARAMETER[false_northing,75000],AUTHORITY[EPSG,21292],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Barbados 1938 / Barbados National Grid,GEOGCS[Barbados 1938,DATUM[Barbados_1938,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[31.95,300.99,419.19,0,0,0,0],AUTHORITY[EPSG,6212]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4212]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,13.17638888888889],PARAMETER[central_meridian,-59.55972222222222],PARAMETER[scale_factor,0.9999986],PARAMETER[false_easting,30000],PARAMETER[false_northing,75000],AUTHORITY[EPSG,21292],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}