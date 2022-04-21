namespace EpsgCoordinateSystems.Other
{
    public class SNN76 : IEpsgCoordinateSystem
    {
        public string Name => "SNN76";
        public long Srid => 5785;

        public string OgcWkt =>
            "VERT_CS[SNN76,VERT_DATUM[SNN76,2005,AUTHORITY[EPSG,5183]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5785]]";

        public string EsriWkt =>
            "VERT_CS[SNN76,VERT_DATUM[SNN76,2005,AUTHORITY[EPSG,5183]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5785]]";
    }
}