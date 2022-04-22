namespace EpsgCoordinateSystems.Other
{
    public class FD58 : IEpsgCoordinateSystem
    {
        public string Name => "FD58";
        public string Units => "Unspecified";
public long Srid => 4132;

        public string OgcWkt =>
            "GEOGCS[FD58,DATUM[Final_Datum_1958,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6132]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4132]]";

        public string EsriWkt =>
            "GEOGCS[FD58,DATUM[Final_Datum_1958,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6132]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4132]]";
    }
}