namespace EpsgCoordinateSystems.Other
{
    public class Timbalai_1948 : IEpsgCoordinateSystem
    {
        public string Name => "Timbalai 1948";
        public string Units => "Unspecified";
public long Srid => 4298;

        public string OgcWkt =>
            "GEOGCS[Timbalai 1948,DATUM[Timbalai_1948,SPHEROID[Everest 1830 (1967 Definition),6377298.556,300.8017,AUTHORITY[EPSG,7016]],AUTHORITY[EPSG,6298]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4298]]";

        public string EsriWkt => "GEOGCS[Timbalai 1948,DATUM[D_Timbalai_1948,SPHEROID[Everest_1830_1967_Definition,6377298.556,300.8017]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}