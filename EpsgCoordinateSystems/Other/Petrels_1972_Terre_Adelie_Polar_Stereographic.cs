namespace EpsgCoordinateSystems.Other
{
    public class Petrels_1972_Terre_Adelie_Polar_Stereographic : IEpsgCoordinateSystem
    {
        public string Name => "Petrels 1972 / Terre Adelie Polar Stereographic";
        public string Units => "Unspecified";
public long Srid => 2985;

        public string OgcWkt =>
            "PROJCS[Petrels 1972 / Terre Adelie Polar Stereographic,GEOGCS[Petrels 1972,DATUM[Petrels_1972,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[365,194,166,0,0,0,0],AUTHORITY[EPSG,6636]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4636],AXIS[Latitude,NORTH],AXIS[Longitude,EAST]],UNIT[metre,1,AUTHORITY[EPSG,9001]]]";

        public string EsriWkt =>
            "PROJCS[Petrels 1972 / Terre Adelie Polar Stereographic,GEOGCS[Petrels 1972,DATUM[Petrels_1972,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[365,194,166,0,0,0,0],AUTHORITY[EPSG,6636]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4636],AXIS[Latitude,NORTH],AXIS[Longitude,EAST]],UNIT[metre,1,AUTHORITY[EPSG,9001]]]";
    }
}