namespace EpsgCoordinateSystems.Categories.Other
{
    public class OSNI_1952 : IEpsgCoordinateSystem
    {
        public string Name => "OSNI 1952";
        public string Units => "Unspecified";
public int Srid => 4188;

        public string OgcWkt =>
            "GEOGCS[OSNI 1952,DATUM[OSNI_1952,SPHEROID[Airy 1830,6377563.396,299.3249646,AUTHORITY[EPSG,7001]],TOWGS84[482.5,-130.6,564.6,-1.042,-0.214,-0.631,8.15],AUTHORITY[EPSG,6188]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4188]]";

        public string EsriWkt => "GEOGCS[OSNI 1952,DATUM[D_OSNI_1952,SPHEROID[Airy_1830,6377563.396,299.3249646]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}