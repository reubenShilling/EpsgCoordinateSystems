using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class KOC_CD : IEpsgCoordinateSystem
    {private const int _srid = 5790; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "KOC CD";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "VERT_CS[KOC CD,VERT_DATUM[KOC Construction Datum,2005,AUTHORITY[EPSG,5188]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5790]]";

        public string EsriWkt => "VERT_CS[KOC CD,VERT_DATUM[KOC Construction Datum,2005],UNIT[m,1.0]]";
    }
}