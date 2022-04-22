using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Le_Pouce_1934_Mauritius_Grid : IEpsgCoordinateSystem
    {private const int _srid = 3337; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Le Pouce 1934 / Mauritius Grid";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Le Pouce 1934 / Mauritius Grid,GEOGCS[Le Pouce 1934,DATUM[Le_Pouce_1934,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-770.1,158.4,-498.2,0,0,0,0],AUTHORITY[EPSG,6699]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4699]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,-20.19506944444445],PARAMETER[central_meridian,57.52182777777778],PARAMETER[scale_factor,1],PARAMETER[false_easting,1000000],PARAMETER[false_northing,1000000],AUTHORITY[EPSG,3337],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Le Pouce 1934 / Mauritius Grid,GEOGCS[Le Pouce 1934,DATUM[D_,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,-20.19506944444445],PARAMETER[central_meridian,57.52182777777778],PARAMETER[scale_factor,1],PARAMETER[false_easting,1000000],PARAMETER[false_northing,1000000],UNIT[Meter,1]]";
    }
}