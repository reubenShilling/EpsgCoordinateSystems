namespace EpsgCoordinateSystems.Other
{
    public class Korea_2000 : IEpsgCoordinateSystem
    {
        public string Name => "Korea 2000";
        public string Units => "Unspecified";
public long Srid => 4927;

        public string OgcWkt =>
            "GEOGCS[Korea 2000,DATUM[Geocentric datum of Korea,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6737]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4927]]";

        public string EsriWkt => "GEOGCS[Korea 2000,DATUM[D_Geocentric datum of Korea,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}