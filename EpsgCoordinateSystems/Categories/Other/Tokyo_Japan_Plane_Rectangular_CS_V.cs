namespace EpsgCoordinateSystems.Categories.Other
{
    public class Tokyo_Japan_Plane_Rectangular_CS_V : IEpsgCoordinateSystem
    {
        public string Name => "Tokyo / Japan Plane Rectangular CS V";
        public string Units => "Unspecified";
public int Srid => 30165;

        public string OgcWkt =>
            "PROJCS[Tokyo / Japan Plane Rectangular CS V,GEOGCS[Tokyo,DATUM[Tokyo,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6301]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4301]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,36],PARAMETER[central_meridian,134.3333333333333],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,30165],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[Tokyo / Japan Plane Rectangular CS V,GEOGCS[Tokyo,DATUM[D_Tokyo,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,36],PARAMETER[central_meridian,134.3333333333333],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,0],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}