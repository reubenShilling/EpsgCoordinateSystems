namespace EpsgCoordinateSystems.Other
{
    public class St_Kilda : IEpsgCoordinateSystem
    {
        public string Name => "St. Kilda";
        public string Units => "Unspecified";
public long Srid => 5747;

        public string OgcWkt =>
            "VERT_CS[St. Kilda,VERT_DATUM[St. Kilda,2005,AUTHORITY[EPSG,5145]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5747]]";

        public string EsriWkt => "VERT_CS[St. Kilda,VERT_DATUM[St. Kilda,2005],UNIT[m,1.0]]";
    }
}