namespace EpsgCoordinateSystems.Categories.Other
{
    public class ETRS89_Belgian_Lambert_2005 : IEpsgCoordinateSystem
    {
        public string Name => "ETRS89 / Belgian Lambert 2005";
        public string Units => "Unspecified";
public int Srid => 3447;

        public string OgcWkt =>
            "PROJCS[ETRS89 / Belgian Lambert 2005,GEOGCS[ETRS89,DATUM[European_Terrestrial_Reference_System_1989,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4258]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,49.83333333333334],PARAMETER[standard_parallel_2,51.16666666666666],PARAMETER[latitude_of_origin,50.797815],PARAMETER[central_meridian,4.359215833333333],PARAMETER[false_easting,150328],PARAMETER[false_northing,166262],AUTHORITY[EPSG,3447],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[ETRS89 / Belgian Lambert 2005,GEOGCS[ETRS89,DATUM[D_ETRS_1989,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,49.83333333333334],PARAMETER[standard_parallel_2,51.16666666666666],PARAMETER[latitude_of_origin,50.797815],PARAMETER[central_meridian,4.359215833333333],PARAMETER[false_easting,150328],PARAMETER[false_northing,166262],UNIT[Meter,1]]";
    }
}