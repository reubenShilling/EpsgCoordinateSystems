using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Base;
using SharpKml.Dom;
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
                    new Vector(41.9998158181818, -104.053505),
                    new Vector(42.6146688181819, -104.056223),
                    new Vector(43.0030638181819, -104.056196),
                    new Vector(43.4791368181819, -104.059157),
                    new Vector(43.5037068181817, -104.057915),
                    new Vector(43.8529068181819, -104.059481),
                    new Vector(44.1458298181818, -104.059724),
                    new Vector(44.1818298181819, -104.061038),
                    new Vector(44.5743558181818, -104.059472),
                    new Vector(44.9973378181819, -104.059841),
                    new Vector(45.0010728181819, -105.041804),
                    new Vector(44.9998218181819, -105.085013),
                    new Vector(44.9972118181819, -106.021157),
                    new Vector(44.876188818182, -106.023317),
                    new Vector(44.8745508181818, -106.011032),
                    new Vector(44.5564098181818, -106.016324),
                    new Vector(44.5294908181819, -106.01681),
                    new Vector(44.5298148181819, -106.025144),
                    new Vector(44.1687618181819, -106.020761),
                    new Vector(44.1694008181819, -106.008665),
                    new Vector(43.8181668181819, -106.004048),
                    new Vector(43.8188328181819, -106.019906),
                    new Vector(43.4949588181818, -106.028042),
                    new Vector(43.4945538181819, -106.082312),
                    new Vector(43.4754558181818, -106.081097),
                    new Vector(43.4751678181819, -106.07099),
                    new Vector(42.4347678181818, -106.082285),
                    new Vector(41.3997948181818, -106.071908),
                    new Vector(41.3986428181819, -106.324196),
                    new Vector(41.0012928181818, -106.329119),
                    new Vector(41.0000778181819, -106.203479),
                    new Vector(40.9963428181819, -105.278801),
                    new Vector(40.9942908181819, -104.934488),
                    new Vector(41.0032098181818, -104.051705),
                    new Vector(41.3880858181819, -104.054009),
                    new Vector(41.5642158181819, -104.055503),
                    new Vector(41.6982168181818, -104.053622),
                    new Vector(41.9998158181818, -104.053505)
                })
            }
        };
    }
}