namespace EpsgCoordinateSystems.Other
{
    public class Pulkovo_1942_83_Gauss_Kruger_zone_5 : IEpsgCoordinateSystem
    {
        public string Name => "Pulkovo 1942(83) / Gauss-Kruger zone 5";
        public long Srid => 2399;

        public string OgcWkt =>
            "PROJCS[Pulkovo 1942(83) / Gauss-Kruger zone 5,GEOGCS[Pulkovo 1942(83),DATUM[Pulkovo_1942_83,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[24,-123,-94,0.02,-0.25,-0.13,1.1],AUTHORITY[EPSG,6178]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4178]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,1],PARAMETER[false_easting,5500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2399],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Pulkovo 1942(83) / Gauss-Kruger zone 5,GEOGCS[Pulkovo 1942(83),DATUM[Pulkovo_1942_83,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[24,-123,-94,0.02,-0.25,-0.13,1.1],AUTHORITY[EPSG,6178]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4178]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,1],PARAMETER[false_easting,5500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2399],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}