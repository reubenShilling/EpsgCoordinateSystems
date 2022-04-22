namespace EpsgCoordinateSystems.Other
{
    public class ITRF92 : IEpsgCoordinateSystem
    {
        public string Name => "ITRF92";
        public string Units => "Unspecified";
public long Srid => 4914;

        public string OgcWkt =>
            "GEOCCS[ITRF92,DATUM[International Terrestrial Reference Frame 1992,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6651]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4914]]";

        public string EsriWkt =>
            "GEOCCS[ITRF92,DATUM[International Terrestrial Reference Frame 1992,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6651]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4914]]";
    }
}