namespace EpsgCoordinateSystems.Other
{
    public class PSAD56_UTM_zone_17S : IEpsgCoordinateSystem
    {
        public string Name => "PSAD56 / UTM zone 17S";
        public string Units => "Unspecified";
public long Srid => 24877;

        public string OgcWkt =>
            "PROJCS[PSAD56 / UTM zone 17S,GEOGCS[PSAD56,DATUM[Provisional_South_American_Datum_1956,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6248]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4248]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-81],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,24877],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[PSAD56 / UTM zone 17S,GEOGCS[PSAD56,DATUM[Provisional_South_American_Datum_1956,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6248]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4248]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-81],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,24877],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}