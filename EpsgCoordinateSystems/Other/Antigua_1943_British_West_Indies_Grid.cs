namespace EpsgCoordinateSystems.Other
{
    public class Antigua_1943_British_West_Indies_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Antigua 1943 / British West Indies Grid";
        public string Units => "Unspecified";
public long Srid => 2001;

        public string OgcWkt =>
            "PROJCS[Antigua 1943 / British West Indies Grid,GEOGCS[Antigua 1943,DATUM[Antigua_1943,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6601]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4601]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-62],PARAMETER[scale_factor,0.9995],PARAMETER[false_easting,400000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2001],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Antigua 1943 / British West Indies Grid,GEOGCS[Antigua 1943,DATUM[Antigua_1943,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6601]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4601]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-62],PARAMETER[scale_factor,0.9995],PARAMETER[false_easting,400000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2001],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}