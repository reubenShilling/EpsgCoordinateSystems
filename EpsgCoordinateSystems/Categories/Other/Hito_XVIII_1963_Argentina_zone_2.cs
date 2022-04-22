namespace EpsgCoordinateSystems.Categories.Other
{
    public class Hito_XVIII_1963_Argentina_zone_2 : IEpsgCoordinateSystem
    {
        public string Name => "Hito XVIII 1963 / Argentina zone 2";
        public string Units => "Unspecified";
public int Srid => 2083;

        public string OgcWkt =>
            "PROJCS[Hito XVIII 1963 / Argentina zone 2,GEOGCS[Hito XVIII 1963,DATUM[Hito_XVIII_1963,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6254]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4254]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,-69],PARAMETER[scale_factor,1],PARAMETER[false_easting,2500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2083],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[Hito XVIII 1963 / Argentina zone 2,GEOGCS[Hito XVIII 1963,DATUM[D_Hito_XVIII_1963,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-90],PARAMETER[central_meridian,-69],PARAMETER[scale_factor,1],PARAMETER[false_easting,2500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}