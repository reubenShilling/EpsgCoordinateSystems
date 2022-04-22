namespace EpsgCoordinateSystems.Other
{
    public class South_Yemen : IEpsgCoordinateSystem
    {
        public string Name => "South Yemen";
        public string Units => "Unspecified";
public long Srid => 4164;

        public string OgcWkt =>
            "GEOGCS[South Yemen,DATUM[South_Yemen,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[-76,-138,67,0,0,0,0],AUTHORITY[EPSG,6164]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4164]]";

        public string EsriWkt =>
            "GEOGCS[South Yemen,DATUM[South_Yemen,SPHEROID[Krassowsky 1940,6378245,298.3,AUTHORITY[EPSG,7024]],TOWGS84[-76,-138,67,0,0,0,0],AUTHORITY[EPSG,6164]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4164]]";
    }
}