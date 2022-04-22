using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Yellow_Sea_1985 : IEpsgCoordinateSystem
    {private const int _srid = 5737; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Yellow Sea 1985";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Yellow Sea 1985,VERT_DATUM[Yellow Sea 1985,2005,AUTHORITY[EPSG,5137]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5737]]";

        public string EsriWkt => "VERT_CS[Yellow Sea 1985,VERT_DATUM[Yellow Sea 1985,2005],UNIT[m,1.0]]";
    }
}