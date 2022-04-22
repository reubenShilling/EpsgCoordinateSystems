namespace EpsgCoordinateSystems.Categories.Other
{
    public class Yellow_Sea_1985 : IEpsgCoordinateSystem
    {
        public string Name => "Yellow Sea 1985";
        public string Units => "Unspecified";
public int Srid => 5737;

        public string OgcWkt =>
            "VERT_CS[Yellow Sea 1985,VERT_DATUM[Yellow Sea 1985,2005,AUTHORITY[EPSG,5137]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5737]]";

        public string EsriWkt => "VERT_CS[Yellow Sea 1985,VERT_DATUM[Yellow Sea 1985,2005],UNIT[m,1.0]]";
    }
}