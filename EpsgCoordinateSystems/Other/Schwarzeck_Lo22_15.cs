namespace EpsgCoordinateSystems.Other
{
    public class Schwarzeck_Lo22_15 : IEpsgCoordinateSystem
    {
        public string Name => "Schwarzeck / Lo22/15";
        public string Units => "Unspecified";
public long Srid => 29375;

        public string OgcWkt =>
            "PROJCS[Schwarzeck / Lo22/15,GEOGCS[Schwarzeck,DATUM[Schwarzeck,SPHEROID[Bessel Namibia (GLM),6377483.865280419,299.1528128,AUTHORITY[EPSG,7046]],AUTHORITY[EPSG,6293]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4293]],UNIT[German legal metre,1.0000135965,AUTHORITY[EPSG,9031]],PROJECTION[Transverse_Mercator_South_Orientated],PARAMETER[latitude_of_origin,-22],PARAMETER[central_meridian,15],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,29375],AXIS[Y,WEST],AXIS[X,SOUTH]]";

        public string EsriWkt =>
            "PROJCS[Schwarzeck / Lo22/15,GEOGCS[Schwarzeck,DATUM[Schwarzeck,SPHEROID[Bessel Namibia (GLM),6377483.865280419,299.1528128,AUTHORITY[EPSG,7046]],AUTHORITY[EPSG,6293]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4293]],UNIT[German legal metre,1.0000135965,AUTHORITY[EPSG,9031]],PROJECTION[Transverse_Mercator_South_Orientated],PARAMETER[latitude_of_origin,-22],PARAMETER[central_meridian,15],PARAMETER[scale_factor,1],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,29375],AXIS[Y,WEST],AXIS[X,SOUTH]]";
    }
}