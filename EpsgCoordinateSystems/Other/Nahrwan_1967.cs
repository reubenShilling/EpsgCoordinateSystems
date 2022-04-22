namespace EpsgCoordinateSystems.Other
{
    public class Nahrwan_1967 : IEpsgCoordinateSystem
    {
        public string Name => "Nahrwan 1967";
        public string Units => "Unspecified";
public long Srid => 4270;

        public string OgcWkt =>
            "GEOGCS[Nahrwan 1967,DATUM[Nahrwan_1967,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6270]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4270]]";

        public string EsriWkt => "GEOGCS[Nahrwan 1967,DATUM[D_Nahrwan_1967,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}