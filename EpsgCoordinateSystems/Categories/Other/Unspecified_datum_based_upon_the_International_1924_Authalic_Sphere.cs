using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Unspecified_datum_based_upon_the_International_1924_Authalic_Sphere : IEpsgCoordinateSystem
    {private const int _srid = 4053; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Unspecified datum based upon the International 1924 Authalic Sphere";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Unspecified datum based upon the International 1924 Authalic Sphere,DATUM[Not_specified_based_on_International_1924_Authalic_Sphere,SPHEROID[International 1924 Authalic Sphere,6371228,0,AUTHORITY[EPSG,7057]],AUTHORITY[EPSG,6053]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4053]]";

        public string EsriWkt => "GEOGCS[Unspecified datum based upon the International 1924 Authalic Sphere,DATUM[D_,SPHEROID[International_1924_Authalic_Sphere,6371228,0]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}