using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class La_Canoa : IEpsgCoordinateSystem
    {private const int _srid = 4247; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "La Canoa";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[La Canoa,DATUM[La_Canoa,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-273.5,110.6,-357.9,0,0,0,0],AUTHORITY[EPSG,6247]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4247]]";

        public string EsriWkt => "GEOGCS[La Canoa,DATUM[D_La_Canoa,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}