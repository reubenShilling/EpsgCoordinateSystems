namespace EpsgCoordinateSystems.Other
{
    public class Egypt_1907_Purple_Belt : IEpsgCoordinateSystem
    {
        public string Name => "Egypt 1907 / Purple Belt";
        public string Units => "Unspecified";
public long Srid => 22993;

        public string OgcWkt =>
            "PROJCS[Egypt 1907 / Purple Belt,GEOGCS[Egypt 1907,DATUM[Egypt_1907,SPHEROID[Helmert 1906,6378200,298.3,AUTHORITY[EPSG,7020]],AUTHORITY[EPSG,6229]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4229]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,30],PARAMETER[central_meridian,27],PARAMETER[scale_factor,1],PARAMETER[false_easting,700000],PARAMETER[false_northing,200000],AUTHORITY[EPSG,22993],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Egypt 1907 / Purple Belt,GEOGCS[Egypt 1907,DATUM[Egypt_1907,SPHEROID[Helmert 1906,6378200,298.3,AUTHORITY[EPSG,7020]],AUTHORITY[EPSG,6229]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4229]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,30],PARAMETER[central_meridian,27],PARAMETER[scale_factor,1],PARAMETER[false_easting,700000],PARAMETER[false_northing,200000],AUTHORITY[EPSG,22993],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}