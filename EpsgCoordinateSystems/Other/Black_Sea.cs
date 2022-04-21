namespace EpsgCoordinateSystems.Other
{
    public class Black_Sea : IEpsgCoordinateSystem
    {
        public string Name => "Black Sea";
        public long Srid => 5735;

        public string OgcWkt =>
            "VERT_CS[Black Sea,VERT_DATUM[Black Sea,2005,AUTHORITY[EPSG,5134]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5735]]";

        public string EsriWkt =>
            "VERT_CS[Black Sea,VERT_DATUM[Black Sea,2005,AUTHORITY[EPSG,5134]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5735]]";
    }
}