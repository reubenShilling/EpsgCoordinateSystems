namespace EpsgCoordinateSystems.Other
{
    public class Kousseri_UTM_zone_33N : IEpsgCoordinateSystem
    {
        public string Name => "Kousseri / UTM zone 33N";
        public string Units => "Unspecified";
public long Srid => 2313;

        public string OgcWkt =>
            "PROJCS[Kousseri / UTM zone 33N,GEOGCS[Kousseri,DATUM[Kousseri,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],AUTHORITY[EPSG,6198]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4198]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],AUTHORITY[EPSG,2313],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[Kousseri / UTM zone 33N,GEOGCS[Kousseri,DATUM[D_Kousseri,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,15],PARAMETER[scale_factor,0.9996],PARAMETER[false_easting,500000],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}