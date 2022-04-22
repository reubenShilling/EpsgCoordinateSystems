namespace EpsgCoordinateSystems.Categories.Other
{
    public class ED50_3_degree_Gauss_Kruger_zone_12 : IEpsgCoordinateSystem
    {
        public string Name => "ED50 / 3-degree Gauss-Kruger zone 12";
        public string Units => "Unspecified";
public int Srid => 2209;

        public string OgcWkt =>
            "PROJCS[ED50 / 3-degree Gauss-Kruger zone 12,GEOGCS[ED50,DATUM[European_Datum_1950,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6230]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4230]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,36],PARAMETER[scale_factor,1],PARAMETER[false_easting,12500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2209],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[ED50 / 3-degree Gauss-Kruger zone 12,GEOGCS[ED50,DATUM[D_European_1950,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,36],PARAMETER[scale_factor,1],PARAMETER[false_easting,12500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}