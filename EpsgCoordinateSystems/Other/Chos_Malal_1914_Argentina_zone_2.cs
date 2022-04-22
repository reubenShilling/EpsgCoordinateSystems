namespace EpsgCoordinateSystems.Other
{
    public class Chos_Malal_1914_Argentina_zone_2 : IEpsgCoordinateSystem
    {
        public string Name => "Chos Malal 1914 / Argentina zone 2";
        public string Units => "Unspecified";
public long Srid => 2081;

        public string OgcWkt =>
            "PROJCS[Chos Malal 1914 / Argentina zone 2,GEOGCS[Chos Malal 1914,DATUM[Chos_Malal_1914,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6160]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4160]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,-69],PARAMETER[scale_factor,1],PARAMETER[false_easting,2500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2081],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Chos Malal 1914 / Argentina zone 2,GEOGCS[Chos Malal 1914,DATUM[Chos_Malal_1914,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6160]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4160]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,-69],PARAMETER[scale_factor,1],PARAMETER[false_easting,2500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2081],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}