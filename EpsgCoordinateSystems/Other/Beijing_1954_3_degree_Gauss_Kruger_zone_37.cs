namespace EpsgCoordinateSystems.Other
{
    public class Beijing_1954_3_degree_Gauss_Kruger_zone_37 : IEpsgCoordinateSystem
    {
        public string Name => "Beijing 1954 / 3-degree Gauss-Kruger zone 37";
        public string Units => "Unspecified";
public long Srid => 2413;

        public string OgcWkt =>
            "PROJCS[Beijing 1954 / 3-degree Gauss-Kruger zone 37,GEOGCS[Beijing 1954,DATUM[Beijing_1954,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6214]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4214]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,111],PARAMETER[scale_factor,1],PARAMETER[false_easting,37500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2413],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[Beijing 1954 / 3-degree Gauss-Kruger zone 37,GEOGCS[Beijing 1954,DATUM[D_Beijing_1954,SPHEROID[Krassowsky_1940,6378245,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,111],PARAMETER[scale_factor,1],PARAMETER[false_easting,37500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}