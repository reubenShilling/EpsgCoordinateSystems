using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Astra_Minas_Grid : IEpsgCoordinateSystem
    {private const int _srid = 5800; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Astra Minas Grid";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "LOCAL_CS[Astra Minas Grid,LOCAL_DATUM[Astra Minas,0,AUTHORITY[EPSG,9300]],UNIT[m,1.0],AXIS[First local axis,NORTH],AXIS[Second local axis,WEST],AUTHORITY[EPSG,5800]]";

        public string EsriWkt => "";
    }
}