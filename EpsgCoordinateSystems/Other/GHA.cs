namespace EpsgCoordinateSystems.Other
{
    public class GHA : IEpsgCoordinateSystem
    {
        public string Name => "GHA";
        public string Units => "Unspecified";
public long Srid => 5778;

        public string OgcWkt =>
            "VERT_CS[GHA,VERT_DATUM[Gebrauchshohen ADRIA,2005,AUTHORITY[EPSG,5176]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5778]]";

        public string EsriWkt =>
            "VERT_CS[GHA,VERT_DATUM[Gebrauchshohen ADRIA,2005,AUTHORITY[EPSG,5176]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5778]]";
    }
}