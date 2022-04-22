using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class RH00_height : IEpsgCoordinateSystem
    {private const int _srid = 5615; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "RH00 height";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[RH00 height,VERT_DATUM[Rikets hojdsystem 1900,2005,AUTHORITY[EPSG,5209]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5615]]";

        public string EsriWkt => "VERT_CS[RH00 height,VERT_DATUM[Rikets hojdsystem 1900,2005],UNIT[m,1.0]]";
    }
}