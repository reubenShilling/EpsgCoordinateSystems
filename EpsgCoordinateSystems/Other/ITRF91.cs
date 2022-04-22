namespace EpsgCoordinateSystems.Other
{
    public class ITRF91 : IEpsgCoordinateSystem
    {
        public string Name => "ITRF91";
        public string Units => "Unspecified";
public long Srid => 4913;

        public string OgcWkt =>
            "GEOCCS[ITRF91,DATUM[International Terrestrial Reference Frame 1991,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6650]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[m,1.0],AXIS[Geocentric X,OTHER],AXIS[Geocentric Y,EAST],AXIS[Geocentric Z,NORTH],AUTHORITY[EPSG,4913]]";

        public string EsriWkt => "GEOCCS[ITRF91,DATUM[D_International Terrestrial Reference Frame 1991,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[m,1.0]]";
    }
}