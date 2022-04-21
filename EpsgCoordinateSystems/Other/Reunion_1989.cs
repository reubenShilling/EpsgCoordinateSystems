namespace EpsgCoordinateSystems.Other
{
    public class Reunion_1989 : IEpsgCoordinateSystem
    {
        public string Name => "Reunion 1989";
        public long Srid => 5758;

        public string OgcWkt =>
            "VERT_CS[Reunion 1989,VERT_DATUM[Reunion 1989,2005,AUTHORITY[EPSG,5156]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5758]]";

        public string EsriWkt =>
            "VERT_CS[Reunion 1989,VERT_DATUM[Reunion 1989,2005,AUTHORITY[EPSG,5156]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5758]]";
    }
}