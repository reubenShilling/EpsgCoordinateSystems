namespace EpsgCoordinateSystems.Other
{
    public class Qatar_1974_Qatar_National_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Qatar 1974 / Qatar National Grid";
        public long Srid => 28600;

        public string OgcWkt =>
            "PROJCS[Qatar 1974 / Qatar National Grid,GEOGCS[Qatar 1974,DATUM[Qatar_1974,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6285]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4285]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,24.45],PARAMETER[central_meridian,51.21666666666667],PARAMETER[scale_factor,0.99999],PARAMETER[false_easting,200000],PARAMETER[false_northing,300000],AUTHORITY[EPSG,28600],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Qatar 1974 / Qatar National Grid,GEOGCS[Qatar 1974,DATUM[Qatar_1974,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6285]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4285]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,24.45],PARAMETER[central_meridian,51.21666666666667],PARAMETER[scale_factor,0.99999],PARAMETER[false_easting,200000],PARAMETER[false_northing,300000],AUTHORITY[EPSG,28600],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}