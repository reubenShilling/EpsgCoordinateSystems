using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Poolbeg : IEpsgCoordinateSystem
    {private const int _srid = 5754; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Poolbeg";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Poolbeg,VERT_DATUM[Poolbeg,2005,AUTHORITY[EPSG,5152]],UNIT[m*0.3048007491,0.3048007491],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5754]]";

        public string EsriWkt => "VERT_CS[Poolbeg,VERT_DATUM[Poolbeg,2005],UNIT[m*0.3048007491,0.3048007491]]";
    }
}