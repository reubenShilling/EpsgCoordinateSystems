namespace EpsgCoordinateSystems.Categories.Other
{
    public class NAD27_Indiana_West : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 / Indiana West";
        public string Units => "Unspecified";
public int Srid => 26774;

        public string OgcWkt =>
            "PROJCS[NAD27 / Indiana West,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,37.5],PARAMETER[central_meridian,-87.08333333333333],PARAMETER[scale_factor,0.999966667],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,26774],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[NAD27 / Indiana West,GEOGCS[GCS_North_American_1927,DATUM[D_North_American_1927,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,37.5],PARAMETER[central_meridian,-87.08333333333333],PARAMETER[scale_factor,0.999966667],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";
    }
}