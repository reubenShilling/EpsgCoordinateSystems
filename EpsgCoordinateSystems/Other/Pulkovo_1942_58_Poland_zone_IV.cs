namespace EpsgCoordinateSystems.Other
{
    public class Pulkovo_1942_58_Poland_zone_IV : IEpsgCoordinateSystem
    {
        public string Name => "Pulkovo 1942(58) / Poland zone IV";
        public long Srid => 2174;

        public string OgcWkt =>
            "PROJCS[Pulkovo 1942(58) / Poland zone IV,GEOGCS[Pulkovo 1942(58),DATUM[Pulkovo_1942_58,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[33.4,-146.6,-76.3,-0.359,-0.053,0.844,-0.84],AUTHORITY[EPSG,6179]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4179]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Oblique_Stereographic],PARAMETER[latitude_of_origin,51.67083333333333],PARAMETER[central_meridian,16.67222222222222],PARAMETER[scale_factor,0.9998],PARAMETER[false_easting,3703000],PARAMETER[false_northing,5627000],AUTHORITY[EPSG,2174],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Pulkovo 1942(58) / Poland zone IV,GEOGCS[Pulkovo 1942(58),DATUM[Pulkovo_1942_58,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[33.4,-146.6,-76.3,-0.359,-0.053,0.844,-0.84],AUTHORITY[EPSG,6179]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4179]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Oblique_Stereographic],PARAMETER[latitude_of_origin,51.67083333333333],PARAMETER[central_meridian,16.67222222222222],PARAMETER[scale_factor,0.9998],PARAMETER[false_easting,3703000],PARAMETER[false_northing,5627000],AUTHORITY[EPSG,2174],AXIS[Y,EAST],AXIS[X,NORTH]]";
    }
}