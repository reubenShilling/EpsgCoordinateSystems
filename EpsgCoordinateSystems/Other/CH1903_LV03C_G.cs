namespace EpsgCoordinateSystems.Other
{
    public class CH1903_LV03C_G : IEpsgCoordinateSystem
    {
        public string Name => "CH1903 / LV03C-G";
        public string Units => "Unspecified";
public long Srid => 21782;

        public string OgcWkt =>
            "PROJCS[CH1903 / LV03C-G,GEOGCS[CH1903,DATUM[CH1903,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[674.4,15.1,405.3,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6149]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4149]],PROJECTION[Oblique Mercator,AUTHORITY[EPSG,9815]],PARAMETER[longitude_of_center,7.439583333333333],PARAMETER[latitude_of_center,46.952405555555565],PARAMETER[azimuth,90.0],PARAMETER[scale_factor,1.0],PARAMETER[false_easting,0.0],PARAMETER[false_northing,0.0],PARAMETER[rectified_grid_angle,90.0],UNIT[m,1.0],AXIS[Easting,EAST],AXIS[Northing,NORTH],AUTHORITY[EPSG,21782]]";

        public string EsriWkt =>
            "PROJCS[CH1903 / LV03C-G,GEOGCS[CH1903,DATUM[CH1903,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[674.4,15.1,405.3,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6149]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4149]],PROJECTION[Oblique Mercator,AUTHORITY[EPSG,9815]],PARAMETER[longitude_of_center,7.439583333333333],PARAMETER[latitude_of_center,46.952405555555565],PARAMETER[azimuth,90.0],PARAMETER[scale_factor,1.0],PARAMETER[false_easting,0.0],PARAMETER[false_northing,0.0],PARAMETER[rectified_grid_angle,90.0],UNIT[m,1.0],AXIS[Easting,EAST],AXIS[Northing,NORTH],AUTHORITY[EPSG,21782]]";
    }
}