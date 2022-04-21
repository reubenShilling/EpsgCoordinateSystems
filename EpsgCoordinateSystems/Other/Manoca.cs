namespace EpsgCoordinateSystems.Other
{
    public class Manoca : IEpsgCoordinateSystem
    {
        public string Name => "Manoca";
        public long Srid => 4260;

        public string OgcWkt =>
            "GEOGCS[Manoca,DATUM[Manoca,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-70.9,-151.8,-41.4,0,0,0,0],AUTHORITY[EPSG,6260]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4260]]";

        public string EsriWkt =>
            "GEOGCS[Manoca,DATUM[Manoca,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-70.9,-151.8,-41.4,0,0,0,0],AUTHORITY[EPSG,6260]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.0174532925199433,AUTHORITY[EPSG,9108]],AUTHORITY[EPSG,4260]]";
    }
}