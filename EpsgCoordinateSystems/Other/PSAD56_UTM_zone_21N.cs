namespace EpsgCoordinateSystems.Other
{
    public class PSAD56_UTM_zone_21N : IEpsgCoordinateSystem
    {
        public string Name => "PSAD56 / UTM zone 21N";
        public string Units => "Unspecified";
public long Srid => 24821;

        public string OgcWkt =>
            "PROJCS[PSAD56 / UTM zone 21N,GEOGCS[PSAD56,DATUM[Provisional_South_American_Datum_1956,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6248]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4248]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-57],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,24821],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[PSAD56 / UTM zone 21N,GEOGCS[PSAD56,DATUM[Provisional_South_American_Datum_1956,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6248]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4248]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-57],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,24821],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}