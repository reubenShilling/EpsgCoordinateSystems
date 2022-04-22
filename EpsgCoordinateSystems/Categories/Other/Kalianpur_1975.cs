namespace EpsgCoordinateSystems.Categories.Other
{
    public class Kalianpur_1975 : IEpsgCoordinateSystem
    {
        public string Name => "Kalianpur 1975";
        public string Units => "Unspecified";
public int Srid => 4146;

        public string OgcWkt =>
            "GEOGCS[Kalianpur 1975,DATUM[Kalianpur_1975,SPHEROID[Everest 1830 (1975 Definition),6377299.151,300.8017255,AUTHORITY[EPSG,7045]],TOWGS84[295,736,257,0,0,0,0],AUTHORITY[EPSG,6146]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4146]]";

        public string EsriWkt => "GEOGCS[Kalianpur 1975,DATUM[D_Kalianpur_1975,SPHEROID[Everest_1830_1975_Definition,6377299.151,300.8017255]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}