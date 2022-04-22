namespace EpsgCoordinateSystems.Other
{
    public class NAD83_Missouri_Central : IEpsgCoordinateSystem
    {
        public string Name => "NAD83 / Missouri Central";
        public string Units => "Unspecified";
public long Srid => 26997;

        public string OgcWkt =>
            "PROJCS[NAD83 / Missouri Central,GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,35.83333333333334],PARAMETER[central_meridian,-92.5],PARAMETER[scale_factor,0.999933333],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,26997],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD83 / Missouri Central,GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,35.83333333333334],PARAMETER[central_meridian,-92.5],PARAMETER[scale_factor,0.999933333],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}