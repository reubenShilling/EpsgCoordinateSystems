namespace EpsgCoordinateSystems.Other
{
    public class Fao : IEpsgCoordinateSystem
    {
        public string Name => "Fao";
        public long Srid => 5751;

        public string OgcWkt =>
            "VERT_CS[Fao,VERT_DATUM[Fao,2005,AUTHORITY[EPSG,5149]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5751]]";

        public string EsriWkt =>
            "VERT_CS[Fao,VERT_DATUM[Fao,2005,AUTHORITY[EPSG,5149]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5751]]";
    }
}