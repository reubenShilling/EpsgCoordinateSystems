namespace EpsgCoordinateSystems.Other
{
    public class Perroud_1950_Terre_Adelie_Polar_Stereographic : IEpsgCoordinateSystem
    {
        public string Name => "Perroud 1950 / Terre Adelie Polar Stereographic";
        public string Units => "Unspecified";
public long Srid => 2986;

        public string OgcWkt =>
            "PROJCS[Perroud 1950 / Terre Adelie Polar Stereographic,GEOGCS[Perroud 1950,DATUM[Pointe_Geologie_Perroud_1950,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[325,154,172,0,0,0,0],AUTHORITY[EPSG,6637]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4637],AXIS[Latitude,NORTH],AXIS[Longitude,EAST]],UNIT[metre,1,AUTHORITY[EPSG,9001]]]";

        public string EsriWkt =>
            "PROJCS[Perroud 1950 / Terre Adelie Polar Stereographic,GEOGCS[Perroud 1950,DATUM[Pointe_Geologie_Perroud_1950,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[325,154,172,0,0,0,0],AUTHORITY[EPSG,6637]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4637],AXIS[Latitude,NORTH],AXIS[Longitude,EAST]],UNIT[metre,1,AUTHORITY[EPSG,9001]]]";
    }
}