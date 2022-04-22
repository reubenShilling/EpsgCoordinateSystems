using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Tern_Island_1961 : IEpsgCoordinateSystem
    {private const int _srid = 4707; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Tern Island 1961";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Tern Island 1961,DATUM[Tern_Island_1961,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[114,-116,-333,0,0,0,0],AUTHORITY[EPSG,6707]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4707]]";

        public string EsriWkt => "GEOGCS[Tern Island 1961,DATUM[D_Tern_Island_1961,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}