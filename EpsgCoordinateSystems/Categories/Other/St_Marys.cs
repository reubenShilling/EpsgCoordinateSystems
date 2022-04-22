namespace EpsgCoordinateSystems.Categories.Other
{
    public class St_Marys : IEpsgCoordinateSystem
    {
        public string Name => "St. Marys";
        public string Units => "Unspecified";
public int Srid => 5749;

        public string OgcWkt =>
            "VERT_CS[St. Marys,VERT_DATUM[St. Marys,2005,AUTHORITY[EPSG,5147]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5749]]";

        public string EsriWkt => "VERT_CS[St. Marys,VERT_DATUM[St. Marys,2005],UNIT[m,1.0]]";
    }
}