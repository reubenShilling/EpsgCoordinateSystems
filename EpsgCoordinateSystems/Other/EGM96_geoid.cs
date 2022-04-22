namespace EpsgCoordinateSystems.Other
{
    public class EGM96_geoid : IEpsgCoordinateSystem
    {
        public string Name => "EGM96 geoid";
        public string Units => "Unspecified";
public long Srid => 5773;

        public string OgcWkt =>
            "VERT_CS[EGM96 geoid,VERT_DATUM[EGM96 geoid,2005,AUTHORITY[EPSG,5171]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5773]]";

        public string EsriWkt =>
            "VERT_CS[EGM96 geoid,VERT_DATUM[EGM96 geoid,2005,AUTHORITY[EPSG,5171]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5773]]";
    }
}