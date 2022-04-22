using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Fort_Marigot : IEpsgCoordinateSystem
    {private const int _srid = 4621; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Fort Marigot";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Fort Marigot,DATUM[Fort_Marigot,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[137,248,-430,0,0,0,0],AUTHORITY[EPSG,6621]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4621]]";

        public string EsriWkt => "GEOGCS[Fort Marigot,DATUM[D_Fort_Marigot,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}