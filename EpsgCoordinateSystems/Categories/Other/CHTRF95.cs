namespace EpsgCoordinateSystems.Categories.Other
{
    public class CHTRF95 : IEpsgCoordinateSystem
    {
        public string Name => "CHTRF95";
        public string Units => "Unspecified";
public int Srid => 4933;

        public string OgcWkt =>
            "GEOGCS[CHTRF95,DATUM[Swiss Terrestrial Reference Frame 1995,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6151]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4933]]";

        public string EsriWkt => "GEOGCS[CHTRF95,DATUM[D_Swiss Terrestrial Reference Frame 1995,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}