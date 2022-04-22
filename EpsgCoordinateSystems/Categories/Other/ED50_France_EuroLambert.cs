using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class ED50_France_EuroLambert : IEpsgCoordinateSystem
    {private const int _srid = 2192; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "ED50 / France EuroLambert";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[ED50 / France EuroLambert,GEOGCS[ED50,DATUM[European_Datum_1950,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],AUTHORITY[EPSG,6230]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4230]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,46.8],PARAMETER[central_meridian,2.337229166666667],PARAMETER[scale_factor,0.99987742],PARAMETER[false_easting,600000],PARAMETER[false_northing,2200000],AUTHORITY[EPSG,2192],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[ED50 / France EuroLambert,GEOGCS[ED50,DATUM[D_European_1950,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,46.8],PARAMETER[central_meridian,2.337229166666667],PARAMETER[scale_factor,0.99987742],PARAMETER[false_easting,600000],PARAMETER[false_northing,2200000],UNIT[Meter,1]]";
    }
}