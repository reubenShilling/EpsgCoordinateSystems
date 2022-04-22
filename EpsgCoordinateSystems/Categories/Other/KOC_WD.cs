using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class KOC_WD : IEpsgCoordinateSystem
    {private const int _srid = 5789; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "KOC WD";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[KOC WD,VERT_DATUM[KOC Well Datum,2005,AUTHORITY[EPSG,5187]],UNIT[m,1.0],AXIS[Gravity-related depth,DOWN],AUTHORITY[EPSG,5789]]";

        public string EsriWkt => "VERT_CS[KOC WD,VERT_DATUM[KOC Well Datum,2005],UNIT[m,1.0]]";
    }
}