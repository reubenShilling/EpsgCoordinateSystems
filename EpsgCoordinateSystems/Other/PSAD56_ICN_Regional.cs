namespace EpsgCoordinateSystems.Other
{
    public class PSAD56_ICN_Regional : IEpsgCoordinateSystem
    {
        public string Name => "PSAD56 / ICN Regional";
        public string Units => "Unspecified";
public long Srid => 2317;

        public string OgcWkt =>
            "PROJCS[PSAD56 / ICN Regional,GEOGCS[PSAD56,DATUM[Provisional_South_American_Datum_1956,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6248]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4248]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,9],PARAMETER[standard_parallel_2,3],PARAMETER[latitude_of_origin,6],PARAMETER[central_meridian,-66],PARAMETER[false_easting,1000000],PARAMETER[false_northing,1000000],AUTHORITY[EPSG,2317],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[PSAD56 / ICN Regional,GEOGCS[PSAD56,DATUM[D_Provisional_S_American_1956,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,9],PARAMETER[standard_parallel_2,3],PARAMETER[latitude_of_origin,6],PARAMETER[central_meridian,-66],PARAMETER[false_easting,1000000],PARAMETER[false_northing,1000000],UNIT[Meter,1]]";
    }
}