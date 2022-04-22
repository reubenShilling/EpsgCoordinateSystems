namespace EpsgCoordinateSystems.Other
{
    public class Hjorsey_1955_Lambert_1955 : IEpsgCoordinateSystem
    {
        public string Name => "Hjorsey 1955 / Lambert 1955";
        public string Units => "Unspecified";
public long Srid => 3053;

        public string OgcWkt =>
            "PROJCS[Hjorsey 1955 / Lambert 1955,GEOGCS[Hjorsey 1955,DATUM[Hjorsey_1955,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-73,46,-86,0,0,0,0],AUTHORITY[EPSG,6658]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4658],AXIS[Latitude,NORTH],AXIS[Longitude,EAST]],UNIT[metre,1,AUTHORITY[EPSG,9001]]]";

        public string EsriWkt => "PROJCS[Hjorsey 1955 / Lambert 1955,GEOGCS[Hjorsey 1955,DATUM[D_Hjorsey_1955,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],UNIT[Meter,1]]";
    }
}