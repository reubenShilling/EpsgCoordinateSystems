namespace EpsgCoordinateSystems.Other
{
    public class Ammassalik_1958_Greenland_zone_7_east : IEpsgCoordinateSystem
    {
        public string Name => "Ammassalik 1958 / Greenland zone 7 east";
        public string Units => "Unspecified";
public long Srid => 2296;

        public string OgcWkt =>
            "PROJCS[Ammassalik 1958 / Greenland zone 7 east,GEOGCS[Ammassalik 1958,DATUM[Ammassalik_1958,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-45,417,-3.5,0,0,0.814,-0.6],AUTHORITY[EPSG,6196]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4196],AXIS[Latitude,NORTH],AXIS[Longitude,EAST]],UNIT[metre,1,AUTHORITY[EPSG,9001]]]";

        public string EsriWkt =>
            "PROJCS[Ammassalik 1958 / Greenland zone 7 east,GEOGCS[Ammassalik 1958,DATUM[Ammassalik_1958,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-45,417,-3.5,0,0,0.814,-0.6],AUTHORITY[EPSG,6196]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4196],AXIS[Latitude,NORTH],AXIS[Longitude,EAST]],UNIT[metre,1,AUTHORITY[EPSG,9001]]]";
    }
}