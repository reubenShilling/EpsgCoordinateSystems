namespace EpsgCoordinateSystems.Categories.Other
{
    public class Fahud : IEpsgCoordinateSystem
    {
        public string Name => "Fahud";
        public string Units => "Unspecified";
public int Srid => 4232;

        public string OgcWkt =>
            "GEOGCS[Fahud,DATUM[Fahud,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6232]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4232]]";

        public string EsriWkt => "GEOGCS[Fahud,DATUM[D_Fahud,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}