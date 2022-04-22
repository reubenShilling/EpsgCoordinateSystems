namespace EpsgCoordinateSystems.Other
{
    public class Belge_1972_Belge_Lambert_72 : IEpsgCoordinateSystem
    {
        public string Name => "Belge 1972 / Belge Lambert 72";
        public string Units => "Unspecified";
public long Srid => 31300;

        public string OgcWkt =>
            "PROJCS[Belge 1972 / Belge Lambert 72,GEOGCS[Belge 1972,DATUM[Reseau_National_Belge_1972,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[106.869,-52.2978,103.724,-0.33657,0.456955,-1.84218,1],AUTHORITY[EPSG,6313]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4313]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP_Belgium)],PARAMETER[standard_parallel_1,49.83333333333334],PARAMETER[standard_parallel_2,51.16666666666666],PARAMETER[latitude_of_origin,90],PARAMETER[central_meridian,4.356939722222222],PARAMETER[false_easting,150000.01256],PARAMETER[false_northing,5400088.4378],AUTHORITY[EPSG,31300],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Belge 1972 / Belge Lambert 72,GEOGCS[Belge 1972,DATUM[D_Belge_1972,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic_2SP_Belgium)],PARAMETER[standard_parallel_1,49.83333333333334],PARAMETER[standard_parallel_2,51.16666666666666],PARAMETER[latitude_of_origin,90],PARAMETER[central_meridian,4.356939722222222],PARAMETER[false_easting,150000.01256],PARAMETER[false_northing,5400088.4378],UNIT[Meter,1]]";
    }
}