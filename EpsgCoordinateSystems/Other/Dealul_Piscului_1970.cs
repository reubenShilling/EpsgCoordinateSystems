namespace EpsgCoordinateSystems.Other
{
    public class Dealul_Piscului_1970 : IEpsgCoordinateSystem
    {
        public string Name => "Dealul Piscului 1970";
        public string Units => "Unspecified";
public long Srid => 4317;

        public string OgcWkt =>
            "GEOGCS[Dealul Piscului 1970,DATUM[Dealul_Piscului_1970,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6317]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4317]]";

        public string EsriWkt => "GEOGCS[Dealul Piscului 1970,DATUM[D_Dealul_Piscului_1970,SPHEROID[Krassowsky_1940,6378245,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}