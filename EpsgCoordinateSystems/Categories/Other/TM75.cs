namespace EpsgCoordinateSystems.Categories.Other
{
    public class TM75 : IEpsgCoordinateSystem
    {
        public string Name => "TM75";
        public string Units => "Unspecified";
public int Srid => 4300;

        public string OgcWkt =>
            "GEOGCS[TM75,DATUM[Geodetic_Datum_of_1965,SPHEROID[Airy Modified 1849,6377340.189,299.3249646,AUTHORITY[EPSG,7002]],AUTHORITY[EPSG,6300]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4300]]";

        public string EsriWkt => "GEOGCS[TM75,DATUM[D_TM75,SPHEROID[Airy_Modified_1849,6377340.189,299.3249646]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}