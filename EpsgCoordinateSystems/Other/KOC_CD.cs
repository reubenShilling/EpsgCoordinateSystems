namespace EpsgCoordinateSystems.Other
{
    public class KOC_CD : IEpsgCoordinateSystem
    {
        public string Name => "KOC CD";
        public long Srid => 5790;

        public string OgcWkt =>
            "VERT_CS[KOC CD,VERT_DATUM[KOC Construction Datum,2005,AUTHORITY[EPSG,5188]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5790]]";

        public string EsriWkt =>
            "VERT_CS[KOC CD,VERT_DATUM[KOC Construction Datum,2005,AUTHORITY[EPSG,5188]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5790]]";
    }
}