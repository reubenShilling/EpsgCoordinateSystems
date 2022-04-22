namespace EpsgCoordinateSystems.Other
{
    public class Antalya : IEpsgCoordinateSystem
    {
        public string Name => "Antalya";
        public string Units => "Unspecified";
public long Srid => 5775;

        public string OgcWkt =>
            "VERT_CS[Antalya,VERT_DATUM[Antalya,2005,AUTHORITY[EPSG,5173]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5775]]";

        public string EsriWkt =>
            "VERT_CS[Antalya,VERT_DATUM[Antalya,2005,AUTHORITY[EPSG,5173]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5775]]";
    }
}