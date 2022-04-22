namespace EpsgCoordinateSystems.Other
{
    public class Cape_Lo15 : IEpsgCoordinateSystem
    {
        public string Name => "Cape / Lo15";
        public string Units => "Unspecified";
public long Srid => 22275;

        public string OgcWkt =>
            "PROJCS[Cape / Lo15,GEOGCS[Cape,DATUM[Cape,SPHEROID[Clarke 1880 (Arc),6378249.145,293.4663077,AUTHORITY[EPSG,7013]],AUTHORITY[EPSG,6222]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4222]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator_South_Orientated],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,22275],AXIS[Y,WEST],AXIS[X,SOUTH]]";

        public string EsriWkt => "PROJCS[Cape / Lo15,GEOGCS[Cape,DATUM[D_Cape,SPHEROID[Clarke_1880_Arc,6378249.145,293.4663077]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator_South_Orientated],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}