namespace EpsgCoordinateSystems.Categories.Other
{
    public class Piraeus : IEpsgCoordinateSystem
    {
        public string Name => "Piraeus";
        public string Units => "Unspecified";
public int Srid => 5716;

        public string OgcWkt =>
            "VERT_CS[Piraeus,VERT_DATUM[Piraeus Harbour 1986,2005,AUTHORITY[EPSG,5115]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5716]]";

        public string EsriWkt => "VERT_CS[Piraeus,VERT_DATUM[Piraeus Harbour 1986,2005],UNIT[m,1.0]]";
    }
}