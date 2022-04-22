namespace EpsgCoordinateSystems.Categories.Other
{
    public class ED79 : IEpsgCoordinateSystem
    {
        public string Name => "ED79";
        public string Units => "Unspecified";
public int Srid => 4668;

        public string OgcWkt =>
            "GEOGCS[ED79,DATUM[European_Datum_1979,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-86,-98,-119,0,0,0,0],AUTHORITY[EPSG,6668]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4668]]";

        public string EsriWkt => "GEOGCS[ED79,DATUM[D_European_1979,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}