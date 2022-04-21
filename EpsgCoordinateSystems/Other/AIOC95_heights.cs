namespace EpsgCoordinateSystems.Other
{
    public class AIOC95_heights : IEpsgCoordinateSystem
    {
        public string Name => "AIOC95 heights";
        public long Srid => 5797;

        public string OgcWkt =>
            "VERT_CS[AIOC95 heights,VERT_DATUM[AIOC 1995,2005,AUTHORITY[EPSG,5133]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5797]]";

        public string EsriWkt =>
            "VERT_CS[AIOC95 heights,VERT_DATUM[AIOC 1995,2005,AUTHORITY[EPSG,5133]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5797]]";
    }
}