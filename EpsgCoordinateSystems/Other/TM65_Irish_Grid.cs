namespace EpsgCoordinateSystems.Other
{
    public class TM65_Irish_Grid : IEpsgCoordinateSystem
    {
        public string Name => "TM65 / Irish Grid";
        public string Units => "Unspecified";
public long Srid => 29902;

        public string OgcWkt =>
            "PROJCS[TM65 / Irish Grid,GEOGCS[TM65,DATUM[TM65,SPHEROID[Airy Modified 1849,6377340.189,299.3249646,AUTHORITY[EPSG,7002]],AUTHORITY[EPSG,6299]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4299]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,53.5],PARAMETER[central_meridian,-8],PARAMETER[scale_factor,1.000035],PARAMETER[false_easting,200000],PARAMETER[false_northing,250000],AUTHORITY[EPSG,29902],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt =>
            "PROJCS[TM65 / Irish Grid,GEOGCS[TM65,DATUM[TM65,SPHEROID[Airy Modified 1849,6377340.189,299.3249646,AUTHORITY[EPSG,7002]],AUTHORITY[EPSG,6299]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4299]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,53.5],PARAMETER[central_meridian,-8],PARAMETER[scale_factor,1.000035],PARAMETER[false_easting,200000],PARAMETER[false_northing,250000],AUTHORITY[EPSG,29902],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";
    }
}