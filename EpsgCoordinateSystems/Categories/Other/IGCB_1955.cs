using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class IGCB_1955 : IEpsgCoordinateSystem
    {private const int _srid = 4701; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "IGCB 1955";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[IGCB 1955,DATUM[Institut_Geographique_du_Congo_Belge_1955,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-79.9,-158,-168.9,0,0,0,0],AUTHORITY[EPSG,6701]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4701]]";

        public string EsriWkt => "GEOGCS[IGCB 1955,DATUM[D_Institut_Geographique_du_Congo_Belge_1955,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}