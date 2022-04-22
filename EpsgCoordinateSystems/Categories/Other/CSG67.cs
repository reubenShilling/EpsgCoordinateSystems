using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class CSG67 : IEpsgCoordinateSystem
    {private const int _srid = 4623; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "CSG67";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[CSG67,DATUM[Centre_Spatial_Guyanais_1967,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-186,230,110,0,0,0,0],AUTHORITY[EPSG,6623]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4623]]";

        public string EsriWkt => "GEOGCS[CSG67,DATUM[D_CSG_1967,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}