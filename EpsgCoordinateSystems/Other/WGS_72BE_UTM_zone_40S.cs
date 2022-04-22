namespace EpsgCoordinateSystems.Other
{
    public class WGS_72BE_UTM_zone_40S : IEpsgCoordinateSystem
    {
        public string Name => "WGS 72BE / UTM zone 40S";
        public string Units => "Unspecified";
public long Srid => 32540;

        public string OgcWkt =>
            "PROJCS[WGS 72BE / UTM zone 40S,GEOGCS[WGS 72BE,DATUM[WGS_1972_Transit_Broadcast_Ephemeris,SPHEROID[WGS 72,6378135,298.26,AUTHORITY[EPSG,7043]],TOWGS84[0,0,1.9,0,0,0.814,-0.38],AUTHORITY[EPSG,6324]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4324]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,57],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,32540],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[WGS 72BE / UTM zone 40S,GEOGCS[WGS 72BE,DATUM[D_WGS_1972_BE,SPHEROID[WGS_1972,6378135,298.26]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,57],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}