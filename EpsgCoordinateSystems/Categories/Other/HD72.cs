using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class HD72 : IEpsgCoordinateSystem
    {private const int _srid = 4237; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "HD72";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[HD72,DATUM[Hungarian_Datum_1972,SPHEROID[GRS 1967,6378160,298.247167427,AUTHORITY[EPSG,7036]],AUTHORITY[EPSG,6237]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4237]]";

        public string EsriWkt => "GEOGCS[HD72,DATUM[D_Hungarian_1972,SPHEROID[GRS_1967,6378160,298.247167427]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}