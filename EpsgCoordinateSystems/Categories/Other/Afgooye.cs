namespace EpsgCoordinateSystems.Categories.Other
{
    public class Afgooye : IEpsgCoordinateSystem
    {
        public string Name => "Afgooye";
        public string Units => "Unspecified";
public int Srid => 4205;

        public string OgcWkt =>
            "GEOGCS[Afgooye,DATUM[Afgooye,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[-43,-163,45,0,0,0,0],AUTHORITY[EPSG,6205]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4205]]";

        public string EsriWkt => "GEOGCS[Afgooye,DATUM[D_Afgooye,SPHEROID[Krassowsky_1940,6378245,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}