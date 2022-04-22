namespace EpsgCoordinateSystems.Other
{
    public class Jamaica_1875 : IEpsgCoordinateSystem
    {
        public string Name => "Jamaica 1875";
        public string Units => "Unspecified";
public long Srid => 4241;

        public string OgcWkt =>
            "GEOGCS[Jamaica 1875,DATUM[Jamaica_1875,SPHEROID[Clarke 1880,6378249.144808011,293.4663076556303,AUTHORITY[EPSG,7034]],AUTHORITY[EPSG,6241]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4241]]";

        public string EsriWkt => "GEOGCS[Jamaica 1875,DATUM[D_Jamaica_1875,SPHEROID[Clarke_1880,6378249.144808011,293.4663076556303]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}