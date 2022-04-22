namespace EpsgCoordinateSystems.Other
{
    public class ETRS89_Belgian_Lambert_2008 : IEpsgCoordinateSystem
    {
        public string Name => "ETRS89 / Belgian Lambert 2008";
        public string Units => "Unspecified";
public long Srid => 3812;

        public string OgcWkt =>
            "PROJCS[ETRS89 / Belgian Lambert 2008,GEOGCS[ETRS89,DATUM[European Terrestrial Reference System 1989,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6258]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4258]],PROJECTION[Lambert Conic Conformal (2SP),AUTHORITY[EPSG,9802]],PARAMETER[central_meridian,4.359215833333335],PARAMETER[latitude_of_origin,50.79781500000001],PARAMETER[standard_parallel_1,49.833333333333336],PARAMETER[false_easting,649328.0],PARAMETER[false_northing,665262.0],PARAMETER[standard_parallel_2,51.16666666666667],UNIT[m,1.0],AXIS[Easting,EAST],AXIS[Northing,NORTH],AUTHORITY[EPSG,3812]]";

        public string EsriWkt => "PROJCS[ETRS89 / Belgian Lambert 2008,GEOGCS[ETRS89,DATUM[D_European Terrestrial Reference System 1989,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert Conic Conformal (2SP)],PARAMETER[central_meridian,4.359215833333335],PARAMETER[latitude_of_origin,50.79781500000001],PARAMETER[standard_parallel_1,49.833333333333336],PARAMETER[false_easting,649328.0],PARAMETER[false_northing,665262.0],PARAMETER[standard_parallel_2,51.16666666666667],UNIT[m,1.0]]";
    }
}