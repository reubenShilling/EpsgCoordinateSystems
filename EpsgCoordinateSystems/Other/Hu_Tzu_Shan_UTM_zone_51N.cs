namespace EpsgCoordinateSystems.Other
{
    public class Hu_Tzu_Shan_UTM_zone_51N : IEpsgCoordinateSystem
    {
        public string Name => "Hu Tzu Shan / UTM zone 51N";
        public string Units => "Unspecified";
public long Srid => 3829;

        public string OgcWkt =>
            "PROJCS[Hu Tzu Shan / UTM zone 51N,GEOGCS[Hu Tzu Shan 1950,DATUM[Hu Tzu Shan 1950,SPHEROID[International 1924,6378388.0,297.0,AUTHORITY[EPSG,7022]],TOWGS84[-637.0,-549.0,-203.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6236]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4236]],PROJECTION[Transverse Mercator,AUTHORITY[EPSG,9807]],PARAMETER[central_meridian,123.0],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000.0],PARAMETER[false_northing,0.0],UNIT[m,1.0],AXIS[Easting,EAST],AXIS[Northing,NORTH],AUTHORITY[EPSG,3829]]";

        public string EsriWkt => "PROJCS[Hu Tzu Shan / UTM zone 51N,GEOGCS[Hu Tzu Shan 1950,DATUM[D_Hu Tzu Shan 1950,SPHEROID[International_1924,6378388.0,297.0]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse Mercator],PARAMETER[central_meridian,123.0],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000.0],PARAMETER[false_northing,0.0],UNIT[m,1.0]]";
    }
}