using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Fao : IEpsgCoordinateSystem
    {private const int _srid = 5751; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Fao";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Fao,VERT_DATUM[Fao,2005,AUTHORITY[EPSG,5149]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5751]]";

        public string EsriWkt => "VERT_CS[Fao,VERT_DATUM[Fao,2005],UNIT[m,1.0]]";
    }
}