namespace EpsgCoordinateSystems.Other
{
    public class ITRF88 : IEpsgCoordinateSystem
    {
        public string Name => "ITRF88";
        public string Units => "Unspecified";
public long Srid => 4910;

        public string OgcWkt =>
            "GEOCCS[ITRF88,DATUM[International Terrestrial Reference Frame 1988,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6647]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4910]]";

        public string EsriWkt =>
            "GEOCCS[ITRF88,DATUM[International Terrestrial Reference Frame 1988,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6647]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4910]]";
    }
}