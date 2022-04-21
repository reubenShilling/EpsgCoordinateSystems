namespace EpsgCoordinateSystems.Other
{
    public class Maupiti_SAU_2001 : IEpsgCoordinateSystem
    {
        public string Name => "Maupiti SAU 2001";
        public long Srid => 5604;

        public string OgcWkt =>
            "VERT_CS[Maupiti SAU 2001,VERT_DATUM[Maupiti SAU 2001,2005,AUTHORITY[EPSG,5199]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5604]]";

        public string EsriWkt =>
            "VERT_CS[Maupiti SAU 2001,VERT_DATUM[Maupiti SAU 2001,2005,AUTHORITY[EPSG,5199]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5604]]";
    }
}