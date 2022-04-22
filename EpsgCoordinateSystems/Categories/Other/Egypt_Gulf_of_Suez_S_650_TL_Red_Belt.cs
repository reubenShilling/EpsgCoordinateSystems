namespace EpsgCoordinateSystems.Categories.Other
{
    public class Egypt_Gulf_of_Suez_S_650_TL_Red_Belt : IEpsgCoordinateSystem
    {
        public string Name => "Egypt Gulf of Suez S-650 TL / Red Belt";
        public string Units => "Unspecified";
public int Srid => 3355;

        public string OgcWkt =>
            "PROJCS[Egypt Gulf of Suez S-650 TL / Red Belt,GEOGCS[Egypt Gulf of Suez S-650 TL,DATUM[Egypt_Gulf_of_Suez_S_650_TL,SPHEROID[Helmert 1906,6378200,298.3,AUTHORITY[EPSG,7020]],TOWGS84[-146.21,112.63,4.05,0,0,0,0],AUTHORITY[EPSG,6706]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4706]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,30],PARAMETER[central_meridian,31],PARAMETER[scale_factor,1],PARAMETER[false_easting,615000],PARAMETER[false_northing,810000],AUTHORITY[EPSG,3355],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Egypt Gulf of Suez S-650 TL / Red Belt,GEOGCS[Egypt Gulf of Suez S-650 TL,DATUM[D_Egypt_Gulf_of_Suez_S-650_TL,SPHEROID[Helmert_1906,6378200,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,30],PARAMETER[central_meridian,31],PARAMETER[scale_factor,1],PARAMETER[false_easting,615000],PARAMETER[false_northing,810000],UNIT[Meter,1]]";
    }
}