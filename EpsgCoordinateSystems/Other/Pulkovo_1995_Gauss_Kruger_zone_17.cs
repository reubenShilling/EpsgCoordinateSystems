namespace EpsgCoordinateSystems.Other
{
    public class Pulkovo_1995_Gauss_Kruger_zone_17 : IEpsgCoordinateSystem
    {
        public string Name => "Pulkovo 1995 / Gauss-Kruger zone 17";
        public long Srid => 20017;

        public string OgcWkt =>
            "PROJCS[Pulkovo 1995 / Gauss-Kruger zone 17,GEOGCS[Pulkovo 1995,DATUM[Pulkovo_1995,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6200]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4200]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,99],PARAMETER[scale_factor,1],PARAMETER[false_easting,17500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,20017],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Pulkovo 1995 / Gauss-Kruger zone 17,GEOGCS[Pulkovo 1995,DATUM[Pulkovo_1995,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6200]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4200]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,99],PARAMETER[scale_factor,1],PARAMETER[false_easting,17500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,20017],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}