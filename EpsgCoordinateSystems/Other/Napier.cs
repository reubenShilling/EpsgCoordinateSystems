namespace EpsgCoordinateSystems.Other
{
    public class Napier : IEpsgCoordinateSystem
    {
        public string Name => "Napier";
        public long Srid => 5765;

        public string OgcWkt =>
            "VERT_CS[Napier,VERT_DATUM[Napier,2005,AUTHORITY[EPSG,5163]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5765]]";

        public string EsriWkt =>
            "VERT_CS[Napier,VERT_DATUM[Napier,2005,AUTHORITY[EPSG,5163]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5765]]";
    }
}