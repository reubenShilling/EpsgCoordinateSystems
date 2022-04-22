namespace EpsgCoordinateSystems.Other
{
    public class PSAD56_Peru_west_zone : IEpsgCoordinateSystem
    {
        public string Name => "PSAD56 / Peru west zone";
        public string Units => "Unspecified";
public long Srid => 24891;

        public string OgcWkt =>
            "PROJCS[PSAD56 / Peru west zone,GEOGCS[PSAD56,DATUM[Provisional_South_American_Datum_1956,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6248]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4248]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-6],PARAMETER[central_meridian,-80.5],PARAMETER[scale_factor,0.99983008],PARAMETER[false_easting,222000],PARAMETER[false_northing,1426834.743],AUTHORITY[EPSG,24891],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[PSAD56 / Peru west zone,GEOGCS[PSAD56,DATUM[D_Provisional_S_American_1956,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-6],PARAMETER[central_meridian,-80.5],PARAMETER[scale_factor,0.99983008],PARAMETER[false_easting,222000],PARAMETER[false_northing,1426834.743],UNIT[Meter,1]]";
    }
}