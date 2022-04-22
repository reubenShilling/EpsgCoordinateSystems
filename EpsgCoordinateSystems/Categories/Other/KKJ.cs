using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class KKJ : IEpsgCoordinateSystem
    {private const int _srid = 4123; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "KKJ";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[KKJ,DATUM[Kartastokoordinaattijarjestelma_1966,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6123]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4123]]";

        public string EsriWkt => "GEOGCS[KKJ,DATUM[D_KKJ,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}