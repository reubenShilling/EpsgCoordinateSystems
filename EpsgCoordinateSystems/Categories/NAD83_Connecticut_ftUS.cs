using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Connecticut_ftUS : INad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2234;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Connecticut";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Connecticut (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,41.86666666666667],PARAMETER[standard_parallel_2,41.2],PARAMETER[latitude_of_origin,40.83333333333334],PARAMETER[central_meridian,-72.75],PARAMETER[false_easting,1000000],PARAMETER[false_northing,500000],AUTHORITY[EPSG,2234],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Connecticut (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,41.86666666666667],PARAMETER[standard_parallel_2,41.2],PARAMETER[latitude_of_origin,40.83333333333334],PARAMETER[central_meridian,-72.75],PARAMETER[false_easting,1000000],PARAMETER[false_northing,500000],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-73.53039200000001, 41.5227438181818, 0),
                    new Vector(-73.5442879999999, 41.3652978181818, 0),
                    new Vector(-73.550264, 41.2936218181819, 0),
                    new Vector(-73.47812, 41.2107588181819, 0),
                    new Vector(-73.725233, 41.1003558181819, 0),
                    new Vector(-73.653728, 41.0126148181819, 0),
                    new Vector(-73.65315200000001, 40.9983948181819, 0),
                    new Vector(-73.104422, 41.1610338181819, 0),
                    new Vector(-72.90673700000001, 41.2700598181818, 0),
                    new Vector(-72.527243, 41.2636968181819, 0),
                    new Vector(-72.378158, 41.278096818182, 0),
                    new Vector(-72.37841, 41.3583498181819, 0),
                    new Vector(-72.32635399999999, 41.2896438181818, 0),
                    new Vector(-72.281417, 41.2811478181818, 0),
                    new Vector(-71.866679, 41.3227728181819, 0),
                    new Vector(-71.84777, 41.3253468181819, 0),
                    new Vector(-71.836871, 41.3419608181818, 0),
                    new Vector(-71.845997, 41.4038538181817, 0),
                    new Vector(-71.80274300000001, 41.4158238181819, 0),
                    new Vector(-71.790188, 41.6013048181818, 0),
                    new Vector(-71.7926089999999, 41.6417508181818, 0),
                    new Vector(-71.78824400000001, 41.7215988181819, 0),
                    new Vector(-71.79782899999999, 42.0042708181819, 0),
                    new Vector(-71.802347, 42.0179778181819, 0),
                    new Vector(-72.094973, 42.0257988181819, 0),
                    new Vector(-72.136346, 42.0264018181819, 0),
                    new Vector(-72.507569, 42.0307668181819, 0),
                    new Vector(-72.571226, 42.0301278181818, 0),
                    new Vector(-72.5819089999999, 42.0216048181818, 0),
                    new Vector(-72.607829, 42.0228018181819, 0),
                    new Vector(-72.60953000000001, 42.0305328181819, 0),
                    new Vector(-72.755888, 42.0338448181819, 0),
                    new Vector(-72.76757000000001, 42.0021648181818, 0),
                    new Vector(-72.817682, 41.9971788181818, 0),
                    new Vector(-72.816458, 42.0335118181819, 0),
                    new Vector(-73.00608800000001, 42.0360048181819, 0),
                    new Vector(-73.04563400000001, 42.036310818182, 0),
                    new Vector(-73.48423099999999, 42.0474258181819, 0),
                    new Vector(-73.517144, 41.665681818182, 0),
                    new Vector(-73.53039200000001, 41.5227438181818, 0)
                })
            }
        };
    }
}