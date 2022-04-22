namespace EpsgCoordinateSystems.Other
{
    public class NVN99 : IEpsgCoordinateSystem
    {
        public string Name => "NVN99";
        public string Units => "Unspecified";
public long Srid => 5779;

        public string OgcWkt =>
            "VERT_CS[NVN99,VERT_DATUM[National Vertical Network 1999,2005,AUTHORITY[EPSG,5177]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5779]]";

        public string EsriWkt => "VERT_CS[NVN99,VERT_DATUM[National Vertical Network 1999,2005],UNIT[m,1.0]]";
    }
}