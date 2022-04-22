using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Tararu : IEpsgCoordinateSystem
    {private const int _srid = 5768; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Tararu";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Tararu,VERT_DATUM[Tararu,2005,AUTHORITY[EPSG,5166]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5768]]";

        public string EsriWkt => "VERT_CS[Tararu,VERT_DATUM[Tararu,2005],UNIT[m,1.0]]";
    }
}