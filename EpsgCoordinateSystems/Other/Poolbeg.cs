namespace EpsgCoordinateSystems.Other
{
    public class Poolbeg : IEpsgCoordinateSystem
    {
        public string Name => "Poolbeg";
        public string Units => "Unspecified";
public long Srid => 5754;

        public string OgcWkt =>
            "VERT_CS[Poolbeg,VERT_DATUM[Poolbeg,2005,AUTHORITY[EPSG,5152]],UNIT[m*0.3048007491,0.3048007491],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5754]]";

        public string EsriWkt => "VERT_CS[Poolbeg,VERT_DATUM[Poolbeg,2005],UNIT[m*0.3048007491,0.3048007491]]";
    }
}