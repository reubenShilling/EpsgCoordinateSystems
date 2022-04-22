namespace EpsgCoordinateSystems.Other
{
    public class Moznet_UTM_zone_37S : IEpsgCoordinateSystem
    {
        public string Name => "Moznet / UTM zone 37S";
        public string Units => "Unspecified";
public long Srid => 3037;

        public string OgcWkt =>
            "PROJCS[Moznet / UTM zone 37S,GEOGCS[Moznet,DATUM[Moznet_ITRF94,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,-0,-0,-0,0],AUTHORITY[EPSG,6130]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4130]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,39],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,3037],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Moznet / UTM zone 37S,GEOGCS[Moznet,DATUM[D_Moznet,SPHEROID[WGS_1984,6378137,298.257223563]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,39],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}