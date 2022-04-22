using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class ATS77_MTM_Nova_Scotia_zone_4 : IEpsgCoordinateSystem
    {private const int _srid = 2294; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "ATS77 / MTM Nova Scotia zone 4";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[ATS77 / MTM Nova Scotia zone 4,GEOGCS[ATS77,DATUM[Average_Terrestrial_System_1977,SPHEROID[Average Terrestrial System 1977,6378135,298.257,AUTHORITY[EPSG,7041]],AUTHORITY[EPSG,6122]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4122]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-61.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,4500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2294],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[ATS77 / MTM Nova Scotia zone 4,GEOGCS[ATS77,DATUM[D_ATS_1977,SPHEROID[Average_Terrestrial_System_1977,6378135,298.257]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-61.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,4500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}