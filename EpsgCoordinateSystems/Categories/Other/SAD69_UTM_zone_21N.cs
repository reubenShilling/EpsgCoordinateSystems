using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class SAD69_UTM_zone_21N : IEpsgCoordinateSystem
    {private const int _srid = 29171; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "SAD69 / UTM zone 21N";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[SAD69 / UTM zone 21N,GEOGCS[SAD69,DATUM[South_American_Datum_1969,SPHEROID[GRS 1967 (SAD69),6378160,298.25,AUTHORITY[EPSG,7050]],AUTHORITY[EPSG,6618]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4618]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-57],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,29171],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[SAD69 / UTM zone 21N,GEOGCS[SAD69,DATUM[D_South_American_1969,SPHEROID[GRS_1967_SAD69,6378160,298.25]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-57],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}