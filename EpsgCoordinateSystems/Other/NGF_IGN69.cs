namespace EpsgCoordinateSystems.Other
{
    public class NGF_IGN69 : IEpsgCoordinateSystem
    {
        public string Name => "NGF IGN69";
        public long Srid => 5720;

        public string OgcWkt =>
            "VERT_CS[NGF IGN69,VERT_DATUM[Nivellement General de la France - IGN69,2005,AUTHORITY[EPSG,5119]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5720]]";

        public string EsriWkt =>
            "VERT_CS[NGF IGN69,VERT_DATUM[Nivellement General de la France - IGN69,2005,AUTHORITY[EPSG,5119]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5720]]";
    }
}