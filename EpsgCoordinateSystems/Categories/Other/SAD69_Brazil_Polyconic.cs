namespace EpsgCoordinateSystems.Categories.Other
{
    public class SAD69_Brazil_Polyconic : IEpsgCoordinateSystem
    {
        public string Name => "SAD69 / Brazil Polyconic";
        public string Units => "Unspecified";
public int Srid => 29101;

        public string OgcWkt =>
            "PROJCS[SAD69 / Brazil Polyconic,GEOGCS[SAD69,DATUM[South_American_Datum_1969,SPHEROID[GRS 1967 (SAD69),6378160,298.25,AUTHORITY[EPSG,7050]],AUTHORITY[EPSG,6618]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4618]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Polyconic],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-54],PARAMETER[false_easting,5000000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,29101],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[SAD69 / Brazil Polyconic,GEOGCS[SAD69,DATUM[D_South_American_1969,SPHEROID[GRS_1967_SAD69,6378160,298.25]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Polyconic],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-54],PARAMETER[false_easting,5000000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}