namespace EpsgCoordinateSystems.Other
{
    public class Martinique_1955 : IEpsgCoordinateSystem
    {
        public string Name => "Martinique 1955";
        public long Srid => 5794;

        public string OgcWkt =>
            "VERT_CS[Martinique 1955,VERT_DATUM[Martinique 1955,2005,AUTHORITY[EPSG,5192]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5794]]";

        public string EsriWkt =>
            "VERT_CS[Martinique 1955,VERT_DATUM[Martinique 1955,2005,AUTHORITY[EPSG,5192]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5794]]";
    }
}