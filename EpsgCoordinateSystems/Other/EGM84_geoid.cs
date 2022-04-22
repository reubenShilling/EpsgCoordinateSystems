namespace EpsgCoordinateSystems.Other
{
    public class EGM84_geoid : IEpsgCoordinateSystem
    {
        public string Name => "EGM84 geoid";
        public string Units => "Unspecified";
public long Srid => 5798;

        public string OgcWkt =>
            "VERT_CS[EGM84 geoid,VERT_DATUM[EGM84 geoid,2005,AUTHORITY[EPSG,5203]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5798]]";

        public string EsriWkt =>
            "VERT_CS[EGM84 geoid,VERT_DATUM[EGM84 geoid,2005,AUTHORITY[EPSG,5203]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5798]]";
    }
}