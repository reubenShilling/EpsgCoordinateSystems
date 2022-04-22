namespace EpsgCoordinateSystems.Other
{
    public class ST74 : IEpsgCoordinateSystem
    {
        public string Name => "ST74";
        public string Units => "Unspecified";
public long Srid => 3152;

        public string OgcWkt =>
            "PROJCS[ST74,GEOGCS[SWEREF99,DATUM[SWEREF99,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6619]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4619]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,18.05779],PARAMETER[scale_factor,0.99999425],PARAMETER[false_easting,100178.1808],PARAMETER[false_northing,-6500614.7836],AUTHORITY[EPSG,3152],AXIS[y,EAST],AXIS[x,NORTH]]";

        public string EsriWkt => "PROJCS[ST74,GEOGCS[SWEREF99,DATUM[D_SWEREF99,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,18.05779],PARAMETER[scale_factor,0.99999425],PARAMETER[false_easting,100178.1808],PARAMETER[false_northing,-6500614.7836],UNIT[Meter,1]]";
    }
}