namespace EpsgCoordinateSystems.Categories.Other
{
    public class Pulkovo_1942_CS63_zone_A3 : IEpsgCoordinateSystem
    {
        public string Name => "Pulkovo 1942 / CS63 zone A3";
        public string Units => "Unspecified";
public int Srid => 2937;

        public string OgcWkt =>
            "PROJCS[Pulkovo 1942 / CS63 zone A3,GEOGCS[Pulkovo 1942,DATUM[Pulkovo_1942,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6284]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4284]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0.1166666666666667],PARAMETER[central_meridian,47.53333333333333],PARAMETER[scale_factor,1],PARAMETER[false_easting,3300000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2937],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[Pulkovo 1942 / CS63 zone A3,GEOGCS[Pulkovo 1942,DATUM[D_Pulkovo_1942,SPHEROID[Krassowsky_1940,6378245,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0.1166666666666667],PARAMETER[central_meridian,47.53333333333333],PARAMETER[scale_factor,1],PARAMETER[false_easting,3300000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}