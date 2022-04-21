namespace EpsgCoordinateSystems.Other
{
    public class Bluff : IEpsgCoordinateSystem
    {
        public string Name => "Bluff";
        public long Srid => 5760;

        public string OgcWkt =>
            "VERT_CS[Bluff,VERT_DATUM[Bluff,2005,AUTHORITY[EPSG,5158]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5760]]";

        public string EsriWkt =>
            "VERT_CS[Bluff,VERT_DATUM[Bluff,2005,AUTHORITY[EPSG,5158]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5760]]";
    }
}