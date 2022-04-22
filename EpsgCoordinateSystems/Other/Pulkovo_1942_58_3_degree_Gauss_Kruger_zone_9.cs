namespace EpsgCoordinateSystems.Other
{
    public class Pulkovo_1942_58_3_degree_Gauss_Kruger_zone_9 : IEpsgCoordinateSystem
    {
        public string Name => "Pulkovo 1942(58) / 3-degree Gauss-Kruger zone 9";
        public string Units => "Unspecified";
public long Srid => 3839;

        public string OgcWkt =>
            "PROJCS[Pulkovo 1942(58) / 3-degree Gauss-Kruger zone 9,GEOGCS[Pulkovo 1942(58),DATUM[Pulkovo 1942(58),SPHEROID[Krassowsky 1940,6378245.0,298.3,AUTHORITY[EPSG,7024]],TOWGS84[33.4,-146.6,-76.3,-0.359,-0.053,0.844,-0.17326243724756094],AUTHORITY[EPSG,6179]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4179]],PROJECTION[Transverse Mercator,AUTHORITY[EPSG,9807]],PARAMETER[central_meridian,27.0],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,1.0],PARAMETER[false_easting,9500000.0],PARAMETER[false_northing,0.0],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,3839]]";

        public string EsriWkt => "PROJCS[Pulkovo 1942(58) / 3-degree Gauss-Kruger zone 9,GEOGCS[Pulkovo 1942(58),DATUM[D_Pulkovo 1942(58),SPHEROID[Krassowsky_1940,6378245.0,298.3]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse Mercator],PARAMETER[central_meridian,27.0],PARAMETER[latitude_of_origin,0.0],PARAMETER[scale_factor,1.0],PARAMETER[false_easting,9500000.0],PARAMETER[false_northing,0.0],UNIT[m,1.0]]";
    }
}