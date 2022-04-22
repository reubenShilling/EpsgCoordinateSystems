namespace EpsgCoordinateSystems.Categories.Other
{
    public class South_Yemen_Gauss_Kruger_zone_9 : IEpsgCoordinateSystem
    {
        public string Name => "South Yemen / Gauss-Kruger zone 9";
        public string Units => "Unspecified";
public int Srid => 2396;

        public string OgcWkt =>
            "PROJCS[South Yemen / Gauss-Kruger zone 9,GEOGCS[South Yemen,DATUM[South_Yemen,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[-76,-138,67,0,0,0,0],AUTHORITY[EPSG,6164]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4164]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,51],PARAMETER[scale_factor,1],PARAMETER[false_easting,9500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2396],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[South Yemen / Gauss-Kruger zone 9,GEOGCS[South Yemen,DATUM[D_South_Yemen,SPHEROID[Krassowsky_1940,6378245,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,51],PARAMETER[scale_factor,1],PARAMETER[false_easting,9500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}