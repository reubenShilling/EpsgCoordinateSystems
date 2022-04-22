using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Trinidad_1903 : IEpsgCoordinateSystem
    {private const int _srid = 4302; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Trinidad 1903";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Trinidad 1903,DATUM[Trinidad_1903,SPHEROID[Clarke 1858,6378293.645208759,294.2606763692654,AUTHORITY[EPSG,7007]],AUTHORITY[EPSG,6302]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4302]]";

        public string EsriWkt => "GEOGCS[Trinidad 1903,DATUM[D_Trinidad_1903,SPHEROID[Clarke_1858,6378293.645208759,294.2606763692654]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}