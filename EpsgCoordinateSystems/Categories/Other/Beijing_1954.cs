namespace EpsgCoordinateSystems.Categories.Other
{
    public class Beijing_1954 : IEpsgCoordinateSystem
    {
        public string Name => "Beijing 1954";
        public string Units => "Unspecified";
public int Srid => 4214;

        public string OgcWkt =>
            "GEOGCS[Beijing 1954,DATUM[Beijing_1954,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],AUTHORITY[EPSG,6214]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4214]]";

        public string EsriWkt => "GEOGCS[Beijing 1954,DATUM[D_Beijing_1954,SPHEROID[Krassowsky_1940,6378245,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}