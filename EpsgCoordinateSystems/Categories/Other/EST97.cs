namespace EpsgCoordinateSystems.Categories.Other
{
    public class EST97 : IEpsgCoordinateSystem
    {
        public string Name => "EST97";
        public string Units => "Unspecified";
public int Srid => 4935;

        public string OgcWkt =>
            "GEOGCS[EST97,DATUM[Estonia 1997,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.0,0.0,0.0,0.0,0.0,0.0,0.0],AUTHORITY[EPSG,6180]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4935]]";

        public string EsriWkt => "GEOGCS[EST97,DATUM[D_Estonia 1997,SPHEROID[GRS_1980,6378137.0,298.257222101]],PRIMEM[Greenwich,0.0],UNIT[Degree,0.017453292519943295]]";
    }
}