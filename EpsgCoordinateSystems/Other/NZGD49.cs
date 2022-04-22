namespace EpsgCoordinateSystems.Other
{
    public class NZGD49 : IEpsgCoordinateSystem
    {
        public string Name => "NZGD49";
        public string Units => "Unspecified";
public long Srid => 4272;

        public string OgcWkt =>
            "GEOGCS[NZGD49,DATUM[New_Zealand_Geodetic_Datum_1949,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[59.47,-5.04,187.44,0.47,-0.1,1.024,-4.5993],AUTHORITY[EPSG,6272]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4272]]";

        public string EsriWkt => "GEOGCS[NZGD49,DATUM[D_New_Zealand_1949,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}