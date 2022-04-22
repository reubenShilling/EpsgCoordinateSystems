namespace EpsgCoordinateSystems.Other
{
    public class SWEREF99_RT90_5_gon_O_emulation : IEpsgCoordinateSystem
    {
        public string Name => "SWEREF99 / RT90 5 gon O emulation";
        public string Units => "Unspecified";
public long Srid => 3850;

        public string OgcWkt =>
            "PROJCS[SWEREF99 / RT90 5 gon O emulation,GEOGCS[SWEREF99,DATUM[SWEREF99,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6619]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4619]],PROJECTION[Transverse Mercator,AUTHORITY[EPSG,9807]],PARAMETER[central_meridian,22.556333333333342],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,1.0000049],PARAMETER[false_easting,1500121.846],PARAMETER[false_northing,-672.557],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,3850]]";

        public string EsriWkt =>
            "PROJCS[SWEREF99 / RT90 5 gon O emulation,GEOGCS[SWEREF99,DATUM[SWEREF99,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6619]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4619]],PROJECTION[Transverse Mercator,AUTHORITY[EPSG,9807]],PARAMETER[central_meridian,22.556333333333342],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,1.0000049],PARAMETER[false_easting,1500121.846],PARAMETER[false_northing,-672.557],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,3850]]";
    }
}