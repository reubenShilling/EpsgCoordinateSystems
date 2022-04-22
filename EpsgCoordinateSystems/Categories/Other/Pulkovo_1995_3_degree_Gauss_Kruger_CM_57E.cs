namespace EpsgCoordinateSystems.Categories.Other
{
    public class Pulkovo_1995_3_degree_Gauss_Kruger_CM_57E : IEpsgCoordinateSystem
    {
        public string Name => "Pulkovo 1995 / 3-degree Gauss-Kruger CM 57E";
        public string Units => "Unspecified";
public int Srid => 2711;

        public string OgcWkt =>
            "PROJCS[Pulkovo 1995 / 3-degree Gauss-Kruger CM 57E,GEOGCS[Pulkovo 1995,DATUM[Pulkovo_1995,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6200]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4200]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,57],PARAMETER[scale_factor,1],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2711],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[Pulkovo 1995 / 3-degree Gauss-Kruger CM 57E,GEOGCS[Pulkovo 1995,DATUM[D_Pulkovo_1995,SPHEROID[Krassowsky_1940,6378245,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,57],PARAMETER[scale_factor,1],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}