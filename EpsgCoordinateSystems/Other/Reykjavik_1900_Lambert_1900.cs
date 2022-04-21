namespace EpsgCoordinateSystems.Other
{
    public class Reykjavik_1900_Lambert_1900 : IEpsgCoordinateSystem
    {
        public string Name => "Reykjavik 1900 / Lambert 1900";
        public long Srid => 3052;

        public string OgcWkt =>
            "PROJCS[Reykjavik 1900 / Lambert 1900,GEOGCS[Reykjavik 1900,DATUM[Reykjavik_1900,SPHEROID[Danish 1876,6377019.27,300,AUTHORITY[EPSG,7051]],TOWGS84[-28,199,5,0,0,0,0],AUTHORITY[EPSG,6657]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4657],AXIS[Latitude,NORTH],AXIS[Longitude,EAST]],UNIT[metre,1,AUTHORITY[EPSG,9001]]]";

        public string EsriWkt =>
            "PROJCS[Reykjavik 1900 / Lambert 1900,GEOGCS[Reykjavik 1900,DATUM[Reykjavik_1900,SPHEROID[Danish 1876,6377019.27,300,AUTHORITY[EPSG,7051]],TOWGS84[-28,199,5,0,0,0,0],AUTHORITY[EPSG,6657]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4657],AXIS[Latitude,NORTH],AXIS[Longitude,EAST]],UNIT[metre,1,AUTHORITY[EPSG,9001]]]";
    }
}