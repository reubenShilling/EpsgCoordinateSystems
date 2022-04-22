namespace EpsgCoordinateSystems.Other
{
    public class Xian_1980_3_degree_Gauss_Kruger_zone_35 : IEpsgCoordinateSystem
    {
        public string Name => "Xian 1980 / 3-degree Gauss-Kruger zone 35";
        public string Units => "Unspecified";
public long Srid => 2359;

        public string OgcWkt =>
            "PROJCS[Xian 1980 / 3-degree Gauss-Kruger zone 35,GEOGCS[Xian 1980,DATUM[Xian_1980,SPHEROID[Xian 1980,6378140,298.257,AUTHORITY[EPSG,7049]],AUTHORITY[EPSG,6610]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4610]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,105],PARAMETER[scale_factor,1],PARAMETER[false_easting,35500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2359],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Xian 1980 / 3-degree Gauss-Kruger zone 35,GEOGCS[Xian 1980,DATUM[Xian_1980,SPHEROID[Xian 1980,6378140,298.257,AUTHORITY[EPSG,7049]],AUTHORITY[EPSG,6610]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4610]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,105],PARAMETER[scale_factor,1],PARAMETER[false_easting,35500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2359],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}