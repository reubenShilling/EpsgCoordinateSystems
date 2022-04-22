namespace EpsgCoordinateSystems.Other
{
    public class Vientiane_1982 : IEpsgCoordinateSystem
    {
        public string Name => "Vientiane 1982";
        public string Units => "Unspecified";
public long Srid => 4676;

        public string OgcWkt =>
            "GEOGCS[Vientiane 1982,DATUM[Vientiane_1982,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6676]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4676]]";

        public string EsriWkt => "GEOGCS[Vientiane 1982,DATUM[D_Vientiane_1982,SPHEROID[Krassowsky_1940,6378245,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}