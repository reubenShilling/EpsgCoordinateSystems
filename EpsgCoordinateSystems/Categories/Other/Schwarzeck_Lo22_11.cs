using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Schwarzeck_Lo22_11 : IEpsgCoordinateSystem
    {private const int _srid = 29371; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Schwarzeck / Lo22/11";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Schwarzeck / Lo22/11,GEOGCS[Schwarzeck,DATUM[Schwarzeck,SPHEROID[Bessel Namibia (GLM),6377483.865280419,299.1528128,AUTHORITY[EPSG,7046]],AUTHORITY[EPSG,6293]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4293]],UNIT[German legal metre,1.0000135965,AUTHORITY[EPSG,9031]],PROJECTION[Transverse_Mercator_South_Orientated],PARAMETER[latitude_of_origin,-22],PARAMETER[central_meridian,11],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,29371],AXIS[Y,WEST],AXIS[X,SOUTH]]";

        public string EsriWkt => "PROJCS[Schwarzeck / Lo22/11,GEOGCS[Schwarzeck,DATUM[D_Schwarzeck,SPHEROID[Bessel_Namibia_GLM,6377483.865280419,299.1528128]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator_South_Orientated],PARAMETER[latitude_of_origin,-22],PARAMETER[central_meridian,11],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],UNIT[German legal metre,1.0000135965]]";
    }
}