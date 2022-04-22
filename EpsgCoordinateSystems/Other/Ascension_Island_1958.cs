namespace EpsgCoordinateSystems.Other
{
    public class Ascension_Island_1958 : IEpsgCoordinateSystem
    {
        public string Name => "Ascension Island 1958";
        public string Units => "Unspecified";
public long Srid => 4712;

        public string OgcWkt =>
            "GEOGCS[Ascension Island 1958,DATUM[Ascension_Island_1958,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-205,107,53,0,0,0,0],AUTHORITY[EPSG,6712]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4712]]";

        public string EsriWkt => "GEOGCS[Ascension Island 1958,DATUM[D_Ascension_Island_1958,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}