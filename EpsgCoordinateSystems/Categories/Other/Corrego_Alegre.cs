using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Corrego_Alegre : IEpsgCoordinateSystem
    {private const int _srid = 4225; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Corrego Alegre";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Corrego Alegre,DATUM[Corrego_Alegre,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-206,172,-6,0,0,0,0],AUTHORITY[EPSG,6225]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4225]]";

        public string EsriWkt => "GEOGCS[Corrego Alegre,DATUM[D_Corrego_Alegre,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}