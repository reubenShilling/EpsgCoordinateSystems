using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Fatu_Iva_72 : IEpsgCoordinateSystem
    {private const int _srid = 4688; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Fatu Iva 72";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Fatu Iva 72,DATUM[Fatu_Iva_72,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[347.103,1078.12,2623.92,-33.8875,70.6773,-9.3943,186.074],AUTHORITY[EPSG,6688]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4688]]";

        public string EsriWkt => "GEOGCS[Fatu Iva 72,DATUM[D_Fatu_Iva_1972,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}