namespace EpsgCoordinateSystems.Other
{
    public class SWEREF99_RT90_7_5_gon_V_emulation : IEpsgCoordinateSystem
    {
        public string Name => "SWEREF99 / RT90 7.5 gon V emulation";
        public string Units => "Unspecified";
public long Srid => 3845;

        public string OgcWkt =>
            "PROJCS[SWEREF99 / RT90 7.5 gon V emulation,GEOGCS[SWEREF99,DATUM[SWEREF99,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6619]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4619]],PROJECTION[Transverse Mercator,AUTHORITY[EPSG,9807]],PARAMETER[central_meridian,11.30625],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,1.000006],PARAMETER[false_easting,1500025.141],PARAMETER[false_northing,-667.282],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,3845]]";

        public string EsriWkt => "PROJCS[SWEREF99 / RT90 7.5 gon V emulation,GEOGCS[SWEREF99,DATUM[D_SWEREF99,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse Mercator],PARAMETER[central_meridian,11.30625],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,1.000006],PARAMETER[false_easting,1500025.141],PARAMETER[false_northing,-667.282],UNIT[m,1.0]]";
    }
}