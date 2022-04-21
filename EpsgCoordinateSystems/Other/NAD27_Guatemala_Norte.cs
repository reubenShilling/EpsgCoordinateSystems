namespace EpsgCoordinateSystems.Other
{
    public class NAD27_Guatemala_Norte : IEpsgCoordinateSystem
    {
        public string Name => "NAD27 / Guatemala Norte";
        public long Srid => 32061;

        public string OgcWkt =>
            "PROJCS[NAD27 / Guatemala Norte,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,16.81666666666667],PARAMETER[central_meridian,-90.33333333333333],PARAMETER[scale_factor,0.99992226],PARAMETER[false_easting,500000],PARAMETER[false_northing,292209.579],AUTHORITY[EPSG,32061],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD27 / Guatemala Norte,GEOGCS[NAD27,DATUM[North_American_Datum_1927,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6267]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4267]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,16.81666666666667],PARAMETER[central_meridian,-90.33333333333333],PARAMETER[scale_factor,0.99992226],PARAMETER[false_easting,500000],PARAMETER[false_northing,292209.579],AUTHORITY[EPSG,32061],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}