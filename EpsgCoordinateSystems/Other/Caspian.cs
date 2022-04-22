namespace EpsgCoordinateSystems.Other
{
    public class Caspian : IEpsgCoordinateSystem
    {
        public string Name => "Caspian";
        public string Units => "Unspecified";
public long Srid => 5706;

        public string OgcWkt =>
            "VERT_CS[Caspian,VERT_DATUM[Caspian Sea,2005,AUTHORITY[EPSG,5106]],UNIT[m,1.0],AXIS[Gravity-related depth,DOWN],AUTHORITY[EPSG,5706]]";

        public string EsriWkt =>
            "VERT_CS[Caspian,VERT_DATUM[Caspian Sea,2005,AUTHORITY[EPSG,5106]],UNIT[m,1.0],AXIS[Gravity-related depth,DOWN],AUTHORITY[EPSG,5706]]";
    }
}