namespace EpsgCoordinateSystems.Categories.Other
{
    public class Arc_1960_UTM_zone_36S : IEpsgCoordinateSystem
    {
        public string Name => "Arc 1960 / UTM zone 36S";
        public string Units => "Unspecified";
public int Srid => 21036;

        public string OgcWkt =>
            "PROJCS[Arc 1960 / UTM zone 36S,GEOGCS[Arc 1960,DATUM[Arc_1960,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6210]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4210]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,33],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],AUTHORITY[EPSG,21036],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Arc 1960 / UTM zone 36S,GEOGCS[Arc 1960,DATUM[D_Arc_1960,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,33],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,10000000],UNIT[Meter,1]]";
    }
}