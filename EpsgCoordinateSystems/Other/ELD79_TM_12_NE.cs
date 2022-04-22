namespace EpsgCoordinateSystems.Other
{
    public class ELD79_TM_12_NE : IEpsgCoordinateSystem
    {
        public string Name => "ELD79 / TM 12 NE";
        public string Units => "Unspecified";
public long Srid => 2087;

        public string OgcWkt =>
            "PROJCS[ELD79 / TM 12 NE,GEOGCS[ELD79,DATUM[European_Libyan_Datum_1979,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6159]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4159]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,12],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2087],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[ELD79 / TM 12 NE,GEOGCS[ELD79,DATUM[D_European_Libyan_1979,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,12],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}