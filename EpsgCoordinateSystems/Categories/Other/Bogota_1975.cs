using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Bogota_1975 : IEpsgCoordinateSystem
    {private const int _srid = 4218; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Bogota 1975";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Bogota 1975,DATUM[Bogota_1975,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[307,304,-318,0,0,0,0],AUTHORITY[EPSG,6218]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4218]]";

        public string EsriWkt => "GEOGCS[Bogota 1975,DATUM[D_Bogota,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}