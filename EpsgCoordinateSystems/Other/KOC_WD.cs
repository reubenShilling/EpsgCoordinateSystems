namespace EpsgCoordinateSystems.Other
{
    public class KOC_WD : IEpsgCoordinateSystem
    {
        public string Name => "KOC WD";
        public string Units => "Unspecified";
public long Srid => 5789;

        public string OgcWkt =>
            "VERT_CS[KOC WD,VERT_DATUM[KOC Well Datum,2005,AUTHORITY[EPSG,5187]],UNIT[m,1.0],AXIS[Gravity-related depth,DOWN],AUTHORITY[EPSG,5789]]";

        public string EsriWkt =>
            "VERT_CS[KOC WD,VERT_DATUM[KOC Well Datum,2005,AUTHORITY[EPSG,5187]],UNIT[m,1.0],AXIS[Gravity-related depth,DOWN],AUTHORITY[EPSG,5789]]";
    }
}