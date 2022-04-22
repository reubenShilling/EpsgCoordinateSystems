using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Hu_Tzu_Shan : IEpsgCoordinateSystem
    {private const int _srid = 4236; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Hu Tzu Shan";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Hu Tzu Shan,DATUM[Hu_Tzu_Shan,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-637,-549,-203,0,0,0,0],AUTHORITY[EPSG,6236]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4236]]";

        public string EsriWkt => "GEOGCS[Hu Tzu Shan,DATUM[D_Hu_Tzu_Shan,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}