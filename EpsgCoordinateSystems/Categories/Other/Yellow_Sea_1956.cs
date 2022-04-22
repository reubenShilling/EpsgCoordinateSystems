using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Yellow_Sea_1956 : IEpsgCoordinateSystem
    {private const int _srid = 5736; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Yellow Sea 1956";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Yellow Sea 1956,VERT_DATUM[Yellow Sea 1956,2005,AUTHORITY[EPSG,5104]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5736]]";

        public string EsriWkt => "VERT_CS[Yellow Sea 1956,VERT_DATUM[Yellow Sea 1956,2005],UNIT[m,1.0]]";
    }
}