namespace EpsgCoordinateSystems.Other
{
    public class Belge_1972_Belgian_Lambert_72 : IEpsgCoordinateSystem
    {
        public string Name => "Belge 1972 / Belgian Lambert 72";
        public string Units => "Unspecified";
public long Srid => 31370;

        public string OgcWkt =>
            "PROJCS[Belge 1972 / Belgian Lambert 72,GEOGCS[Belge 1972,DATUM[Reseau_National_Belge_1972,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[106.869,-52.2978,103.724,-0.33657,0.456955,-1.84218,1],AUTHORITY[EPSG,6313]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4313]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,51.16666723333333],PARAMETER[standard_parallel_2,49.8333339],PARAMETER[latitude_of_origin,90],PARAMETER[central_meridian,4.367486666666666],PARAMETER[false_easting,150000.013],PARAMETER[false_northing,5400088.438],AUTHORITY[EPSG,31370],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Belge 1972 / Belgian Lambert 72,GEOGCS[Belge 1972,DATUM[Reseau_National_Belge_1972,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[106.869,-52.2978,103.724,-0.33657,0.456955,-1.84218,1],AUTHORITY[EPSG,6313]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4313]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,51.16666723333333],PARAMETER[standard_parallel_2,49.8333339],PARAMETER[latitude_of_origin,90],PARAMETER[central_meridian,4.367486666666666],PARAMETER[false_easting,150000.013],PARAMETER[false_northing,5400088.438],AUTHORITY[EPSG,31370],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}