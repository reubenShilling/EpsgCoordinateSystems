namespace EpsgCoordinateSystems.Other
{
    public class Taranaki : IEpsgCoordinateSystem
    {
        public string Name => "Taranaki";
        public long Srid => 5769;

        public string OgcWkt =>
            "VERT_CS[Taranaki,VERT_DATUM[Taranaki,2005,AUTHORITY[EPSG,5167]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5769]]";

        public string EsriWkt =>
            "VERT_CS[Taranaki,VERT_DATUM[Taranaki,2005,AUTHORITY[EPSG,5167]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5769]]";
    }
}