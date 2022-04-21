namespace EpsgCoordinateSystems.Other
{
    public class Bora_Bora_SAU_2001 : IEpsgCoordinateSystem
    {
        public string Name => "Bora Bora SAU 2001";
        public long Srid => 5607;

        public string OgcWkt =>
            "VERT_CS[Bora Bora SAU 2001,VERT_DATUM[Bora Bora SAU 2001,2005,AUTHORITY[EPSG,5202]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5607]]";

        public string EsriWkt =>
            "VERT_CS[Bora Bora SAU 2001,VERT_DATUM[Bora Bora SAU 2001,2005,AUTHORITY[EPSG,5202]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5607]]";
    }
}