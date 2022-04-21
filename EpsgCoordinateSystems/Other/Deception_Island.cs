namespace EpsgCoordinateSystems.Other
{
    public class Deception_Island : IEpsgCoordinateSystem
    {
        public string Name => "Deception Island";
        public long Srid => 4736;

        public string OgcWkt =>
            "GEOGCS[Deception Island,DATUM[Deception_Island,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[260,12,-147,0,0,0,0],AUTHORITY[EPSG,6736]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4736]]";

        public string EsriWkt =>
            "GEOGCS[Deception Island,DATUM[Deception_Island,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[260,12,-147,0,0,0,0],AUTHORITY[EPSG,6736]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4736]]";
    }
}