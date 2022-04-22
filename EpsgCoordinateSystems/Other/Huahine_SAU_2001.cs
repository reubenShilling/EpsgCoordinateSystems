namespace EpsgCoordinateSystems.Other
{
    public class Huahine_SAU_2001 : IEpsgCoordinateSystem
    {
        public string Name => "Huahine SAU 2001";
        public string Units => "Unspecified";
public long Srid => 5605;

        public string OgcWkt =>
            "VERT_CS[Huahine SAU 2001,VERT_DATUM[Huahine SAU 2001,2005,AUTHORITY[EPSG,5200]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5605]]";

        public string EsriWkt => "VERT_CS[Huahine SAU 2001,VERT_DATUM[Huahine SAU 2001,2005],UNIT[m,1.0]]";
    }
}