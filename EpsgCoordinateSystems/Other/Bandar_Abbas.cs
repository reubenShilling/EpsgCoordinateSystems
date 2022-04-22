namespace EpsgCoordinateSystems.Other
{
    public class Bandar_Abbas : IEpsgCoordinateSystem
    {
        public string Name => "Bandar Abbas";
        public string Units => "Unspecified";
public long Srid => 5752;

        public string OgcWkt =>
            "VERT_CS[Bandar Abbas,VERT_DATUM[Bandar Abbas,2005,AUTHORITY[EPSG,5150]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5752]]";

        public string EsriWkt => "VERT_CS[Bandar Abbas,VERT_DATUM[Bandar Abbas,2005],UNIT[m,1.0]]";
    }
}