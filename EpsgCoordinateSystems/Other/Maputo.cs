namespace EpsgCoordinateSystems.Other
{
    public class Maputo : IEpsgCoordinateSystem
    {
        public string Name => "Maputo";
        public long Srid => 5722;

        public string OgcWkt =>
            "VERT_CS[Maputo,VERT_DATUM[Maputo,2005,AUTHORITY[EPSG,5121]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5722]]";

        public string EsriWkt =>
            "VERT_CS[Maputo,VERT_DATUM[Maputo,2005,AUTHORITY[EPSG,5121]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5722]]";
    }
}