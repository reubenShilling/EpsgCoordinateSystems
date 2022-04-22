namespace EpsgCoordinateSystems.Other
{
    public class Normaal_Amsterdams_Peil : IEpsgCoordinateSystem
    {
        public string Name => "Normaal Amsterdams Peil";
        public string Units => "Unspecified";
public long Srid => 5709;

        public string OgcWkt =>
            "VERT_CS[Normaal Amsterdams Peil,VERT_DATUM[Normaal Amsterdams Peil,2005,AUTHORITY[EPSG,5109]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5709]]";

        public string EsriWkt => "VERT_CS[Normaal Amsterdams Peil,VERT_DATUM[Normaal Amsterdams Peil,2005],UNIT[m,1.0]]";
    }
}