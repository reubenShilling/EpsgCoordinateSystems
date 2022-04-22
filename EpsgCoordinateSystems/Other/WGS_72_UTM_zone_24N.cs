namespace EpsgCoordinateSystems.Other
{
    public class WGS_72_UTM_zone_24N : IEpsgCoordinateSystem
    {
        public string Name => "WGS 72 / UTM zone 24N";
        public string Units => "Unspecified";
public long Srid => 32224;

        public string OgcWkt =>
            "PROJCS[WGS 72 / UTM zone 24N,GEOGCS[WGS 72,DATUM[WGS_1972,SPHEROID[WGS 72,6378135,298.26,AUTHORITY[EPSG,7043]],AUTHORITY[EPSG,6322]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4322]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-39],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,32224],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[WGS 72 / UTM zone 24N,GEOGCS[WGS 72,DATUM[D_WGS_1972,SPHEROID[WGS_1972,6378135,298.26]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,-39],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}