namespace EpsgCoordinateSystems.Other
{
    public class OSGB_1936_British_National_Grid : IEpsgCoordinateSystem
    {
        public string Name => "OSGB 1936 / British National Grid";
        public string Units => "Unspecified";
public long Srid => 27700;

        public string OgcWkt =>
            "PROJCS[OSGB 1936 / British National Grid,GEOGCS[OSGB 1936,DATUM[OSGB_1936,SPHEROID[Airy 1830,6377563.396,299.3249646,AUTHORITY[EPSG,7001]],AUTHORITY[EPSG,6277]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4277]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,49],PARAMETER[central_meridian,-2],PARAMETER[scale_factor,0.9996012717],PARAMETER[false_easting,400000],PARAMETER[false_northing,-100000],AUTHORITY[EPSG,27700],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[OSGB 1936 / British National Grid,GEOGCS[OSGB 1936,DATUM[D_OSGB_1936,SPHEROID[Airy_1830,6377563.396,299.3249646]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,49],PARAMETER[central_meridian,-2],PARAMETER[scale_factor,0.9996012717],PARAMETER[false_easting,400000],PARAMETER[false_northing,-100000],UNIT[Meter,1]]";
    }
}