namespace EpsgCoordinateSystems.Other
{
    public class Tahaa_SAU_2001 : IEpsgCoordinateSystem
    {
        public string Name => "Tahaa SAU 2001";
        public long Srid => 5606;

        public string OgcWkt =>
            "VERT_CS[Tahaa SAU 2001,VERT_DATUM[Tahaa SAU 2001,2005,AUTHORITY[EPSG,5201]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5606]]";

        public string EsriWkt =>
            "VERT_CS[Tahaa SAU 2001,VERT_DATUM[Tahaa SAU 2001,2005,AUTHORITY[EPSG,5201]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5606]]";
    }
}