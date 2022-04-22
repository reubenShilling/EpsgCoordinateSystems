using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Landeshohennetz_1995 : IEpsgCoordinateSystem
    {private const int _srid = 5729; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Landeshohennetz 1995";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Landeshohennetz 1995,VERT_DATUM[Landeshohennetz 1995,2005,AUTHORITY[EPSG,5128]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5729]]";

        public string EsriWkt => "VERT_CS[Landeshohennetz 1995,VERT_DATUM[Landeshohennetz 1995,2005],UNIT[m,1.0]]";
    }
}