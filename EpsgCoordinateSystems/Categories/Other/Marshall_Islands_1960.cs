using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Marshall_Islands_1960 : IEpsgCoordinateSystem
    {private const int _srid = 4732; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Marshall Islands 1960";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Marshall Islands 1960,DATUM[Marshall_Islands_1960,SPHEROID[Hough 1960,6378270,297,AUTHORITY[EPSG,7053]],TOWGS84[102,52,-38,0,0,0,0],AUTHORITY[EPSG,6732]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4732]]";

        public string EsriWkt => "GEOGCS[Marshall Islands 1960,DATUM[D_,SPHEROID[Hough_1960,6378270,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}