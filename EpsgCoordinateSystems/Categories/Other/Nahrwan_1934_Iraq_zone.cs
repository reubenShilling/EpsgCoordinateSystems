using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Nahrwan_1934_Iraq_zone : IEpsgCoordinateSystem
    {private const int _srid = 3394; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Nahrwan 1934 / Iraq zone";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[Nahrwan 1934 / Iraq zone,GEOGCS[Nahrwan 1934,DATUM[Nahrwan_1934,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6744]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4744]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,32.5],PARAMETER[central_meridian,45],PARAMETER[scale_factor,0.9987864078],PARAMETER[false_easting,1500000],PARAMETER[false_northing,1166200],AUTHORITY[EPSG,3394],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Nahrwan 1934 / Iraq zone,GEOGCS[Nahrwan 1934,DATUM[D_,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,32.5],PARAMETER[central_meridian,45],PARAMETER[scale_factor,0.9987864078],PARAMETER[false_easting,1500000],PARAMETER[false_northing,1166200],UNIT[Meter,1]]";
    }
}