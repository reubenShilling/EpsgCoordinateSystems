using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Oostende : IEpsgCoordinateSystem
    {private const int _srid = 5710; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Oostende";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Oostende,VERT_DATUM[Oostende,2005,AUTHORITY[EPSG,5110]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5710]]";

        public string EsriWkt => "VERT_CS[Oostende,VERT_DATUM[Oostende,2005],UNIT[m,1.0]]";
    }
}