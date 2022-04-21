namespace EpsgCoordinateSystems.Other
{
    public class Merchich_Sahara_Sud : IEpsgCoordinateSystem
    {
        public string Name => "Merchich / Sahara Sud";
        public long Srid => 26195;

        public string OgcWkt =>
            "PROJCS[Merchich / Sahara Sud,GEOGCS[Merchich,DATUM[Merchich,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[31,146,47,0,0,0,0],AUTHORITY[EPSG,6261]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4261]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,22.5],PARAMETER[central_meridian,-5.4],PARAMETER[scale_factor,0.999616437],PARAMETER[false_easting,1500000],PARAMETER[false_northing,400000],AUTHORITY[EPSG,26195],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[Merchich / Sahara Sud,GEOGCS[Merchich,DATUM[Merchich,SPHEROID[Clarke 1880 (IGN),6378249.2,293.4660212936269,AUTHORITY[EPSG,7011]],TOWGS84[31,146,47,0,0,0,0],AUTHORITY[EPSG,6261]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4261]],UNIT[metre,1,AUTHORITY[EPSG,9001]],PROJECTION[Lambert_Conformal_Conic_1SP],PARAMETER[latitude_of_origin,22.5],PARAMETER[central_meridian,-5.4],PARAMETER[scale_factor,0.999616437],PARAMETER[false_easting,1500000],PARAMETER[false_northing,400000],AUTHORITY[EPSG,26195],AXIS[X,EAST],AXIS[Y,NORTH]]";
    }
}