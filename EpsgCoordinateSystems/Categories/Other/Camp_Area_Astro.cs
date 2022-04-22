namespace EpsgCoordinateSystems.Categories.Other
{
    public class Camp_Area_Astro : IEpsgCoordinateSystem
    {
        public string Name => "Camp Area Astro";
        public string Units => "Unspecified";
public int Srid => 4715;

        public string OgcWkt =>
            "GEOGCS[Camp Area Astro,DATUM[Camp_Area_Astro,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-104,-129,239,0,0,0,0],AUTHORITY[EPSG,6715]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4715]]";

        public string EsriWkt => "GEOGCS[Camp Area Astro,DATUM[D_Camp_Area,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}