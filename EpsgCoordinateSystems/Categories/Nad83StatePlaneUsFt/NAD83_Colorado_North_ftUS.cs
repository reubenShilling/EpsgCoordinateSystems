using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_Colorado_North_ftUS : INad83UsFtCrs
    {
        private const int _srid = 2231;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Colorado North";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / Colorado North (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",40.78333333333333],PARAMETER[\"standard_parallel_2\",39.71666666666667],PARAMETER[\"latitude_of_origin\",39.33333333333334],PARAMETER[\"central_meridian\",-105.5],PARAMETER[\"false_easting\",3000000],PARAMETER[\"false_northing\",1000000],AUTHORITY[\"EPSG\",\"2231\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / Colorado North (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",40.78333333333333],PARAMETER[\"standard_parallel_2\",39.71666666666667],PARAMETER[\"latitude_of_origin\",39.33333333333334],PARAMETER[\"central_meridian\",-105.5],PARAMETER[\"false_easting\",3000000],PARAMETER[\"false_northing\",1000000],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(39.7439298181818, -105.390887),
                    new Vector(39.9083598181819, -105.384803),
                    new Vector(39.9088278181819, -105.047015),
                    new Vector(39.7899738181819, -105.046556),
                    new Vector(39.7903698181818, -104.93456),
                    new Vector(39.7830258181819, -104.921033),
                    new Vector(39.783790818182, -104.892917),
                    new Vector(39.8039688181819, -104.88488),
                    new Vector(39.8018628181819, -104.862038),
                    new Vector(39.7900818181818, -104.86148),
                    new Vector(39.7918908181819, -104.844785),
                    new Vector(39.8032668181819, -104.843516),
                    new Vector(39.801934818182, -104.808119),
                    new Vector(39.7819188181817, -104.810189),
                    new Vector(39.7783548181819, -104.824994),
                    new Vector(39.7674648181819, -104.825093),
                    new Vector(39.7658718181818, -104.850752),
                    new Vector(39.7456938181819, -104.84204),
                    new Vector(39.7428588181818, -104.880209),
                    new Vector(39.7328238181818, -104.882135),
                    new Vector(39.732256818182, -103.706969),
                    new Vector(39.564046818182, -103.706015),
                    new Vector(39.5613648181819, -103.143758),
                    new Vector(39.5653878181819, -102.801893),
                    new Vector(39.5686908181818, -102.049448),
                    new Vector(39.9989178181818, -102.051536),
                    new Vector(40.3426458181818, -102.047549),
                    new Vector(40.4310798181819, -102.047621),
                    new Vector(40.6973178181819, -102.046028),
                    new Vector(40.7431278181818, -102.046991),
                    new Vector(40.9980708181819, -102.047738),
                    new Vector(41.0002218181818, -102.621254),
                    new Vector(40.9981248181819, -102.652277),
                    new Vector(41.0003208181819, -103.382951),
                    new Vector(40.9996458181818, -103.57232),
                    new Vector(41.0032098181818, -104.051705),
                    new Vector(40.9942908181819, -104.934488),
                    new Vector(40.9963428181819, -105.278801),
                    new Vector(41.0000778181819, -106.203479),
                    new Vector(41.0012928181818, -106.329119),
                    new Vector(40.9984578181819, -106.865438),
                    new Vector(41.0001408181819, -107.304053),
                    new Vector(41.0033718181819, -107.918672),
                    new Vector(40.9984398181819, -109.048316),
                    new Vector(40.6652868181818, -109.046156),
                    new Vector(40.210507818182, -109.051268),
                    new Vector(39.6573858181818, -109.052555),
                    new Vector(39.6557658181819, -108.897161),
                    new Vector(39.6454338181818, -108.894911),
                    new Vector(39.6463428181818, -108.548726),
                    new Vector(39.6859788181818, -108.547205),
                    new Vector(39.6912888181819, -107.93408),
                    new Vector(39.8178918181819, -107.928617),
                    new Vector(39.8214468181819, -107.432663),
                    new Vector(39.9139038181819, -107.427695),
                    new Vector(39.9170988181818, -107.320415),
                    new Vector(39.999052818182, -107.316257),
                    new Vector(40.0019238181819, -107.303252),
                    new Vector(40.0865418181818, -107.300471),
                    new Vector(40.0876038181819, -107.035016),
                    new Vector(39.9152358181818, -107.030138),
                    new Vector(39.9180078181818, -106.633373),
                    new Vector(39.9175038181819, -106.442393),
                    new Vector(39.9180348181818, -106.393793),
                    new Vector(39.9076128181819, -106.38167),
                    new Vector(39.9103128181818, -106.264193),
                    new Vector(39.9032208181819, -106.235501),
                    new Vector(39.8493918181817, -106.182167),
                    new Vector(39.8253348181819, -106.108673),
                    new Vector(39.8076138181818, -106.084148),
                    new Vector(39.7675458181818, -106.063016),
                    new Vector(39.7228158181819, -106.057211),
                    new Vector(39.6871038181818, -106.0286),
                    new Vector(39.6827838181818, -105.972089),
                    new Vector(39.6884358181819, -105.915002),
                    new Vector(39.7477818181819, -105.879119),
                    new Vector(39.7916118181819, -105.884771),
                    new Vector(39.7972548181818, -105.865943),
                    new Vector(39.7897128181818, -105.821744),
                    new Vector(39.8035008181819, -105.790208),
                    new Vector(39.7967058181819, -105.749654),
                    new Vector(39.8080368181818, -105.723356),
                    new Vector(39.8455758181819, -105.686591),
                    new Vector(39.8395998181818, -105.634085),
                    new Vector(39.8174508181818, -105.589661),
                    new Vector(39.8199708181818, -105.568223),
                    new Vector(39.8031768181819, -105.568466),
                    new Vector(39.7899918181818, -105.555146),
                    new Vector(39.7504548181818, -105.472085),
                    new Vector(39.7439298181818, -105.390887)
                })
            }
        };

        public BoundingBox BoundingBox => CalculateBoundingBox();

        private BoundingBox CalculateBoundingBox()
        {
            foreach (var linearRing in Wgs84Boundaries) _boundingBox.Expand(linearRing.CalculateBounds());

            return _boundingBox;
        }
    }
}