namespace EpsgCoordinateSystems.Categories.Other
{
    public class Lisbon_Lisbon_Portuguese_National_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Lisbon (Lisbon)/Portuguese National Grid";
        public string Units => "Unspecified";
public int Srid => 20790;

        public string OgcWkt =>
            "PROJCS[Lisbon (Lisbon)/Portuguese National Grid,GEOGCS[Lisbon (Lisbon),DATUM[Lisbon_1937_Lisbon,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6803]],PRIMEM[Lisbon,-9.131906111111112,AUTHORITY[EPSG,8902]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4803]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,39.66666666666666],PARAMETER[central_meridian,1],PARAMETER[scale_factor,1],PARAMETER[false_easting,200000],PARAMETER[false_northing,300000],AUTHORITY[EPSG,20790],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Lisbon (Lisbon)/Portuguese National Grid,GEOGCS[Lisbon (Lisbon),DATUM[D_Lisbon,SPHEROID[International_1924,6378388,297]],PRIMEM[Lisbon,-9.131906111111112],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,39.66666666666666],PARAMETER[central_meridian,1],PARAMETER[scale_factor,1],PARAMETER[false_easting,200000],PARAMETER[false_northing,300000],UNIT[Meter,1]]";
    }
}