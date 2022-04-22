using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Yellow_Sea : IEpsgCoordinateSystem
    {private const int _srid = 5704; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Yellow Sea";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Yellow Sea,VERT_DATUM[Yellow Sea 1956,2005,AUTHORITY[EPSG,5104]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5704]]";

        public string EsriWkt => "VERT_CS[Yellow Sea,VERT_DATUM[Yellow Sea 1956,2005],UNIT[m,1.0]]";
    }
}