using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class QND95 : IEpsgCoordinateSystem
    {private const int _srid = 4614; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "QND95";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[QND95,DATUM[Qatar_National_Datum_1995,SPHEROID[International 1924,6378388,297,AUTHORITY[EPSG,7022]],TOWGS84[-119.425,-303.659,-11.0006,1.1643,0.174458,1.09626,3.65706],AUTHORITY[EPSG,6614]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4614]]";

        public string EsriWkt => "GEOGCS[QND95,DATUM[D_QND_1995,SPHEROID[International_1924,6378388,297]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}