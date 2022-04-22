using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Mount_Dillon : IEpsgCoordinateSystem
    {private const int _srid = 4157; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Mount Dillon";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Mount Dillon,DATUM[Mount_Dillon,SPHEROID[Clarke 1858,6378293.645208759,294.2606763692654,AUTHORITY[EPSG,7007]],AUTHORITY[EPSG,6157]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4157]]";

        public string EsriWkt => "GEOGCS[Mount Dillon,DATUM[D_Mount_Dillon,SPHEROID[Clarke_1858,6378293.645208759,294.2606763692654]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}