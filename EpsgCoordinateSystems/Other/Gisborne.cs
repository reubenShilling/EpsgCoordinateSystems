namespace EpsgCoordinateSystems.Other
{
    public class Gisborne : IEpsgCoordinateSystem
    {
        public string Name => "Gisborne";
        public string Units => "Unspecified";
public long Srid => 5762;

        public string OgcWkt =>
            "VERT_CS[Gisborne,VERT_DATUM[Gisborne,2005,AUTHORITY[EPSG,5160]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5762]]";

        public string EsriWkt => "VERT_CS[Gisborne,VERT_DATUM[Gisborne,2005],UNIT[m,1.0]]";
    }
}