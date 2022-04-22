using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Easter_Island_1967 : IEpsgCoordinateSystem
    {private const int _srid = 4719; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Easter Island 1967";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Easter Island 1967,DATUM[Easter_Island_1967,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[211,147,111,0,0,0,0],AUTHORITY[EPSG,6719]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4719]]";

        public string EsriWkt => "GEOGCS[Easter Island 1967,DATUM[D_Easter_Island_1967,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}