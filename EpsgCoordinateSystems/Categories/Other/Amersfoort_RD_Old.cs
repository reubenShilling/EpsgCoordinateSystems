namespace EpsgCoordinateSystems.Categories.Other
{
    public class Amersfoort_RD_Old : IEpsgCoordinateSystem
    {
        public string Name => "Amersfoort / RD Old";
        public string Units => "Unspecified";
public int Srid => 28991;

        public string OgcWkt =>
            "PROJCS[Amersfoort / RD Old,GEOGCS[Amersfoort,DATUM[Amersfoort,SPHEROID[Bessel 1841,6377397.155,299.1528128,AUTHORITY[EPSG,7004]],AUTHORITY[EPSG,6289]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4289]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Oblique_Stereographic],PARAMETER[latitude_of_origin,52.15616055555555],PARAMETER[central_meridian,5.38763888888889],PARAMETER[scale_factor,0.9999079],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,28991],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Amersfoort / RD Old,GEOGCS[Amersfoort,DATUM[D_Amersfoort,SPHEROID[Bessel_1841,6377397.155,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Stereographic_North_Pole],PARAMETER[standard_parallel_1,52.15616055555555],PARAMETER[central_meridian,5.38763888888889],PARAMETER[scale_factor,0.9999079],PARAMETER[false_easting,0],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}