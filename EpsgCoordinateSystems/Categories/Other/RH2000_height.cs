using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class RH2000_height : IEpsgCoordinateSystem
    {private const int _srid = 5613; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "RH2000 height";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[RH2000 height,VERT_DATUM[Rikets hojdsystem 2000,2005,AUTHORITY[EPSG,5208]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5613]]";

        public string EsriWkt => "VERT_CS[RH2000 height,VERT_DATUM[Rikets hojdsystem 2000,2005],UNIT[m,1.0]]";
    }
}