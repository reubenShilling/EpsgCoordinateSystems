namespace EpsgCoordinateSystems.Categories.Other
{
    public class DGN95_Indonesia_TM_3_zone_53_2 : IEpsgCoordinateSystem
    {
        public string Name => "DGN95 / Indonesia TM-3 zone 53.2";
        public string Units => "Unspecified";
public int Srid => 23844;

        public string OgcWkt =>
            "PROJCS[DGN95 / Indonesia TM-3 zone 53.2,GEOGCS[DGN95,DATUM[Datum_Geodesi_Nasional_1995,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],TOWGS84[0,0,0,0,0,0,0],AUTHORITY[EPSG,6755]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4755]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,136.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,200000],PARAMETER[false_northing,1500000],AUTHORITY[EPSG,23844],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[DGN95 / Indonesia TM-3 zone 53.2,GEOGCS[DGN95,DATUM[D_,SPHEROID[WGS_1984,6378137,298.257223563]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,136.5],PARAMETER[scale_factor,0.9999],PARAMETER[false_easting,200000],PARAMETER[false_northing,1500000],UNIT[Meter,1]]";
    }
}