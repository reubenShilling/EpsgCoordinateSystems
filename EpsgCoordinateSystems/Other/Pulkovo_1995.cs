namespace EpsgCoordinateSystems.Other
{
    public class Pulkovo_1995 : IEpsgCoordinateSystem
    {
        public string Name => "Pulkovo 1995";
        public string Units => "Unspecified";
public long Srid => 4200;

        public string OgcWkt =>
            "GEOGCS[Pulkovo 1995,DATUM[Pulkovo_1995,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6200]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4200]]";

        public string EsriWkt =>
            "GEOGCS[Pulkovo 1995,DATUM[Pulkovo_1995,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6200]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4200]]";
    }
}