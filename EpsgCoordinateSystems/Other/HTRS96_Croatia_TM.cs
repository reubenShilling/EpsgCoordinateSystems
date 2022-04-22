namespace EpsgCoordinateSystems.Other
{
    public class HTRS96_Croatia_TM : IEpsgCoordinateSystem
    {
        public string Name => "HTRS96 / Croatia TM";
        public string Units => "Unspecified";
public long Srid => 3765;

        public string OgcWkt =>
            "PROJCS[HTRS96 / Croatia TM,GEOGCS[HTRS96,DATUM[Croatian_Terrestrial_Reference_System,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6761]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4761]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,16.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,3765],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[HTRS96 / Croatia TM,GEOGCS[HTRS96,DATUM[D_Croatian_Terrestrial_Reference_System,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,16.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}