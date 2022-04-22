namespace EpsgCoordinateSystems.Other
{
    public class NAD83_HARN_Mississippi_TM : IEpsgCoordinateSystem
    {
        public string Name => "NAD83(HARN) / Mississippi TM";
        public string Units => "Unspecified";
public long Srid => 3815;

        public string OgcWkt =>
            "PROJCS[NAD83(HARN) / Mississippi TM,GEOGCS[NAD83(HARN),DATUM[NAD83 (High Accuracy Regional Network),SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6152]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4152]],PROJECTION[Transverse Mercator,AUTHORITY[EPSG,9807]],PARAMETER[central_meridian,-89.75],PARAMETER[latitude_of_origin,32.5],PARAMETER[scale_factor,0.9998335],PARAMETER[false_easting,500000.0],PARAMETER[false_northing,1300000.0],UNIT[m,1.0],AXIS[Easting,EAST],AXIS[Northing,NORTH],AUTHORITY[EPSG,3815]]";

        public string EsriWkt => "PROJCS[NAD83(HARN) / Mississippi TM,GEOGCS[NAD83(HARN),DATUM[D_NAD83 (High Accuracy Regional Network),SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse Mercator],PARAMETER[central_meridian,-89.75],PARAMETER[latitude_of_origin,32.5],PARAMETER[scale_factor,0.9998335],PARAMETER[false_easting,500000.0],PARAMETER[false_northing,1300000.0],UNIT[m,1.0]]";
    }
}