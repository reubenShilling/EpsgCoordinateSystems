namespace EpsgCoordinateSystems.Other
{
    public class Katanga_1955_Katanga_TM : IEpsgCoordinateSystem
    {
        public string Name => "Katanga 1955 / Katanga TM";
        public long Srid => 3315;

        public string OgcWkt =>
            "PROJCS[Katanga 1955 / Katanga TM,GEOGCS[Katanga 1955,DATUM[Katanga_1955,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6695]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4695]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-9],PARAMETER[central_meridian,26],PARAMETER[scale_factor,0.9998],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3315],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Katanga 1955 / Katanga TM,GEOGCS[Katanga 1955,DATUM[Katanga_1955,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6695]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4695]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-9],PARAMETER[central_meridian,26],PARAMETER[scale_factor,0.9998],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3315],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}