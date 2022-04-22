using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Tahiti_79 : IEpsgCoordinateSystem
    {private const int _srid = 4690; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Tahiti 79";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Tahiti 79,DATUM[Tahiti_79,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6690]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4690]]";

        public string EsriWkt => "GEOGCS[Tahiti 79,DATUM[D_Tahiti_1979,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}