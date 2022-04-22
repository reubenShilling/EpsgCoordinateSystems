namespace EpsgCoordinateSystems.Categories.Other
{
    public class NAD83_Mississippi_East : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / Mississippi East";
        public string Units => "Unspecified";
public int Srid => 26994;

        public string OgcWkt =>
            "PROJCS[NAD83 / Mississippi East,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,29.5],PARAMETER[central_meridian,-88.83333333333333],PARAMETER[scale_factor,0.99995],PARAMETER[false_easting,300000],PARAMETER[false_northing,0],AUTHORITY[EPSG,26994],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83 / Mississippi East,GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,29.5],PARAMETER[central_meridian,-88.83333333333333],PARAMETER[scale_factor,0.99995],PARAMETER[false_easting,300000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}