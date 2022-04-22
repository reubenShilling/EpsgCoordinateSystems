using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class WGS_72BE_South_China_Sea_Lambert : IEpsgCoordinateSystem
    {private const int _srid = 3415; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "WGS 72BE / South China Sea Lambert";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[WGS 72BE / South China Sea Lambert,GEOGCS[WGS 72BE,DATUM[WGS_1972_Transit_Broadcast_Ephemeris,SPHEROID[WGS 72,6378135,298.26,AUTHORITY[EPSG,7043]],TOWGS84[0,0,1.9,0,0,0.814,-0.38],AUTHORITY[EPSG,6324]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4324]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,18],PARAMETER[standard_parallel_2,24],PARAMETER[latitude_of_origin,21],PARAMETER[central_meridian,114],PARAMETER[false_easting,500000],PARAMETER[false_northing,500000],AUTHORITY[EPSG,3415],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[WGS 72BE / South China Sea Lambert,GEOGCS[WGS 72BE,DATUM[D_WGS_1972_BE,SPHEROID[WGS_1972,6378135,298.26]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,18],PARAMETER[standard_parallel_2,24],PARAMETER[latitude_of_origin,21],PARAMETER[central_meridian,114],PARAMETER[false_easting,500000],PARAMETER[false_northing,500000],UNIT[Meter,1]]";
    }
}