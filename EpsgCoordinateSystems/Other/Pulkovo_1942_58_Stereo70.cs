namespace EpsgCoordinateSystems.Other
{
    public class Pulkovo_1942_58_Stereo70 : IEpsgCoordinateSystem
    {
        public string Name => "Pulkovo 1942(58) / Stereo70";
        public long Srid => 3844;

        public string OgcWkt =>
            "PROJCS[Pulkovo 1942(58) / Stereo70,GEOGCS[Pulkovo 1942(58),DATUM[Pulkovo 1942(58),SPHEROID[Krassowsky 1940,6378245.0,298.3,AUTHORITY[EPSG,7024]],TOWGS84[33.4,-146.6,-76.3,-0.359,-0.053,0.844,-0.17326243724756094],AUTHORITY[EPSG,6179]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4179]],PROJECTION[Oblique Stereographic,AUTHORITY[EPSG,9809]],PARAMETER[central_meridian,25.0],PARAMETER[latitude_of_origin,46.0],PARAMETER[scale_factor,0.99975],PARAMETER[false_easting,500000.0],PARAMETER[false_northing,500000.0],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,3844]]";

        public string EsriWkt =>
            "PROJCS[Pulkovo 1942(58) / Stereo70,GEOGCS[Pulkovo 1942(58),DATUM[Pulkovo 1942(58),SPHEROID[Krassowsky 1940,6378245.0,298.3,AUTHORITY[EPSG,7024]],TOWGS84[33.4,-146.6,-76.3,-0.359,-0.053,0.844,-0.17326243724756094],AUTHORITY[EPSG,6179]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4179]],PROJECTION[Oblique Stereographic,AUTHORITY[EPSG,9809]],PARAMETER[central_meridian,25.0],PARAMETER[latitude_of_origin,46.0],PARAMETER[scale_factor,0.99975],PARAMETER[false_easting,500000.0],PARAMETER[false_northing,500000.0],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,3844]]";
    }
}