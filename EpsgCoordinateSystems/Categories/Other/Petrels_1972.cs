using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Petrels_1972 : IEpsgCoordinateSystem
    {private const int _srid = 4636; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Petrels 1972";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Petrels 1972,DATUM[Petrels_1972,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[365,194,166,0,0,0,0],AUTHORITY[EPSG,6636]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4636]]";

        public string EsriWkt => "GEOGCS[Petrels 1972,DATUM[D_Petrels_1972,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}