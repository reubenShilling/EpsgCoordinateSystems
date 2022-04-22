namespace EpsgCoordinateSystems.Other
{
    public class Minna : IEpsgCoordinateSystem
    {
        public string Name => "Minna";
        public string Units => "Unspecified";
public long Srid => 4263;

        public string OgcWkt =>
            "GEOGCS[Minna,DATUM[Minna,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6263]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4263]]";

        public string EsriWkt => "GEOGCS[Minna,DATUM[D_Minna,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}