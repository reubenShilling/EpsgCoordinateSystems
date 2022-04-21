namespace EpsgCoordinateSystems.Other
{
    public class Guadeloupe_1951 : IEpsgCoordinateSystem
    {
        public string Name => "Guadeloupe 1951";
        public long Srid => 5795;

        public string OgcWkt =>
            "VERT_CS[Guadeloupe 1951,VERT_DATUM[Guadeloupe 1951,2005,AUTHORITY[EPSG,5193]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5795]]";

        public string EsriWkt =>
            "VERT_CS[Guadeloupe 1951,VERT_DATUM[Guadeloupe 1951,2005,AUTHORITY[EPSG,5193]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5795]]";
    }
}