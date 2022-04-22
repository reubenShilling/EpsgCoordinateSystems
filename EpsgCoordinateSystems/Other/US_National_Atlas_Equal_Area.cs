namespace EpsgCoordinateSystems.Other
{
    public class US_National_Atlas_Equal_Area : IEpsgCoordinateSystem
    {
        public string Name => "US National Atlas Equal Area";
        public string Units => "Unspecified";
public long Srid => 2163;

        public string OgcWkt =>
            "PROJCS[US National Atlas Equal Area,GEOGCS[Unspecified datum based upon the Clarke 1866 Authalic Sphere,DATUM[Not_specified_based_on_Clarke_1866_Authalic_Sphere,SPHEROID[Clarke 1866 Authalic Sphere,6370997,0,AUTHORITY[EPSG,7052]],AUTHORITY[EPSG,6052]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4052]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Azimuthal_Equal_Area],PARAMETER[latitude_of_center,45],PARAMETER[longitude_of_center,-100],PARAMETER[false_easting,0],PARAMETER[false_northing,0],AUTHORITY[EPSG,2163],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[US National Atlas Equal Area,GEOGCS[Unspecified datum based upon the Clarke 1866 Authalic Sphere,DATUM[D_Sphere_Clarke_1866_Authalic,SPHEROID[Clarke_1866_Authalic_Sphere,6370997,0]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Azimuthal_Equal_Area],PARAMETER[latitude_of_origin,45],PARAMETER[central_meridian,-100],PARAMETER[false_easting,0],PARAMETER[false_northing,0],UNIT[Meter,1]]";
    }
}