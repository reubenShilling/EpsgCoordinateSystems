using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class ST84_Ile_des_Pins : IEpsgCoordinateSystem
    {private const int _srid = 4642; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "ST84 Ile des Pins";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[ST84 Ile des Pins,DATUM[ST84_Ile_des_Pins,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6642]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4642]]";

        public string EsriWkt => "GEOGCS[ST84 Ile des Pins,DATUM[D_ST84_Ile_des_Pins,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}