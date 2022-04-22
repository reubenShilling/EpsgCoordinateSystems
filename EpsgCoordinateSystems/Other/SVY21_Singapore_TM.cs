namespace EpsgCoordinateSystems.Other
{
    public class SVY21_Singapore_TM : IEpsgCoordinateSystem
    {
        public string Name => "SVY21 / Singapore TM";
        public string Units => "Unspecified";
public long Srid => 3414;

        public string OgcWkt =>
            "PROJCS[SVY21 / Singapore TM,GEOGCS[SVY21,DATUM[SVY21,SPHEROID[WGS 84,6378137,298.257223563,AUTHORITY[EPSG,7030]],AUTHORITY[EPSG,6757]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4757]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,1.366666666666667],PARAMETER[central_meridian,103.8333333333333],PARAMETER[scale_factor,1],PARAMETER[false_easting,28001.642],PARAMETER[false_northing,38744.572],AUTHORITY[EPSG,3414],AXIS[Easting,EAST],AXIS[Northing,NORTH]]";

        public string EsriWkt => "PROJCS[SVY21 / Singapore TM,GEOGCS[SVY21,DATUM[D_,SPHEROID[WGS_1984,6378137,298.257223563]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,1.366666666666667],PARAMETER[central_meridian,103.8333333333333],PARAMETER[scale_factor,1],PARAMETER[false_easting,28001.642],PARAMETER[false_northing,38744.572],UNIT[Meter,1]]";
    }
}