namespace EpsgCoordinateSystems.Other
{
    public class ITRF2000 : IEpsgCoordinateSystem
    {
        public string Name => "ITRF2000";
        public long Srid => 4919;

        public string OgcWkt =>
            "GEOCCS[ITRF2000,DATUM[International Terrestrial Reference Frame 2000,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6656]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4919]]";

        public string EsriWkt =>
            "GEOCCS[ITRF2000,DATUM[International Terrestrial Reference Frame 2000,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6656]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4919]]";
    }
}