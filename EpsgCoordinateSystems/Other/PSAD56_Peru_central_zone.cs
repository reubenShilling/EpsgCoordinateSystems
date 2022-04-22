namespace EpsgCoordinateSystems.Other
{
    public class PSAD56_Peru_central_zone : IEpsgCoordinateSystem
    {
        public string Name => "PSAD56 / Peru central zone";
        public string Units => "Unspecified";
public long Srid => 24892;

        public string OgcWkt =>
            "PROJCS[PSAD56 / Peru central zone,GEOGCS[PSAD56,DATUM[Provisional_South_American_Datum_1956,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6248]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4248]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-9.5],PARAMETER[central_meridian,-76],PARAMETER[scale_factor,0.99932994],PARAMETER[false_easting,720000],PARAMETER[false_northing,1039979.159],AUTHORITY[EPSG,24892],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[PSAD56 / Peru central zone,GEOGCS[PSAD56,DATUM[D_Provisional_S_American_1956,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-9.5],PARAMETER[central_meridian,-76],PARAMETER[scale_factor,0.99932994],PARAMETER[false_easting,720000],PARAMETER[false_northing,1039979.159],UNIT[Meter,1]]";
    }
}