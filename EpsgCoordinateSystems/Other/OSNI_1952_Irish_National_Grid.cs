namespace EpsgCoordinateSystems.Other
{
    public class OSNI_1952_Irish_National_Grid : IEpsgCoordinateSystem
    {
        public string Name => "OSNI 1952 / Irish National Grid";
        public string Units => "Unspecified";
public long Srid => 29901;

        public string OgcWkt =>
            "PROJCS[OSNI 1952 / Irish National Grid,GEOGCS[OSNI 1952,DATUM[OSNI_1952,SPHEROID[Airy 1830,6377563.396,299.3249646,AUTHORITY[EPSG,7001]],TOWGS84[482.5,-130.6,564.6,-1.042,-0.214,-0.631,8.15],AUTHORITY[EPSG,6188]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4188]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,53.5],PARAMETER[central_meridian,-8],PARAMETER[scale_factor,1],PARAMETER[false_easting,200000],PARAMETER[false_northing,250000],AUTHORITY[EPSG,29901],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[OSNI 1952 / Irish National Grid,GEOGCS[OSNI 1952,DATUM[D_OSNI_1952,SPHEROID[Airy_1830,6377563.396,299.3249646]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,53.5],PARAMETER[central_meridian,-8],PARAMETER[scale_factor,1],PARAMETER[false_easting,200000],PARAMETER[false_northing,250000],UNIT[Meter,1]]";
    }
}