namespace EpsgCoordinateSystems.Categories.Other
{
    public class Stewart_Island : IEpsgCoordinateSystem
    {
        public string Name => "Stewart Island";
        public string Units => "Unspecified";
public int Srid => 5772;

        public string OgcWkt =>
            "VERT_CS[Stewart Island,VERT_DATUM[Stewart Island,2005,AUTHORITY[EPSG,5170]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5772]]";

        public string EsriWkt => "VERT_CS[Stewart Island,VERT_DATUM[Stewart Island,2005],UNIT[m,1.0]]";
    }
}