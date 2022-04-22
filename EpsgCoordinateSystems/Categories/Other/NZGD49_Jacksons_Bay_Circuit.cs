using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class NZGD49_Jacksons_Bay_Circuit : IEpsgCoordinateSystem
    {private const int _srid = 27223; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NZGD49 / Jacksons Bay Circuit";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NZGD49 / Jacksons Bay Circuit,GEOGCS[NZGD49,DATUM[New_Zealand_Geodetic_Datum_1949,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[59.47,-5.04,187.44,0.47,-0.1,1.024,-4.5993],AUTHORITY[EPSG,6272]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4272]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-43.97780288888889],PARAMETER[central_meridian,168.606267],PARAMETER[scale_factor,1],PARAMETER[false_easting,300000],PARAMETER[false_northing,700000],AUTHORITY[EPSG,27223],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[NZGD49 / Jacksons Bay Circuit,GEOGCS[NZGD49,DATUM[D_New_Zealand_1949,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,-43.97780288888889],PARAMETER[central_meridian,168.606267],PARAMETER[scale_factor,1],PARAMETER[false_easting,300000],PARAMETER[false_northing,700000],UNIT[Meter,1]]";
    }
}