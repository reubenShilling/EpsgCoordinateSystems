namespace EpsgCoordinateSystems.Other
{
    public class QND95 : IEpsgCoordinateSystem
    {
        public string Name => "QND95";
        public long Srid => 4614;

        public string OgcWkt =>
            "GEOGCS[QND95,DATUM[Qatar_National_Datum_1995,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-119.425,-303.659,-11.0006,1.1643,0.174458,1.09626,3.65706],AUTHORITY[EPSG,6614]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4614]]";

        public string EsriWkt =>
            "GEOGCS[QND95,DATUM[Qatar_National_Datum_1995,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-119.425,-303.659,-11.0006,1.1643,0.174458,1.09626,3.65706],AUTHORITY[EPSG,6614]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4614]]";
    }
}