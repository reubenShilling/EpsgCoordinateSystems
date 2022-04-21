namespace EpsgCoordinateSystems.Other
{
    public class RD_83_Gauss_Kruger_zone_4 : IEpsgCoordinateSystem
    {
        public string Name => "RD/83 / Gauss-Kruger zone 4";
        public long Srid => 3398;

        public string OgcWkt =>
            "PROJCS[RD/83 / Gauss-Kruger zone 4,GEOGCS[RD/83,DATUM[Rauenberg_Datum_83,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6745]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4745]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,12],PARAMETER[scale_factor,1],PARAMETER[false_easting,4500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3398],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[RD/83 / Gauss-Kruger zone 4,GEOGCS[RD/83,DATUM[Rauenberg_Datum_83,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6745]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4745]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,12],PARAMETER[scale_factor,1],PARAMETER[false_easting,4500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3398],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}