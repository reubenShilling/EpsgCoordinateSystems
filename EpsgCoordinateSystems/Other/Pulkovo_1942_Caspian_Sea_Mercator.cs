namespace EpsgCoordinateSystems.Other
{
    public class Pulkovo_1942_Caspian_Sea_Mercator : IEpsgCoordinateSystem
    {
        public string Name => "Pulkovo 1942 / Caspian Sea Mercator";
        public string Units => "Unspecified";
public long Srid => 3388;

        public string OgcWkt =>
            "PROJCS[Pulkovo 1942 / Caspian Sea Mercator,GEOGCS[Pulkovo 1942,DATUM[Pulkovo_1942,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6284]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4284]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Mercator_1SP],PARAMETER[central_meridian,51],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3388],AXIS[none,EAST],AXIS[none,NORTH]]";

        public string EsriWkt => "PROJCS[Pulkovo 1942 / Caspian Sea Mercator,GEOGCS[Pulkovo 1942,DATUM[D_Pulkovo_1942,SPHEROID[Krassowsky_1940,6378245,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Mercator],PARAMETER[central_meridian,51],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}