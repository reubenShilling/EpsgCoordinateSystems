namespace EpsgCoordinateSystems.Categories.Other
{
    public class Belge_1950_Brussels_Belge_Lambert_50 : IEpsgCoordinateSystem
    {
        public string Name => "Belge 1950 (Brussels) / Belge Lambert 50";
        public string Units => "Unspecified";
public int Srid => 21500;

        public string OgcWkt =>
            "PROJCS[Belge 1950 (Brussels) / Belge Lambert 50,GEOGCS[Belge 1950 (Brussels),DATUM[Reseau_National_Belge_1950_Brussels,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6809]],PRIMEM[Brussels,4.367975,AUTHORITY[EPSG,8910]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4809]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,49.83333333333334],PARAMETER[standard_parallel_2,51.16666666666666],PARAMETER[latitude_of_origin,90],PARAMETER[central_meridian,0],PARAMETER[false_easting,150000],PARAMETER[false_northing,5400000],AUTHORITY[EPSG,21500],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Belge 1950 (Brussels) / Belge Lambert 50,GEOGCS[Belge 1950 (Brussels),DATUM[D_Belge_1950,SPHEROID[International_1924,6378388,297]],PRIMEM[Brussels,4.367975],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,49.83333333333334],PARAMETER[standard_parallel_2,51.16666666666666],PARAMETER[latitude_of_origin,90],PARAMETER[central_meridian,0],PARAMETER[false_easting,150000],PARAMETER[false_northing,5400000],UNIT[Meter,1]]";
    }
}