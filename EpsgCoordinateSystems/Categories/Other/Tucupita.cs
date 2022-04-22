using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Tucupita : IEpsgCoordinateSystem
    {private const int _srid = 5814; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Tucupita";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "LOCAL_CS[Tucupita,LOCAL_DATUM[Tucupita,0,AUTHORITY[EPSG,9308]],UNIT[m,1.0],AXIS[Northing,NORTH],AXIS[Easting,EAST],AUTHORITY[EPSG,5814]]";

        public string EsriWkt => "";
    }
}