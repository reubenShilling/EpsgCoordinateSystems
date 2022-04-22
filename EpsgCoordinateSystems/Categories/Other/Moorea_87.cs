using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Moorea_87 : IEpsgCoordinateSystem
    {private const int _srid = 4691; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Moorea 87";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Moorea 87,DATUM[Moorea_87,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[215.525,149.593,176.229,-3.2624,-1.692,-1.1571,10.4773],AUTHORITY[EPSG,6691]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4691]]";

        public string EsriWkt => "GEOGCS[Moorea 87,DATUM[D_Moorea_1987,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}