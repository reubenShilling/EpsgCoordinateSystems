namespace EpsgCoordinateSystems.Other
{
    public class Pulkovo_1942 : IEpsgCoordinateSystem
    {
        public string Name => "Pulkovo 1942";
        public string Units => "Unspecified";
public long Srid => 4284;

        public string OgcWkt =>
            "GEOGCS[Pulkovo 1942,DATUM[Pulkovo_1942,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6284]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4284]]";

        public string EsriWkt => "GEOGCS[Pulkovo 1942,DATUM[D_Pulkovo_1942,SPHEROID[Krassowsky_1940,6378245,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}