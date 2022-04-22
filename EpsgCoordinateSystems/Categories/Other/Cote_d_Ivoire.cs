namespace EpsgCoordinateSystems.Categories.Other
{
    public class Cote_d_Ivoire : IEpsgCoordinateSystem
    {
        public string Name => "Cote d'Ivoire";
        public string Units => "Unspecified";
public int Srid => 4226;

        public string OgcWkt =>
            "GEOGCS[Cote d'Ivoire,DATUM[Cote_d_Ivoire,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6226]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4226]]";

        public string EsriWkt => "GEOGCS[Cote d'Ivoire,DATUM[D_Cote_d_Ivoire,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}