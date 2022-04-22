namespace EpsgCoordinateSystems.Other
{
    public class Kousseri : IEpsgCoordinateSystem
    {
        public string Name => "Kousseri";
        public string Units => "Unspecified";
public long Srid => 4198;

        public string OgcWkt =>
            "GEOGCS[Kousseri,DATUM[Kousseri,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6198]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4198]]";

        public string EsriWkt => "GEOGCS[Kousseri,DATUM[D_Kousseri,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}