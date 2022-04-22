using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Mhast_1951 : IEpsgCoordinateSystem
    {private const int _srid = 4703; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Mhast 1951";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Mhast 1951,DATUM[Missao_Hidrografico_Angola_y_Sao_Tome_1951,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6703]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4703]]";

        public string EsriWkt => "GEOGCS[Mhast 1951,DATUM[D_Mhast_1951,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}