namespace EpsgCoordinateSystems.Other
{
    public class Nord_Sahara_1959 : IEpsgCoordinateSystem
    {
        public string Name => "Nord Sahara 1959";
        public string Units => "Unspecified";
public long Srid => 4307;

        public string OgcWkt =>
            "GEOGCS[Nord Sahara 1959,DATUM[Nord_Sahara_1959,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6307]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4307]]";

        public string EsriWkt => "GEOGCS[Nord Sahara 1959,DATUM[D_Nord_Sahara_1959,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}