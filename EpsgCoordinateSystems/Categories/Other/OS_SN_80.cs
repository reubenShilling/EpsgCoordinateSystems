namespace EpsgCoordinateSystems.Categories.Other
{
    public class OS_SN_80 : IEpsgCoordinateSystem
    {
        public string Name => "OS(SN)80";
        public string Units => "Unspecified";
public int Srid => 4279;

        public string OgcWkt =>
            "GEOGCS[OS(SN)80,DATUM[OS_SN_1980,SPHEROID[Airy 1830,6377563.396,299.3249646,AUTHORITY[EPSG,7001]],AUTHORITY[EPSG,6279]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4279]]";

        public string EsriWkt => "GEOGCS[OS(SN)80,DATUM[D_OS_SN_1980,SPHEROID[Airy_1830,6377563.396,299.3249646]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}