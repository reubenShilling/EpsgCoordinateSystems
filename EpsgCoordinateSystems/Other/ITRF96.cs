namespace EpsgCoordinateSystems.Other
{
    public class ITRF96 : IEpsgCoordinateSystem
    {
        public string Name => "ITRF96";
        public long Srid => 4917;

        public string OgcWkt =>
            "GEOCCS[ITRF96,DATUM[International Terrestrial Reference Frame 1996,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6654]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4917]]";

        public string EsriWkt =>
            "GEOCCS[ITRF96,DATUM[International Terrestrial Reference Frame 1996,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6654]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4917]]";
    }
}