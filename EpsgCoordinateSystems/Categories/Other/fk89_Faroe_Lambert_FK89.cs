namespace EpsgCoordinateSystems.Categories.Other
{
    public class fk89_Faroe_Lambert_FK89 : IEpsgCoordinateSystem
    {
        public string Name => "fk89 / Faroe Lambert FK89";
        public string Units => "Unspecified";
public int Srid => 3173;

        public string OgcWkt =>
            "PROJCS[fk89 / Faroe Lambert FK89,GEOGCS[fk89,DATUM[fk89,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6753]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4753],AXIS[Latitude,NORTH],AXIS[Longitude,EAST]],UNIT[metre,1,AUTHORITY[EPSG,9001]]]";

        public string EsriWkt => "PROJCS[fk89 / Faroe Lambert FK89,GEOGCS[fk89,DATUM[D_,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],UNIT[Meter,1]]";
    }
}