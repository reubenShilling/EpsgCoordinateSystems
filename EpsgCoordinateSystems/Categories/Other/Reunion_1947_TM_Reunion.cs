namespace EpsgCoordinateSystems.Categories.Other
{
    public class Reunion_1947_TM_Reunion : IEpsgCoordinateSystem
    {
        public string Name => "Reunion 1947 / TM Reunion";
        public string Units => "Unspecified";
public int Srid => 3727;

        public string OgcWkt =>
            "PROJCS[Reunion 1947 / TM Reunion,GEOGCS[Reunion 1947,DATUM[Reunion_1947,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6626]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4626]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-21.11666666666667],PARAMETER[central_meridian,55.53333333333333],PARAMETER[scale_factor,1],PARAMETER[false_easting,160000],PARAMETER[false_northing,50000],AUTHORITY[EPSG,3727],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Reunion 1947 / TM Reunion,GEOGCS[Reunion 1947,DATUM[D_Reunion_1947,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-21.11666666666667],PARAMETER[central_meridian,55.53333333333333],PARAMETER[scale_factor,1],PARAMETER[false_easting,160000],PARAMETER[false_northing,50000],UNIT[Meter,1]]";
    }
}