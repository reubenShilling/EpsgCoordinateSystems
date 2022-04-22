namespace EpsgCoordinateSystems.Other
{
    public class Flannan_Isles : IEpsgCoordinateSystem
    {
        public string Name => "Flannan Isles";
        public string Units => "Unspecified";
public long Srid => 5748;

        public string OgcWkt =>
            "VERT_CS[Flannan Isles,VERT_DATUM[Flannan Isles,2005,AUTHORITY[EPSG,5146]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5748]]";

        public string EsriWkt =>
            "VERT_CS[Flannan Isles,VERT_DATUM[Flannan Isles,2005,AUTHORITY[EPSG,5146]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5748]]";
    }
}