namespace EpsgCoordinateSystems.Other
{
    public class Qatar_1948_Qatar_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Qatar 1948 / Qatar Grid";
        public string Units => "Unspecified";
public long Srid => 2099;

        public string OgcWkt =>
            "PROJCS[Qatar 1948 / Qatar Grid,GEOGCS[Qatar 1948,DATUM[Qatar_1948,SPHEROID[Helmert 1906,6378200,298.3,AUTHORITY[EPSG,7020]],AUTHORITY[EPSG,6286]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4286]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Cassini_Soldner],PARAMETER[latitude_of_origin,25.38236111111111],PARAMETER[central_meridian,50.76138888888889],PARAMETER[false_easting,100000],PARAMETER[false_northing,100000],AUTHORITY[EPSG,2099],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Qatar 1948 / Qatar Grid,GEOGCS[Qatar 1948,DATUM[Qatar_1948,SPHEROID[Helmert 1906,6378200,298.3,AUTHORITY[EPSG,7020]],AUTHORITY[EPSG,6286]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4286]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Cassini_Soldner],PARAMETER[latitude_of_origin,25.38236111111111],PARAMETER[central_meridian,50.76138888888889],PARAMETER[false_easting,100000],PARAMETER[false_northing,100000],AUTHORITY[EPSG,2099],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}