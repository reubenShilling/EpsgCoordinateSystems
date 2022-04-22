using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Pitcairn_1967 : IEpsgCoordinateSystem
    {private const int _srid = 4729; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Pitcairn 1967";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Pitcairn 1967,DATUM[Pitcairn_1967,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[185,165,42,0,0,0,0],AUTHORITY[EPSG,6729]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4729]]";

        public string EsriWkt => "GEOGCS[Pitcairn 1967,DATUM[D_Pitcairn_1967,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}