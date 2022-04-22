namespace EpsgCoordinateSystems.Other
{
    public class Yellow_Sea_1956 : IEpsgCoordinateSystem
    {
        public string Name => "Yellow Sea 1956";
        public string Units => "Unspecified";
public long Srid => 5736;

        public string OgcWkt =>
            "VERT_CS[Yellow Sea 1956,VERT_DATUM[Yellow Sea 1956,2005,AUTHORITY[EPSG,5104]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5736]]";

        public string EsriWkt => "VERT_CS[Yellow Sea 1956,VERT_DATUM[Yellow Sea 1956,2005],UNIT[m,1.0]]";
    }
}