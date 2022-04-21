namespace EpsgCoordinateSystems.Other
{
    public class ITRF93 : IEpsgCoordinateSystem
    {
        public string Name => "ITRF93";
        public long Srid => 4915;

        public string OgcWkt =>
            "GEOCCS[ITRF93,DATUM[International Terrestrial Reference Frame 1993,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6652]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4915]]";

        public string EsriWkt =>
            "GEOCCS[ITRF93,DATUM[International Terrestrial Reference Frame 1993,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6652]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4915]]";
    }
}