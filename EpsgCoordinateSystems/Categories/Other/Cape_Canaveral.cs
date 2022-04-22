using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Cape_Canaveral : IEpsgCoordinateSystem
    {private const int _srid = 4717; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Cape Canaveral";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOGCS[Cape Canaveral,DATUM[Cape_Canaveral,SPHEROID[Clarke 1866,6378206.4,294.9786982138982,AUTHORITY[EPSG,7008]],TOWGS84[-2,151,181,0,0,0,0],AUTHORITY[EPSG,6717]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4717]]";

        public string EsriWkt => "GEOGCS[Cape Canaveral,DATUM[D_Cape_Canaveral,SPHEROID[Clarke_1866,6378206.4,294.9786982138982]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]]";
    }
}