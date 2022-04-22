using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Iwo_Jima_1945 : IEpsgCoordinateSystem
    {private const int _srid = 4709; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Iwo Jima 1945";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Iwo Jima 1945,DATUM[Iwo_Jima_1945,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[145,75,-272,0,0,0,0],AUTHORITY[EPSG,6709]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4709]]";

        public string EsriWkt => "GEOGCS[Iwo Jima 1945,DATUM[D_,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}