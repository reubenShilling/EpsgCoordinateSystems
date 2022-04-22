namespace EpsgCoordinateSystems.Categories.Other
{
    public class PDO_Survey_Datum_1993 : IEpsgCoordinateSystem
    {
        public string Name => "PDO Survey Datum 1993";
        public string Units => "Unspecified";
public int Srid => 4134;

        public string OgcWkt =>
            "GEOGCS[PDO Survey Datum 1993,DATUM[PDO_Survey_Datum_1993,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6134]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4134]]";

        public string EsriWkt => "GEOGCS[PDO Survey Datum 1993,DATUM[D_PDO_1993,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}