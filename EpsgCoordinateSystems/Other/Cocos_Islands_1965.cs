namespace EpsgCoordinateSystems.Other
{
    public class Cocos_Islands_1965 : IEpsgCoordinateSystem
    {
        public string Name => "Cocos Islands 1965";
        public string Units => "Unspecified";
public long Srid => 4708;

        public string OgcWkt =>
            "GEOGCS[Cocos Islands 1965,DATUM[Cocos_Islands_1965,SPHEROID[Australian National Spheroid,6378160,298.25,AUTHORITY[EPSG,7003]],TOWGS84[-491,-22,435,0,0,0,0],AUTHORITY[EPSG,6708]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4708]]";

        public string EsriWkt => "GEOGCS[Cocos Islands 1965,DATUM[D_,SPHEROID[Australian_National_Spheroid,6378160,298.25]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}