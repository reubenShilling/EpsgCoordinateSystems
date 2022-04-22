namespace EpsgCoordinateSystems.Other
{
    public class Grenada_1953_British_West_Indies_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Grenada 1953 / British West Indies Grid";
        public string Units => "Unspecified";
public long Srid => 2003;

        public string OgcWkt =>
            "PROJCS[Grenada 1953 / British West Indies Grid,GEOGCS[Grenada 1953,DATUM[Grenada_1953,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[72,213.7,93,0,0,0,0],AUTHORITY[EPSG,6603]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4603]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-62],PARAMETER[scale_factor,0.9995],PARAMETER[false_easting,400000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2003],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Grenada 1953 / British West Indies Grid,GEOGCS[Grenada 1953,DATUM[Grenada_1953,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[72,213.7,93,0,0,0,0],AUTHORITY[EPSG,6603]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4603]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-62],PARAMETER[scale_factor,0.9995],PARAMETER[false_easting,400000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2003],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}