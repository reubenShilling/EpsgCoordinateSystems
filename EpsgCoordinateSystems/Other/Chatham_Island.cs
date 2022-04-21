namespace EpsgCoordinateSystems.Other
{
    public class Chatham_Island : IEpsgCoordinateSystem
    {
        public string Name => "Chatham Island";
        public long Srid => 5771;

        public string OgcWkt =>
            "VERT_CS[Chatham Island,VERT_DATUM[Chatham Island,2005,AUTHORITY[EPSG,5169]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5771]]";

        public string EsriWkt =>
            "VERT_CS[Chatham Island,VERT_DATUM[Chatham Island,2005,AUTHORITY[EPSG,5169]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5771]]";
    }
}