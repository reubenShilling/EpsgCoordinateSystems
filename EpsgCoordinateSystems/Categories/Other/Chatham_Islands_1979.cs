using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Chatham_Islands_1979 : IEpsgCoordinateSystem
    {private const int _srid = 4673; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Chatham Islands 1979";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Chatham Islands 1979,DATUM[Chatham_Islands_Datum_1979,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[174.05,-25.49,112.57,-0,-0,0.554,0.2263],AUTHORITY[EPSG,6673]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4673]]";

        public string EsriWkt => "GEOGCS[Chatham Islands 1979,DATUM[D_Chatham_Islands_1979,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}