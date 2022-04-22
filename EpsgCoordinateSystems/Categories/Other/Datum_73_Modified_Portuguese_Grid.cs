namespace EpsgCoordinateSystems.Categories.Other
{
    public class Datum_73_Modified_Portuguese_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Datum 73 / Modified Portuguese Grid";
        public string Units => "Unspecified";
public int Srid => 27493;

        public string OgcWkt =>
            "PROJCS[Datum 73 / Modified Portuguese Grid,GEOGCS[Datum 73,DATUM[Datum_73,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6274]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4274]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,39.66666666666666],PARAMETER[central_meridian,-8.131906111111112],PARAMETER[scale_factor,1],PARAMETER[false_easting,180.598],PARAMETER[false_northing,-86.99],AUTHORITY[EPSG,27493],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Datum 73 / Modified Portuguese Grid,GEOGCS[Datum 73,DATUM[D_Datum_73,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,39.66666666666666],PARAMETER[central_meridian,-8.131906111111112],PARAMETER[scale_factor,1],PARAMETER[false_easting,180.598],PARAMETER[false_northing,-86.99],UNIT[Meter,1]]";
    }
}