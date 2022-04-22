using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Datum_73 : IEpsgCoordinateSystem
    {private const int _srid = 4274; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Datum 73";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Datum 73,DATUM[Datum_73,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6274]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4274]]";

        public string EsriWkt => "GEOGCS[Datum 73,DATUM[D_Datum_73,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}