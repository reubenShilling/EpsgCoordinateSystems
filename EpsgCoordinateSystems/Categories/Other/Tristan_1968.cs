using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Tristan_1968 : IEpsgCoordinateSystem
    {private const int _srid = 4734; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Tristan 1968";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Tristan 1968,DATUM[Tristan_1968,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-632,438,-609,0,0,0,0],AUTHORITY[EPSG,6734]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4734]]";

        public string EsriWkt => "GEOGCS[Tristan 1968,DATUM[D_Tristan_1968,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}