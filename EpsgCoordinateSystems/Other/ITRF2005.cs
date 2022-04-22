namespace EpsgCoordinateSystems.Other
{
    public class ITRF2005 : IEpsgCoordinateSystem
    {
        public string Name => "ITRF2005";
        public string Units => "Unspecified";
public long Srid => 4896;

        public string OgcWkt =>
            "GEOCCS[ITRF2005,DATUM[International Terrestrial Reference Frame 2005,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6896]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4896]]";

        public string EsriWkt =>
            "GEOCCS[ITRF2005,DATUM[International Terrestrial Reference Frame 2005,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6896]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4896]]";
    }
}