namespace EpsgCoordinateSystems.Other
{
    public class SWEREF99_RT90_0_gon_emulation : IEpsgCoordinateSystem
    {
        public string Name => "SWEREF99 / RT90 0 gon emulation";
        public string Units => "Unspecified";
public long Srid => 3848;

        public string OgcWkt =>
            "PROJCS[SWEREF99 / RT90 0 gon emulation,GEOGCS[SWEREF99,DATUM[SWEREF99,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6619]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4619]],PROJECTION[Transverse Mercator,AUTHORITY[EPSG,9807]],PARAMETER[central_meridian,18.056299999999997],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,1.0000054],PARAMETER[false_easting,1500083.521],PARAMETER[false_northing,-668.844],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,3848]]";

        public string EsriWkt =>
            "PROJCS[SWEREF99 / RT90 0 gon emulation,GEOGCS[SWEREF99,DATUM[SWEREF99,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6619]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4619]],PROJECTION[Transverse Mercator,AUTHORITY[EPSG,9807]],PARAMETER[central_meridian,18.056299999999997],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,1.0000054],PARAMETER[false_easting,1500083.521],PARAMETER[false_northing,-668.844],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,3848]]";
    }
}