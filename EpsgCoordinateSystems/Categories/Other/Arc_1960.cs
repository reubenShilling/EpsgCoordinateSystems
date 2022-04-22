namespace EpsgCoordinateSystems.Categories.Other
{
    public class Arc_1960 : IEpsgCoordinateSystem
    {
        public string Name => "Arc 1960";
        public string Units => "Unspecified";
public int Srid => 4210;

        public string OgcWkt =>
            "GEOGCS[Arc 1960,DATUM[Arc_1960,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6210]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4210]]";

        public string EsriWkt => "GEOGCS[Arc 1960,DATUM[D_Arc_1960,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}