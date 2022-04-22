using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class ITRF96 : IEpsgCoordinateSystem
    {private const int _srid = 4917; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "ITRF96";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOCCS[ITRF96,DATUM[International Terrestrial Reference Frame 1996,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6654]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4917]]";

        public string EsriWkt => "GEOCCS[ITRF96,DATUM[D_International Terrestrial Reference Frame 1996,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[m,1.0]]";
    }
}