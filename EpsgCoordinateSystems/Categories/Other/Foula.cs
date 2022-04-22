using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Foula : IEpsgCoordinateSystem
    {private const int _srid = 5743; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Foula";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Foula,VERT_DATUM[Foula,2005,AUTHORITY[EPSG,5141]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5743]]";

        public string EsriWkt => "VERT_CS[Foula,VERT_DATUM[Foula,2005],UNIT[m,1.0]]";
    }
}