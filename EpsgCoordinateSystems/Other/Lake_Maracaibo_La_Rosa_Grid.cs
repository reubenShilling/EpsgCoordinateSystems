namespace EpsgCoordinateSystems.Other
{
    public class Lake_Maracaibo_La_Rosa_Grid : IEpsgCoordinateSystem
    {
        public string Name => "Lake / Maracaibo La Rosa Grid";
        public string Units => "Unspecified";
public long Srid => 2104;

        public string OgcWkt =>
            "PROJCS[Lake / Maracaibo La Rosa Grid,GEOGCS[Lake,DATUM[Lake,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6249]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4249]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,10.16666666666667],PARAMETER[central_meridian,-71.60561777777777],PARAMETER[scale_factor,1],PARAMETER[false_easting,-17044],PARAMETER[false_northing,-23139.97],AUTHORITY[EPSG,2104],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Lake / Maracaibo La Rosa Grid,GEOGCS[Lake,DATUM[D_Lake,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,10.16666666666667],PARAMETER[central_meridian,-71.60561777777777],PARAMETER[scale_factor,1],PARAMETER[false_easting,-17044],PARAMETER[false_northing,-23139.97],UNIT[Meter,1]]";
    }
}