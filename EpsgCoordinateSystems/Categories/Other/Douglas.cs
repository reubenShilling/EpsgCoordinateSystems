using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Douglas : IEpsgCoordinateSystem
    {private const int _srid = 5750; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Douglas";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Douglas,VERT_DATUM[Douglas,2005,AUTHORITY[EPSG,5148]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5750]]";

        public string EsriWkt => "VERT_CS[Douglas,VERT_DATUM[Douglas,2005],UNIT[m,1.0]]";
    }
}