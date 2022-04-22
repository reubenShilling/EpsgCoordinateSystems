namespace EpsgCoordinateSystems.Other
{
    public class JAD69_Jamaica_National_Grid : IEpsgCoordinateSystem
    {
        public string Name => "JAD69 / Jamaica National Grid";
        public string Units => "Unspecified";
public long Srid => 24200;

        public string OgcWkt =>
            "PROJCS[JAD69 / Jamaica National Grid,GEOGCS[JAD69,DATUM[Jamaica_1969,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],AUTHORITY[EPSG,6242]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4242]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,18],PARAMETER[central_meridian,-77],PARAMETER[scale_factor,1],PARAMETER[false_easting,250000],PARAMETER[false_northing,150000],AUTHORITY[EPSG,24200],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[JAD69 / Jamaica National Grid,GEOGCS[JAD69,DATUM[D_Jamaica_1969,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,18],PARAMETER[central_meridian,-77],PARAMETER[scale_factor,1],PARAMETER[false_easting,250000],PARAMETER[false_northing,150000],UNIT[Meter,1]]";
    }
}