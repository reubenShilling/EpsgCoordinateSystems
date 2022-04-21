namespace EpsgCoordinateSystems.Other
{
    public class OSGB36_British_National_Grid_ODN : IEpsgCoordinateSystem
    {
        public string Name => "OSGB36 / British National Grid + ODN";
        public long Srid => 7405;

        public string OgcWkt =>
            "COMPD_CS[OSGB36 / British National Grid + ODN,PROJCS[OSGB 1936 / British National Grid,GEOGCS[OSGB 1936,DATUM[OSGB 1936,SPHEROID[Airy 1830,6377563.396,299.3249646,AUTHORITY[EPSG,7001]],TOWGS84[446.448,-125.157,542.06,0.15,0.247,0.842,-4.2261596151967575],AUTHORITY[EPSG,6277]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4277]],PROJECTION[Transverse Mercator,AUTHORITY[EPSG,9807]],PARAMETER[central_meridian,-2.0],PARAMETER[latitude_of_origin,49.0],PARAMETER[scale_factor,0.9996012717],PARAMETER[false_easting,400000.0],PARAMETER[false_northing,-100000.0],UNIT[m,1.0],AXIS[Easting,EAST],AXIS[Northing,NORTH],AUTHORITY[EPSG,27700]],VERT_CS[Newlyn,VERT_DATUM[Ordnance Datum Newlyn,2005,AUTHORITY[EPSG,5101]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5701]],AUTHORITY[EPSG,7405]]";

        public string EsriWkt =>
            "COMPD_CS[OSGB36 / British National Grid + ODN,PROJCS[OSGB 1936 / British National Grid,GEOGCS[OSGB 1936,DATUM[OSGB 1936,SPHEROID[Airy 1830,6377563.396,299.3249646,AUTHORITY[EPSG,7001]],TOWGS84[446.448,-125.157,542.06,0.15,0.247,0.842,-4.2261596151967575],AUTHORITY[EPSG,6277]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4277]],PROJECTION[Transverse Mercator,AUTHORITY[EPSG,9807]],PARAMETER[central_meridian,-2.0],PARAMETER[latitude_of_origin,49.0],PARAMETER[scale_factor,0.9996012717],PARAMETER[false_easting,400000.0],PARAMETER[false_northing,-100000.0],UNIT[m,1.0],AXIS[Easting,EAST],AXIS[Northing,NORTH],AUTHORITY[EPSG,27700]],VERT_CS[Newlyn,VERT_DATUM[Ordnance Datum Newlyn,2005,AUTHORITY[EPSG,5101]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5701]],AUTHORITY[EPSG,7405]]";
    }
}