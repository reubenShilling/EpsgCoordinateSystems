namespace EpsgCoordinateSystems.Categories.Other
{
    public class Voirol_1875 : IEpsgCoordinateSystem
    {
        public string Name => "Voirol 1875";
        public string Units => "Unspecified";
public int Srid => 4304;

        public string OgcWkt =>
            "GEOGCS[Voirol 1875,DATUM[Voirol_1875,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[-73,-247,227,0,0,0,0],AUTHORITY[EPSG,6304]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4304]]";

        public string EsriWkt => "GEOGCS[Voirol 1875,DATUM[D_Voirol_1875,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}