namespace EpsgCoordinateSystems.Categories.Other
{
    public class Moorea_SAU_1981 : IEpsgCoordinateSystem
    {
        public string Name => "Moorea SAU 1981";
        public string Units => "Unspecified";
public int Srid => 5602;

        public string OgcWkt =>
            "VERT_CS[Moorea SAU 1981,VERT_DATUM[Moorea SAU 1981,2005,AUTHORITY[EPSG,5197]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5602]]";

        public string EsriWkt => "VERT_CS[Moorea SAU 1981,VERT_DATUM[Moorea SAU 1981,2005],UNIT[m,1.0]]";
    }
}