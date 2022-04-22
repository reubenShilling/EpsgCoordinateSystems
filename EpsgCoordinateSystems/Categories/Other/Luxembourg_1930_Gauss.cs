namespace EpsgCoordinateSystems.Categories.Other
{
    public class Luxembourg_1930_Gauss : IEpsgCoordinateSystem
    {
        public string Name => "Luxembourg 1930 / Gauss";
        public string Units => "Unspecified";
public int Srid => 2169;

        public string OgcWkt =>
            "PROJCS[Luxembourg 1930 / Gauss,GEOGCS[Luxembourg 1930,DATUM[Luxembourg_1930,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-193,13.7,-39.3,-0.41,-2.933,2.688,0.43],AUTHORITY[EPSG,6181]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4181]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,49.83333333333334],PARAMETER[central_meridian,6.166666666666667],PARAMETER[scale_factor,1],PARAMETER[false_easting,80000],PARAMETER[false_northing,100000],AUTHORITY[EPSG,2169],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[Luxembourg 1930 / Gauss,GEOGCS[Luxembourg 1930,DATUM[D_Luxembourg_1930,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,49.83333333333334],PARAMETER[central_meridian,6.166666666666667],PARAMETER[scale_factor,1],PARAMETER[false_easting,80000],PARAMETER[false_northing,100000],UNIT[Meter,1]]";
    }
}