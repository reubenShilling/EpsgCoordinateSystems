namespace EpsgCoordinateSystems.Other
{
    public class Lake_Maracaibo_Grid_M3 : IEpsgCoordinateSystem
    {
        public string Name => "Lake / Maracaibo Grid M3";
        public string Units => "Unspecified";
public long Srid => 2103;

        public string OgcWkt =>
            "PROJCS[Lake / Maracaibo Grid M3,GEOGCS[Lake,DATUM[Lake,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6249]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4249]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,10.16666666666667],PARAMETER[central_meridian,-71.60561777777777],PARAMETER[scale_factor,1],PARAMETER[false_easting,500000],PARAMETER[false_northing,447315.028],AUTHORITY[EPSG,2103],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Lake / Maracaibo Grid M3,GEOGCS[Lake,DATUM[D_Lake,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,10.16666666666667],PARAMETER[central_meridian,-71.60561777777777],PARAMETER[scale_factor,1],PARAMETER[false_easting,500000],PARAMETER[false_northing,447315.028],UNIT[Meter,1]]";
    }
}