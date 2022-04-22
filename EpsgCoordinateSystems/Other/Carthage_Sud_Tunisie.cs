namespace EpsgCoordinateSystems.Other
{
    public class Carthage_Sud_Tunisie : IEpsgCoordinateSystem
    {
        public string Name => "Carthage / Sud Tunisie";
        public string Units => "Unspecified";
public long Srid => 22392;

        public string OgcWkt =>
            "PROJCS[Carthage / Sud Tunisie,GEOGCS[Carthage,DATUM[Carthage,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],AUTHORITY[EPSG,6223]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4223]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,33.3],PARAMETER[central_meridian,9.9],PARAMETER[scale_factor,0.999625769],PARAMETER[false_easting,500000],PARAMETER[false_northing,300000],AUTHORITY[EPSG,22392],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Carthage / Sud Tunisie,GEOGCS[Carthage,DATUM[D_Carthage,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,33.3],PARAMETER[central_meridian,9.9],PARAMETER[scale_factor,0.999625769],PARAMETER[false_easting,500000],PARAMETER[false_northing,300000],UNIT[Meter,1]]";
    }
}