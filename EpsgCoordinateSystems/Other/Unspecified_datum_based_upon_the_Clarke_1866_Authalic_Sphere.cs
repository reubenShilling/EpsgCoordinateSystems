namespace EpsgCoordinateSystems.Other
{
    public class Unspecified_datum_based_upon_the_Clarke_1866_Authalic_Sphere : IEpsgCoordinateSystem
    {
        public string Name => "Unspecified datum based upon the Clarke 1866 Authalic Sphere";
        public string Units => "Unspecified";
public long Srid => 4052;

        public string OgcWkt =>
            "GEOGCS[Unspecified datum based upon the Clarke 1866 Authalic Sphere,DATUM[Not_specified_based_on_Clarke_1866_Authalic_Sphere,SPHEROID[Clarke 1866 Authalic Sphere,6370997,0,AUTHORITY[EPSG,7052]],AUTHORITY[EPSG,6052]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4052]]";

        public string EsriWkt => "GEOGCS[Unspecified datum based upon the Clarke 1866 Authalic Sphere,DATUM[D_Sphere_Clarke_1866_Authalic,SPHEROID[Clarke_1866_Authalic_Sphere,6370997,0]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}