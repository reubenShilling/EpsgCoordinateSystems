namespace EpsgCoordinateSystems.Categories.Other
{
    public class PSHD93 : IEpsgCoordinateSystem
    {
        public string Name => "PSHD93";
        public string Units => "Unspecified";
public int Srid => 7410;

        public string OgcWkt =>
            "COMPD_CS[PSHD93,GEOGCS[PDO Survey Datum 1993,DATUM[PDO Survey Datum 1993,SPHEROID[Clarke 1880 (RGS),6378249.145,293.465,AUTHORITY[EPSG,7012]],TOWGS84[-191.808,-250.512,167.861,-0.792,-1.653,8.558,4.270300283733636],AUTHORITY[EPSG,6134]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AUTHORITY[EPSG,4134]],VERT_CS[PDO Height Datum 1993,VERT_DATUM[PDO Height Datum 1993,2005,AUTHORITY[EPSG,5123]],UNIT[m,1.0],AXIS[Gravity-related height,UP],AUTHORITY[EPSG,5724]],AUTHORITY[EPSG,7410]]";

        public string EsriWkt => "COMPD_CS[PSHD93,GEOGCS[PDO Survey Datum 1993,DATUM[D_PDO Survey Datum 1993,SPHEROID[Clarke_1880_RGS,6378249.145,293.465]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]],VERT_CS[PDO Height Datum 1993,VERT_DATUM[PDO Height Datum 1993,2005],UNIT[m,1.0]]]";
    }
}