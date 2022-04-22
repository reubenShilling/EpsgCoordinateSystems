using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Maputo : IEpsgCoordinateSystem
    {private const int _srid = 5722; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Maputo";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Maputo,VERT_DATUM[Maputo,2005,AUTHORITY[EPSG,5121]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5722]]";

        public string EsriWkt => "VERT_CS[Maputo,VERT_DATUM[Maputo,2005],UNIT[m,1.0]]";
    }
}