namespace EpsgCoordinateSystems.Other
{
    public class NTF : IEpsgCoordinateSystem
    {
        public string Name => "NTF";
        public long Srid => 4275;

        public string OgcWkt =>
            "GEOGCS[NTF,DATUM[Nouvelle_Triangulation_Francaise,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-168,-60,320,0,0,0,0],AUTHORITY[EPSG,6275]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4275]]";

        public string EsriWkt =>
            "GEOGCS[NTF,DATUM[Nouvelle_Triangulation_Francaise,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-168,-60,320,0,0,0,0],AUTHORITY[EPSG,6275]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4275]]";
    }
}