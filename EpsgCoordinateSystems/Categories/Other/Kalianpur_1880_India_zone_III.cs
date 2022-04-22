namespace EpsgCoordinateSystems.Categories.Other
{
    public class Kalianpur_1880_India_zone_III : IEpsgCoordinateSystem
    {
        public string Name => "Kalianpur 1880 / India zone III";
        public string Units => "Unspecified";
public int Srid => 24373;

        public string OgcWkt =>
            "PROJCS[Kalianpur 1880 / India zone III,GEOGCS[Kalianpur 1880,DATUM[Kalianpur_1880,SPHEROID[Everest (1830 Definition),6377299.36559538,300.8017255433612,AUTHORITY[EPSG,7042]],AUTHORITY[EPSG,6243]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4243]],UNIT[Indian yard,0.9143985307444408,AUTHORITY[EPSG,9084]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,19],PARAMETER[central_meridian,80],PARAMETER[scale_factor,0.99878641],PARAMETER[false_easting,3000000],PARAMETER[false_northing,1000000],AUTHORITY[EPSG,24373],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Kalianpur 1880 / India zone III,GEOGCS[Kalianpur 1880,DATUM[D_Kalianpur_1880,SPHEROID[Everest_1830_Definition,6377299.36559538,300.8017255433612]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,19],PARAMETER[central_meridian,80],PARAMETER[scale_factor,0.99878641],PARAMETER[false_easting,3000000],PARAMETER[false_northing,1000000],UNIT[Indian yard,0.9143985307444408]]";
    }
}