using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class IGN78_Corsica : IEpsgCoordinateSystem
    {private const int _srid = 5721; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "IGN78 Corsica";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[IGN78 Corsica,VERT_DATUM[IGN78 Corsica,2005,AUTHORITY[EPSG,5120]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5721]]";

        public string EsriWkt => "VERT_CS[IGN78 Corsica,VERT_DATUM[IGN78 Corsica,2005],UNIT[m,1.0]]";
    }
}