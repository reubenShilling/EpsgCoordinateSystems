namespace EpsgCoordinateSystems.Other
{
    public class Pulkovo_1942_58_GUGiK_80 : IEpsgCoordinateSystem
    {
        public string Name => "Pulkovo 1942(58) / GUGiK-80";
        public string Units => "Unspecified";
public long Srid => 3328;

        public string OgcWkt =>
            "PROJCS[Pulkovo 1942(58) / GUGiK-80,GEOGCS[Pulkovo 1942(58),DATUM[Pulkovo_1942_58,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[33.4,-146.6,-76.3,-0.359,-0.053,0.844,-0.84],AUTHORITY[EPSG,6179]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4179]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Oblique_Stereographic],PARAMETER[latitude_of_origin,52.16666666666666],PARAMETER[central_meridian,19.16666666666667],PARAMETER[scale_factor,0.999714],PARAMETER[false_easting,500000],PARAMETER[false_northing,500000],AUTHORITY[EPSG,3328],AXIS[Y,EAST],AXIS[X,NORTH]]";

        public string EsriWkt => "PROJCS[Pulkovo 1942(58) / GUGiK-80,GEOGCS[Pulkovo 1942(58),DATUM[D_Pulkovo_1942_Adj_1958,SPHEROID[Krassowsky_1940,6378245,298.3]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Stereographic_North_Pole],PARAMETER[standard_parallel_1,52.16666666666666],PARAMETER[central_meridian,19.16666666666667],PARAMETER[scale_factor,0.999714],PARAMETER[false_easting,500000],PARAMETER[false_northing,500000],UNIT[Meter,1]]";
    }
}