namespace EpsgCoordinateSystems.Other
{
    public class N60 : IEpsgCoordinateSystem
    {
        public string Name => "N60";
        public string Units => "Unspecified";
public long Srid => 5717;

        public string OgcWkt =>
            "VERT_CS[N60,VERT_DATUM[Helsinki 1960,2005,AUTHORITY[EPSG,5116]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5717]]";

        public string EsriWkt =>
            "VERT_CS[N60,VERT_DATUM[Helsinki 1960,2005,AUTHORITY[EPSG,5116]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5717]]";
    }
}