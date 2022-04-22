using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class EVRF2000 : IEpsgCoordinateSystem
    {private const int _srid = 5730; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "EVRF2000";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[EVRF2000,VERT_DATUM[European Vertical Reference Frame 2000,2005,AUTHORITY[EPSG,5129]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5730]]";

        public string EsriWkt => "VERT_CS[EVRF2000,VERT_DATUM[European Vertical Reference Frame 2000,2005],UNIT[m,1.0]]";
    }
}