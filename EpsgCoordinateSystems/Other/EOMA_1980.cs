namespace EpsgCoordinateSystems.Other
{
    public class EOMA_1980 : IEpsgCoordinateSystem
    {
        public string Name => "EOMA 1980";
        public long Srid => 5787;

        public string OgcWkt =>
            "VERT_CS[EOMA 1980,VERT_DATUM[Baltic 1980,2005,AUTHORITY[EPSG,5185]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5787]]";

        public string EsriWkt =>
            "VERT_CS[EOMA 1980,VERT_DATUM[Baltic 1980,2005,AUTHORITY[EPSG,5185]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5787]]";
    }
}