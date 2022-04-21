namespace EpsgCoordinateSystems.Other
{
    public class NGF_Lallemand : IEpsgCoordinateSystem
    {
        public string Name => "NGF Lallemand";
        public long Srid => 5719;

        public string OgcWkt =>
            "VERT_CS[NGF Lallemand,VERT_DATUM[Nivellement General de la France - Lallemand,2005,AUTHORITY[EPSG,5118]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5719]]";

        public string EsriWkt =>
            "VERT_CS[NGF Lallemand,VERT_DATUM[Nivellement General de la France - Lallemand,2005,AUTHORITY[EPSG,5118]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5719]]";
    }
}