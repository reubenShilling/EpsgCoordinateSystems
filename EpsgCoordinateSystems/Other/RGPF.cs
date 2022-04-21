namespace EpsgCoordinateSystems.Other
{
    public class RGPF : IEpsgCoordinateSystem
    {
        public string Name => "RGPF";
        public long Srid => 4999;

        public string OgcWkt =>
            "GEOGCS[RGPF,DATUM[Reseau Geodesique de la Polynesie Francaise,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.072,-0.507,-0.245,-0.0183,-0.0003,0.007,-0.001918262698097996],AUTHORITY[EPSG,6687]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4999]]";

        public string EsriWkt =>
            "GEOGCS[RGPF,DATUM[Reseau Geodesique de la Polynesie Francaise,SPHEROID[GRS 1980,6378137.0,298.257222101,AUTHORITY[EPSG,7019]],TOWGS84[0.072,-0.507,-0.245,-0.0183,-0.0003,0.007,-0.001918262698097996],AUTHORITY[EPSG,6687]],PRIMEM[Greenwich,0.0,AUTHORITY[EPSG,8901]],UNIT[degree,0.017453292519943295],AXIS[Geodetic latitude,NORTH],AXIS[Geodetic longitude,EAST],AXIS[Ellipsoidal height,UP],AUTHORITY[EPSG,4999]]";
    }
}