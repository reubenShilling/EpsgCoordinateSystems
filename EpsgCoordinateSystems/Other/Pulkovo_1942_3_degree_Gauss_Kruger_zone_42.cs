namespace EpsgCoordinateSystems.Other
{
    public class Pulkovo_1942_3_degree_Gauss_Kruger_zone_42 : IEpsgCoordinateSystem
    {
        public string Name => "Pulkovo 1942 / 3-degree Gauss-Kruger zone 42";
        public string Units => "Unspecified";
public long Srid => 2559;

        public string OgcWkt =>
            "PROJCS[Pulkovo 1942 / 3-degree Gauss-Kruger zone 42,GEOGCS[Pulkovo 1942,DATUM[Pulkovo_1942,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6284]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4284]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,126],PARAMETER[scale_factor,1],PARAMETER[false_easting,42500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2559],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Pulkovo 1942 / 3-degree Gauss-Kruger zone 42,GEOGCS[Pulkovo 1942,DATUM[Pulkovo_1942,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6284]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4284]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,126],PARAMETER[scale_factor,1],PARAMETER[false_easting,42500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2559],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}