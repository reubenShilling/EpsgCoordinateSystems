using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Ha_Tien_1960 : IEpsgCoordinateSystem
    {private const int _srid = 5726; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Ha Tien 1960";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Ha Tien 1960,VERT_DATUM[Ha Tien 1960,2005,AUTHORITY[EPSG,5125]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5726]]";

        public string EsriWkt => "VERT_CS[Ha Tien 1960,VERT_DATUM[Ha Tien 1960,2005],UNIT[m,1.0]]";
    }
}