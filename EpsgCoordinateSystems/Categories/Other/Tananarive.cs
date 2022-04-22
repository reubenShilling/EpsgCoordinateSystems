using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Tananarive : IEpsgCoordinateSystem
    {private const int _srid = 4297; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Tananarive";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Tananarive,DATUM[Tananarive_1925,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-189,-242,-91,0,0,0,0],AUTHORITY[EPSG,6297]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4297]]";

        public string EsriWkt => "GEOGCS[Tananarive,DATUM[D_Tananarive_1925,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}