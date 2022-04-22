namespace EpsgCoordinateSystems.Categories.Other
{
    public class Kalianpur_1937_India_zone_IIb : IEpsgCoordinateSystem
    {
        public string Name => "Kalianpur 1937 / India zone IIb";
        public string Units => "Unspecified";
public int Srid => 24375;

        public string OgcWkt =>
            "PROJCS[Kalianpur 1937 / India zone IIb,GEOGCS[Kalianpur 1937,DATUM[Kalianpur_1937,SPHEROID[Everest 1830 (1937 Adjustment),6377276.345,300.8017,AUTHORITY[EPSG,7015]],AUTHORITY[EPSG,6144]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4144]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,26],PARAMETER[central_meridian,90],PARAMETER[scale_factor,0.99878641],PARAMETER[false_easting,2743185.69],PARAMETER[false_northing,914395.23],AUTHORITY[EPSG,24375],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Kalianpur 1937 / India zone IIb,GEOGCS[Kalianpur 1937,DATUM[D_Kalianpur_1937,SPHEROID[Everest_1830_1937_Adjustment,6377276.345,300.8017]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,26],PARAMETER[central_meridian,90],PARAMETER[scale_factor,0.99878641],PARAMETER[false_easting,2743185.69],PARAMETER[false_northing,914395.23],UNIT[Meter,1]]";
    }
}