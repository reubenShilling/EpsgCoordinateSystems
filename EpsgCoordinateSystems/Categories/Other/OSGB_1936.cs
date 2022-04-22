using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class OSGB_1936 : IEpsgCoordinateSystem
    {private const int _srid = 4277; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "OSGB 1936";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[OSGB 1936,DATUM[OSGB_1936,SPHEROID[Airy 1830,6377563.396,299.3249646,AUTHORITY[EPSG,7001]],AUTHORITY[EPSG,6277]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4277]]";

        public string EsriWkt => "GEOGCS[OSGB 1936,DATUM[D_OSGB_1936,SPHEROID[Airy_1830,6377563.396,299.3249646]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}