namespace EpsgCoordinateSystems.Other
{
    public class Anguilla_1957 : IEpsgCoordinateSystem
    {
        public string Name => "Anguilla 1957";
        public string Units => "Unspecified";
public long Srid => 4600;

        public string OgcWkt =>
            "GEOGCS[Anguilla 1957,DATUM[Anguilla_1957,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6600]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4600]]";

        public string EsriWkt => "GEOGCS[Anguilla 1957,DATUM[D_Anguilla_1957,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}