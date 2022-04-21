namespace EpsgCoordinateSystems.Other
{
    public class WGS_84_North_Pole_LAEA_Bering_Sea : IEpsgCoordinateSystem
    {
        public string Name => "WGS 84 / North Pole LAEA Bering Sea";
        public long Srid => 3571;

        public string OgcWkt =>
            "PROJCS[WGS 84 / North Pole LAEA Bering Sea,GEOGCS[WGS 84,DATUM[WGS_1984,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4326]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Azimuthal_Equal_Area],PARAMETER[latitude_of_center,90],PARAMETER[longitude_of_center,180],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3571],AXIS[X,UNKNOWN],AXIS[Y,UNKNOWN]]";

        public string EsriWkt =>
            "PROJCS[WGS 84 / North Pole LAEA Bering Sea,GEOGCS[WGS 84,DATUM[WGS_1984,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6326]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4326]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Azimuthal_Equal_Area],PARAMETER[latitude_of_center,90],PARAMETER[longitude_of_center,180],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3571],AXIS[X,UNKNOWN],AXIS[Y,UNKNOWN]]";
    }
}