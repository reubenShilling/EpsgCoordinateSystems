using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Wyoming_East_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 3736;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Wyoming East";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Wyoming East (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40.5],PARAMETER[central_meridian,-105.1666666666667],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,656166.6667],PARAMETER[false_northing,0],AUTHORITY[EPSG,3736],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Wyoming East (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Transverse_Mercator],PARAMETER[latitude_of_origin,40.5],PARAMETER[central_meridian,-105.1666666666667],PARAMETER[scale_factor,0.9999375],PARAMETER[false_easting,656166.6667],PARAMETER[false_northing,0],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-104.053505, 41.9998158181818, 0),
                    new Vector(-104.056223, 42.6146688181819, 0),
                    new Vector(-104.056196, 43.0030638181819, 0),
                    new Vector(-104.059157, 43.4791368181819, 0),
                    new Vector(-104.057915, 43.5037068181817, 0),
                    new Vector(-104.059481, 43.8529068181819, 0),
                    new Vector(-104.059724, 44.1458298181818, 0),
                    new Vector(-104.061038, 44.1818298181819, 0),
                    new Vector(-104.059472, 44.5743558181818, 0),
                    new Vector(-104.059841, 44.9973378181819, 0),
                    new Vector(-105.041804, 45.0010728181819, 0),
                    new Vector(-105.085013, 44.9998218181819, 0),
                    new Vector(-106.021157, 44.9972118181819, 0),
                    new Vector(-106.023317, 44.876188818182, 0),
                    new Vector(-106.011032, 44.8745508181818, 0),
                    new Vector(-106.016324, 44.5564098181818, 0),
                    new Vector(-106.01681, 44.5294908181819, 0),
                    new Vector(-106.025144, 44.5298148181819, 0),
                    new Vector(-106.020761, 44.1687618181819, 0),
                    new Vector(-106.008665, 44.1694008181819, 0),
                    new Vector(-106.004048, 43.8181668181819, 0),
                    new Vector(-106.019906, 43.8188328181819, 0),
                    new Vector(-106.028042, 43.4949588181818, 0),
                    new Vector(-106.082312, 43.4945538181819, 0),
                    new Vector(-106.081097, 43.4754558181818, 0),
                    new Vector(-106.07099, 43.4751678181819, 0),
                    new Vector(-106.082285, 42.4347678181818, 0),
                    new Vector(-106.071908, 41.3997948181818, 0),
                    new Vector(-106.324196, 41.3986428181819, 0),
                    new Vector(-106.329119, 41.0012928181818, 0),
                    new Vector(-106.203479, 41.0000778181819, 0),
                    new Vector(-105.278801, 40.9963428181819, 0),
                    new Vector(-104.934488, 40.9942908181819, 0),
                    new Vector(-104.051705, 41.0032098181818, 0),
                    new Vector(-104.054009, 41.3880858181819, 0),
                    new Vector(-104.055503, 41.5642158181819, 0),
                    new Vector(-104.053622, 41.6982168181818, 0),
                    new Vector(-104.053505, 41.9998158181818, 0)
                })
            }
        };
    }
}