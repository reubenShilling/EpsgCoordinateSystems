namespace EpsgCoordinateSystems.Other
{
    public class OSGB70 : IEpsgCoordinateSystem
    {
        public string Name => "OSGB70";
        public string Units => "Unspecified";
public long Srid => 4278;

        public string OgcWkt =>
            "GEOGCS[OSGB70,DATUM[OSGB_1970_SN,SPHEROID[Airy 1830,6377563.396,299.3249646,AUTHORITY[EPSG,7001]],AUTHORITY[EPSG,6278]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4278]]";

        public string EsriWkt => "GEOGCS[OSGB70,DATUM[D_OSGB_1970_SN,SPHEROID[Airy_1830,6377563.396,299.3249646]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}