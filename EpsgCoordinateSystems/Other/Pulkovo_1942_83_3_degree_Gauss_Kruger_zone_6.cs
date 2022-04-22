namespace EpsgCoordinateSystems.Other
{
    public class Pulkovo_1942_83_3_degree_Gauss_Kruger_zone_6 : IEpsgCoordinateSystem
    {
        public string Name => "Pulkovo 1942(83) / 3-degree Gauss-Kruger zone 6";
        public string Units => "Unspecified";
public long Srid => 3841;

        public string OgcWkt =>
            "PROJCS[Pulkovo 1942(83) / 3-degree Gauss-Kruger zone 6,GEOGCS[Pulkovo 1942(83),DATUM[Pulkovo 1942(83),SPHEROID[Krassowsky 1940,6378245.0,298.3,AUTHORITY[EPSG,7024]],TOWGS84[24.0,-123.0,-94.0,0.02,0.25,0.13,0.226891286871806],AUTHORITY[EPSG,6178]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4178]],PROJECTION[Transverse Mercator,AUTHORITY[EPSG,9807]],PARAMETER[central_meridian,18.0],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,1.0],PARAMETER[false_easting,6500000.0],PARAMETER[false_northing,0.0],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,3841]]";

        public string EsriWkt =>
            "PROJCS[Pulkovo 1942(83) / 3-degree Gauss-Kruger zone 6,GEOGCS[Pulkovo 1942(83),DATUM[Pulkovo 1942(83),SPHEROID[Krassowsky 1940,6378245.0,298.3,AUTHORITY[EPSG,7024]],TOWGS84[24.0,-123.0,-94.0,0.02,0.25,0.13,0.226891286871806],AUTHORITY[EPSG,6178]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4178]],PROJECTION[Transverse Mercator,AUTHORITY[EPSG,9807]],PARAMETER[central_meridian,18.0],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,1.0],PARAMETER[false_easting,6500000.0],PARAMETER[false_northing,0.0],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,3841]]";
    }
}