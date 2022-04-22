using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Bluff : IEpsgCoordinateSystem
    {private const int _srid = 5760; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Bluff";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Bluff,VERT_DATUM[Bluff,2005,AUTHORITY[EPSG,5158]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5760]]";

        public string EsriWkt => "VERT_CS[Bluff,VERT_DATUM[Bluff,2005],UNIT[m,1.0]]";
    }
}