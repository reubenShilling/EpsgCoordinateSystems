namespace EpsgCoordinateSystems.Other
{
    public class Amersfoort_RD_New_NAP : IEpsgCoordinateSystem
    {
        public string Name => "Amersfoort / RD New + NAP";
        public string Units => "Unspecified";
public long Srid => 7415;

        public string OgcWkt =>
            "COMPD_CS[Amersfoort / RD New + NAP,PROJCS[Amersfoort / RD New,GEOGCS[Amersfoort,DATUM[Amersfoort,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],TOWGS84[565.04,49.91,465.84,-0.40939438743923684,-0.35970519561431136,1.868491000350572,0.8409828680306614],AUTHORITY[EPSG,6289]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4289]],PROJECTION[Oblique Stereographic,AUTHORITY[EPSG,9809]],PARAMETER[central_meridian,5.387638888888891],PARAMETER[latitude_of_origin,52.15616055555556],PARAMETER[scale_factor,0.9999079],PARAMETER[false_easting,155000.0],PARAMETER[false_northing,463000.0],UNIT[m,1.0],AXIS[Easting,EAST],AXIS[Northing,NORTH],AUTHORITY[EPSG,28992]],VERT_CS[Normaal Amsterdams Peil,VERT_DATUM[Normaal Amsterdams Peil,2005,AUTHORITY[EPSG,5109]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5709]],AUTHORITY[EPSG,7415]]";

        public string EsriWkt => "COMPD_CS[Amersfoort / RD New + NAP,PROJCS[Amersfoort / RD New,GEOGCS[Amersfoort,DATUM[D_Amersfoort,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]],PROJECTION[Oblique Stereographic],PARAMETER[central_meridian,5.387638888888891],PARAMETER[latitude_of_origin,52.15616055555556],PARAMETER[scale_factor,0.9999079],PARAMETER[false_easting,155000.0],PARAMETER[false_northing,463000.0],UNIT[m,1.0]],VERT_CS[Normaal Amsterdams Peil,VERT_DATUM[Normaal Amsterdams Peil,2005],UNIT[m,1.0]]]";
    }
}