namespace EpsgCoordinateSystems.Other
{
    public class NGG1977 : IEpsgCoordinateSystem
    {
        public string Name => "NGG1977";
        public long Srid => 5755;

        public string OgcWkt =>
            "VERT_CS[NGG1977,VERT_DATUM[Nivellement General Guyanais 1977,2005,AUTHORITY[EPSG,5153]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5755]]";

        public string EsriWkt =>
            "VERT_CS[NGG1977,VERT_DATUM[Nivellement General Guyanais 1977,2005,AUTHORITY[EPSG,5153]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5755]]";
    }
}