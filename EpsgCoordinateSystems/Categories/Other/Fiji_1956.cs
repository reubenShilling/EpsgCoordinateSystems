using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Fiji_1956 : IEpsgCoordinateSystem
    {private const int _srid = 4721; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Fiji 1956";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Fiji 1956,DATUM[Fiji_1956,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[265.025,384.929,-194.046,0,0,0,0],AUTHORITY[EPSG,6721]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4721]]";

        public string EsriWkt => "GEOGCS[Fiji 1956,DATUM[D_Fiji_1956,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}