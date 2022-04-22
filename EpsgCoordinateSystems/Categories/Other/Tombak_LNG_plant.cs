using DotSpatial.Projections;namespace EpsgCoordinateSystems.Categories.Other
{
    public class Tombak_LNG_plant : IEpsgCoordinateSystem
    {private const int _srid = 5817; public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Tombak LNG plant";
        public string Units => "Unspecified";
public int Srid => _srid;

        public string OgcWkt =>
            "LOCAL_CS[Tombak LNG plant,LOCAL_DATUM[Tombak LNG plant,0,AUTHORITY[EPSG,9314]],UNIT[m,1.0],AXIS[Plant East,NORTH_EAST],AXIS[Plant North,NORTH_WEST],AUTHORITY[EPSG,5817]]";

        public string EsriWkt => "";
    }
}