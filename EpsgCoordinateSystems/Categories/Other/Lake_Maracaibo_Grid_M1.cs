using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Lake_Maracaibo_Grid_M1 : IEpsgCoordinateSystem
    {private const int _srid = 2101; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Lake / Maracaibo Grid M1";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Lake / Maracaibo Grid M1,GEOGCS[Lake,DATUM[Lake,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6249]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4249]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,10.16666666666667],PARAMETER[central_meridian,-71.60561777777777],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,-52684.972],AUTHORITY[EPSG,2101],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Lake / Maracaibo Grid M1,GEOGCS[Lake,DATUM[D_Lake,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,10.16666666666667],PARAMETER[central_meridian,-71.60561777777777],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,-52684.972],UNIT[Meter,1]]";
    }
}