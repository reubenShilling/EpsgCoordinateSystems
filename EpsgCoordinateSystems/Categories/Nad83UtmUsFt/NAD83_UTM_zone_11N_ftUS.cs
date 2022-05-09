using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories.Nad83UtmUsFt
{
    public class NAD83_UTM_zone_11N_ftUS : IEpsgCoordinateSystem
    {
        private const int _srid = -1;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "NAD83 / UTM zone 11N (US foot)";
        public string Units => "US foot";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[UTM83-11F,GEOGCS[LL83,DATUM[NAD83,SPHEROID[GRS1980,6378137.000,298.25722210],TOWGS84[0.0000,0.0000,0.0000,0.000000,0.000000,0.000000,0.00000000]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[false_easting,1640416.667],PARAMETER[false_northing,0.000],PARAMETER[central_meridian,-117.00000000000000],PARAMETER[scale_factor,0.9996],PARAMETER[latitude_of_origin,0.000],UNIT[Foot_US,0.30480060960122]]";

        public string EsriWkt => "PROJCS[UTM83-11F,GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137.000,298.25722210],TOWGS84[0.0000,0.0000,0.0000,0.000000,0.000000,0.000000,0.00000000]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[False_Easting,1640416.667],PARAMETER[False_Northing,0.000],PARAMETER[Central_Meridian,-117.00000000000000],PARAMETER[Scale_Factor,0.9996],PARAMETER[Latitude_Of_Origin,0.000],UNIT[Foot_US,0.30480060960122]]";
    }
}