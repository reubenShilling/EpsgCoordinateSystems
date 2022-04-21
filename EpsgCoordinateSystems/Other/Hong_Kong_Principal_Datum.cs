namespace EpsgCoordinateSystems.Other
{
    public class Hong_Kong_Principal_Datum : IEpsgCoordinateSystem
    {
        public string Name => "Hong Kong Principal Datum";
        public long Srid => 5738;

        public string OgcWkt =>
            "VERT_CS[Hong Kong Principal Datum,VERT_DATUM[Hong Kong Principal Datum,2005,AUTHORITY[EPSG,5135]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5738]]";

        public string EsriWkt =>
            "VERT_CS[Hong Kong Principal Datum,VERT_DATUM[Hong Kong Principal Datum,2005,AUTHORITY[EPSG,5135]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5738]]";
    }
}