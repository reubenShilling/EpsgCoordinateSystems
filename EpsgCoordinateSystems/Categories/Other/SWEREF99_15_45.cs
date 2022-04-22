namespace EpsgCoordinateSystems.Categories.Other
{
    public class SWEREF99_15_45 : IEpsgCoordinateSystem
    {
        public string Name => "SWEREF99 15 45";
        public string Units => "Unspecified";
public int Srid => 3013;

        public string OgcWkt =>
            "PROJCS[SWEREF99 15 45,GEOGCS[SWEREF99,DATUM[SWEREF99,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6619]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4619]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15.75],PARAMETER[scale_factor,1],PARAMETER[false_easting,150000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3013],AXIS[y,EAST],AXIS[x,NORTH]]";

        public string EsriWkt => "PROJCS[SWEREF99 15 45,GEOGCS[SWEREF99,DATUM[D_SWEREF99,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15.75],PARAMETER[scale_factor,1],PARAMETER[false_easting,150000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}