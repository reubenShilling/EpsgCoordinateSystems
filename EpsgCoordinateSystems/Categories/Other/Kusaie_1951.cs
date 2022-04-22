using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Kusaie_1951 : IEpsgCoordinateSystem
    {private const int _srid = 4735; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Kusaie 1951";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Kusaie 1951,DATUM[Kusaie_1951,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[647,1777,-1124,0,0,0,0],AUTHORITY[EPSG,6735]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4735]]";

        public string EsriWkt => "GEOGCS[Kusaie 1951,DATUM[D_Kusaie_1951,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}