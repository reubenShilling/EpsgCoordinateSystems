namespace EpsgCoordinateSystems.Categories.Other
{
    public class Pulkovo_1942_58_Poland_zone_V : IEpsgCoordinateSystem
    {
        public string Name => "Pulkovo 1942(58) / Poland zone V";
        public string Units => "Unspecified";
public int Srid => 2175;

        public string OgcWkt =>
            "PROJCS[Pulkovo 1942(58) / Poland zone V,GEOGCS[Pulkovo 1942(58),DATUM[Pulkovo_1942_58,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[33.4,-146.6,-76.3,-0.359,-0.053,0.844,-0.84],AUTHORITY[EPSG,6179]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4179]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,18.95833333333333],PARAMETER[scale_factor,0.999983],PARAMETER[false_easting,237000],PARAMETER[false_northing,-4700000],AUTHORITY[EPSG,2175],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[Pulkovo 1942(58) / Poland zone V,GEOGCS[Pulkovo 1942(58),DATUM[D_Pulkovo_1942_Adj_1958,SPHEROID[Krassowsky_1940,6378245,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,0],PARAMETER[central_meridian,18.95833333333333],PARAMETER[scale_factor,0.999983],PARAMETER[false_easting,237000],PARAMETER[false_northing,-4700000],UNIT[Meter,1]]";
    }
}