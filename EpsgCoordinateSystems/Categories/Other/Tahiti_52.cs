using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Tahiti_52 : IEpsgCoordinateSystem
    {private const int _srid = 4628; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Tahiti 52";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Tahiti 52,DATUM[Tahiti_52,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[162,117,154,0,0,0,0],AUTHORITY[EPSG,6628]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4628]]";

        public string EsriWkt => "GEOGCS[Tahiti 52,DATUM[D_Tahiti_1952,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}