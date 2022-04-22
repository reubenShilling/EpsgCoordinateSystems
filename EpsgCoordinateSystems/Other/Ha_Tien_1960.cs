namespace EpsgCoordinateSystems.Other
{
    public class Ha_Tien_1960 : IEpsgCoordinateSystem
    {
        public string Name => "Ha Tien 1960";
        public string Units => "Unspecified";
public long Srid => 5726;

        public string OgcWkt =>
            "VERT_CS[Ha Tien 1960,VERT_DATUM[Ha Tien 1960,2005,AUTHORITY[EPSG,5125]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5726]]";

        public string EsriWkt =>
            "VERT_CS[Ha Tien 1960,VERT_DATUM[Ha Tien 1960,2005,AUTHORITY[EPSG,5125]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5726]]";
    }
}