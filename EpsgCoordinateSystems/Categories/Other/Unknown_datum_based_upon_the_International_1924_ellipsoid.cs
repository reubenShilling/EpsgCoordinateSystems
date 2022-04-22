using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Unknown_datum_based_upon_the_International_1924_ellipsoid : IEpsgCoordinateSystem
    {private const int _srid = 4022; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Unknown datum based upon the International 1924 ellipsoid";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Unknown datum based upon the International 1924 ellipsoid,DATUM[Not_specified_based_on_International_1924_ellipsoid,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6022]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4022]]";

        public string EsriWkt => "GEOGCS[Unknown datum based upon the International 1924 ellipsoid,DATUM[D_International_1924,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}