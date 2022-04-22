using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class ITRF2005 : IEpsgCoordinateSystem
    {private const int _srid = 4896; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "ITRF2005";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "GEOCCS[ITRF2005,DATUM[International Terrestrial Reference Frame 2005,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6896]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4896]]";

        public string EsriWkt => "GEOCCS[ITRF2005,DATUM[D_International Terrestrial Reference Frame 2005,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[m,1.0]]";
    }
}