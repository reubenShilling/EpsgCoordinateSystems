using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Caspian : IEpsgCoordinateSystem
    {private const int _srid = 5706; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Caspian";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[Caspian,VERT_DATUM[Caspian Sea,2005,AUTHORITY[EPSG,5106]],UNIT[m,1.0],AXIS[Gravity-related depth,DOWN],AUTHORITY[EPSG,5706]]";

        public string EsriWkt => "VERT_CS[Caspian,VERT_DATUM[Caspian Sea,2005],UNIT[m,1.0]]";
    }
}