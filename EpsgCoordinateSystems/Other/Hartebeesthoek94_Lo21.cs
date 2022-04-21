namespace EpsgCoordinateSystems.Other
{
    public class Hartebeesthoek94_Lo21 : IEpsgCoordinateSystem
    {
        public string Name => "Hartebeesthoek94 / Lo21";
        public long Srid => 2049;

        public string OgcWkt =>
            "PROJCS[Hartebeesthoek94 / Lo21,GEOGCS[Hartebeesthoek94,DATUM[Hartebeesthoek94,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6148]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4148]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator_South_Orientated],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,21],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,2049],AXIS[Y,WEST],AXIS[X,SOUTH]]";

        public string EsriWkt =>
            "PROJCS[Hartebeesthoek94 / Lo21,GEOGCS[Hartebeesthoek94,DATUM[Hartebeesthoek94,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6148]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4148]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator_South_Orientated],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,21],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,2049],AXIS[Y,WEST],AXIS[X,SOUTH]]";
    }
}