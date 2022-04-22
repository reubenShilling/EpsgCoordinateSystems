using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class IGN_1962_Kerguelen : IEpsgCoordinateSystem
    {private const int _srid = 4698; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "IGN 1962 Kerguelen";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[IGN 1962 Kerguelen,DATUM[IGN_1962_Kerguelen,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[145,-187,103,0,0,0,0],AUTHORITY[EPSG,6698]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4698]]";

        public string EsriWkt => "GEOGCS[IGN 1962 Kerguelen,DATUM[D_Kerguelen_Island_1949,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}