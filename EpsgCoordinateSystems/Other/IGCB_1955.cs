namespace EpsgCoordinateSystems.Other
{
    public class IGCB_1955 : IEpsgCoordinateSystem
    {
        public string Name => "IGCB 1955";
        public long Srid => 4701;

        public string OgcWkt =>
            "GEOGCS[IGCB 1955,DATUM[Institut_Geographique_du_Congo_Belge_1955,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-79.9,-158,-168.9,0,0,0,0],AUTHORITY[EPSG,6701]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4701]]";

        public string EsriWkt =>
            "GEOGCS[IGCB 1955,DATUM[Institut_Geographique_du_Congo_Belge_1955,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-79.9,-158,-168.9,0,0,0,0],AUTHORITY[EPSG,6701]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4701]]";
    }
}