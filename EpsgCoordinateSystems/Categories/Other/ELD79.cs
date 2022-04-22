using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class ELD79 : IEpsgCoordinateSystem
    {private const int _srid = 4159; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "ELD79";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[ELD79,DATUM[European_Libyan_Datum_1979,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6159]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4159]]";

        public string EsriWkt => "GEOGCS[ELD79,DATUM[D_European_Libyan_1979,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}