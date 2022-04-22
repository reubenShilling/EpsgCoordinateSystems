using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Guadeloupe_1948 : IEpsgCoordinateSystem
    {private const int _srid = 4622; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Guadeloupe 1948";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Guadeloupe 1948,DATUM[Guadeloupe_1948,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6622]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4622]]";

        public string EsriWkt => "GEOGCS[Guadeloupe 1948,DATUM[D_Sainte_Anne,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}