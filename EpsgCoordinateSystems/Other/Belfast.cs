namespace EpsgCoordinateSystems.Other
{
    public class Belfast : IEpsgCoordinateSystem
    {
        public string Name => "Belfast";
        public string Units => "Unspecified";
public long Srid => 5732;

        public string OgcWkt =>
            "VERT_CS[Belfast,VERT_DATUM[Belfast Lough,2005,AUTHORITY[EPSG,5131]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5732]]";

        public string EsriWkt =>
            "VERT_CS[Belfast,VERT_DATUM[Belfast Lough,2005,AUTHORITY[EPSG,5131]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5732]]";
    }
}