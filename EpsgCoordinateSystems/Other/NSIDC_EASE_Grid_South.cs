namespace EpsgCoordinateSystems.Other
{
    public class NSIDC_EASE_Grid_South : IEpsgCoordinateSystem
    {
        public string Name => "NSIDC EASE-Grid South";
        public long Srid => 3409;

        public string OgcWkt =>
            "PROJCS[NSIDC EASE-Grid South,GEOGCS[Unspecified datum based upon the International 1924 Authalic Sphere,DATUM[Not_specified_based_on_International_1924_Authalic_Sphere,SPHEROID[International 1924 Authalic Sphere,6371228,0,AUTHORITY[EPSG,7057]],AUTHORITY[EPSG,6053]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4053]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Azimuthal_Equal_Area],PARAMETER[latitude_of_center,-90],PARAMETER[longitude_of_center,0],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3409],AXIS[X,UNKNOWN],AXIS[Y,UNKNOWN]]";

        public string EsriWkt =>
            "PROJCS[NSIDC EASE-Grid South,GEOGCS[Unspecified datum based upon the International 1924 Authalic Sphere,DATUM[Not_specified_based_on_International_1924_Authalic_Sphere,SPHEROID[International 1924 Authalic Sphere,6371228,0,AUTHORITY[EPSG,7057]],AUTHORITY[EPSG,6053]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4053]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Azimuthal_Equal_Area],PARAMETER[latitude_of_center,-90],PARAMETER[longitude_of_center,0],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,3409],AXIS[X,UNKNOWN],AXIS[Y,UNKNOWN]]";
    }
}