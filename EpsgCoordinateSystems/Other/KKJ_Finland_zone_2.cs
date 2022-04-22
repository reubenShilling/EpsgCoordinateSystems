namespace EpsgCoordinateSystems.Other
{
    public class KKJ_Finland_zone_2 : IEpsgCoordinateSystem
    {
        public string Name => "KKJ / Finland zone 2";
        public string Units => "Unspecified";
public long Srid => 2392;

        public string OgcWkt =>
            "PROJCS[KKJ / Finland zone 2,GEOGCS[KKJ,DATUM[Kartastokoordinaattijarjestelma_1966,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6123]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4123]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,24],PARAMETER[scale_factor,1],PARAMETER[false_easting,2500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2392],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[KKJ / Finland zone 2,GEOGCS[KKJ,DATUM[Kartastokoordinaattijarjestelma_1966,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6123]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4123]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,24],PARAMETER[scale_factor,1],PARAMETER[false_easting,2500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2392],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}