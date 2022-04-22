namespace EpsgCoordinateSystems.Categories.Other
{
    public class Merchich_Nord_Maroc : IEpsgCoordinateSystem
    {
        public string Name => "Merchich / Nord Maroc";
        public string Units => "Unspecified";
public int Srid => 26191;

        public string OgcWkt =>
            "PROJCS[Merchich / Nord Maroc,GEOGCS[Merchich,DATUM[Merchich,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[31,146,47,0,0,0,0],AUTHORITY[EPSG,6261]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4261]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,33.3],PARAMETER[central_meridian,-5.4],PARAMETER[scale_factor,0.999625769],PARAMETER[false_easting,500000],PARAMETER[false_northing,300000],AUTHORITY[EPSG,26191],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt => "PROJCS[Merchich / Nord Maroc,GEOGCS[Merchich,DATUM[D_Merchich,SPHEROID[Clarke_1880_IGN,6378249.2,293.4660212936269]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[latitude_of_origin,33.3],PARAMETER[central_meridian,-5.4],PARAMETER[scale_factor,0.999625769],PARAMETER[false_easting,500000],PARAMETER[false_northing,300000],UNIT[Meter,1]]";
    }
}