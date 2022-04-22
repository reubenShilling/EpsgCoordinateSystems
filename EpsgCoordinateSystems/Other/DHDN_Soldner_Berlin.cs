namespace EpsgCoordinateSystems.Other
{
    public class DHDN_Soldner_Berlin : IEpsgCoordinateSystem
    {
        public string Name => "DHDN / Soldner Berlin";
        public string Units => "Unspecified";
public long Srid => 3068;

        public string OgcWkt =>
            "PROJCS[DHDN / Soldner Berlin,GEOGCS[DHDN,DATUM[Deutsches_Hauptdreiecksnetz,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6314]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4314]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Cassini_Soldner],PARAMETER[latitude_of_origin,52.41864827777778],PARAMETER[central_meridian,13.62720366666667],PARAMETER[false_easting,40000],PARAMETER[false_northing,10000],AUTHORITY[EPSG,3068],AXIS[y,EAST],AXIS[x,NORTH]]";

        public string EsriWkt =>
            "PROJCS[DHDN / Soldner Berlin,GEOGCS[DHDN,DATUM[Deutsches_Hauptdreiecksnetz,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6314]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4314]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Cassini_Soldner],PARAMETER[latitude_of_origin,52.41864827777778],PARAMETER[central_meridian,13.62720366666667],PARAMETER[false_easting,40000],PARAMETER[false_northing,10000],AUTHORITY[EPSG,3068],AXIS[y,EAST],AXIS[x,NORTH]]";
    }
}