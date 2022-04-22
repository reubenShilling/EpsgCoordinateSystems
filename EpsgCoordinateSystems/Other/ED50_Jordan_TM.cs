namespace EpsgCoordinateSystems.Other
{
    public class ED50_Jordan_TM : IEpsgCoordinateSystem
    {
        public string Name => "ED50 / Jordan TM";
        public string Units => "Unspecified";
public long Srid => 3066;

        public string OgcWkt =>
            "PROJCS[ED50 / Jordan TM,GEOGCS[ED50,DATUM[European_Datum_1950,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6230]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4230]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,37],PARAMETER[scale_factor,0.9998],PARAMETER[false_easting,500000],PARAMETER[false_northing,-3000000],AUTHORITY[EPSG,3066],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[ED50 / Jordan TM,GEOGCS[ED50,DATUM[European_Datum_1950,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6230]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4230]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,37],PARAMETER[scale_factor,0.9998],PARAMETER[false_easting,500000],PARAMETER[false_northing,-3000000],AUTHORITY[EPSG,3066],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}