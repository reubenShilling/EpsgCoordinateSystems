using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Rassadiran : IEpsgCoordinateSystem
    {private const int _srid = 4153; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Rassadiran";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Rassadiran,DATUM[Rassadiran,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-133.63,-157.5,-158.62,0,0,0,0],AUTHORITY[EPSG,6153]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4153]]";

        public string EsriWkt => "GEOGCS[Rassadiran,DATUM[D_Rassadiran,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}