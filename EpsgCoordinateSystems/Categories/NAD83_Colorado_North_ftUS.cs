using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Colorado_North_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2231;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Colorado North";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Colorado North (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,40.78333333333333],PARAMETER[standard_parallel_2,39.71666666666667],PARAMETER[latitude_of_origin,39.33333333333334],PARAMETER[central_meridian,-105.5],PARAMETER[false_easting,3000000],PARAMETER[false_northing,1000000],AUTHORITY[EPSG,2231],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Colorado North (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,40.78333333333333],PARAMETER[standard_parallel_2,39.71666666666667],PARAMETER[latitude_of_origin,39.33333333333334],PARAMETER[central_meridian,-105.5],PARAMETER[false_easting,3000000],PARAMETER[false_northing,1000000],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-105.390887, 39.7439298181818, 0),
                    new Vector(-105.384803, 39.9083598181819, 0),
                    new Vector(-105.047015, 39.9088278181819, 0),
                    new Vector(-105.046556, 39.7899738181819, 0),
                    new Vector(-104.93456, 39.7903698181818, 0),
                    new Vector(-104.921033, 39.7830258181819, 0),
                    new Vector(-104.892917, 39.783790818182, 0),
                    new Vector(-104.88488, 39.8039688181819, 0),
                    new Vector(-104.862038, 39.8018628181819, 0),
                    new Vector(-104.86148, 39.7900818181818, 0),
                    new Vector(-104.844785, 39.7918908181819, 0),
                    new Vector(-104.843516, 39.8032668181819, 0),
                    new Vector(-104.808119, 39.801934818182, 0),
                    new Vector(-104.810189, 39.7819188181817, 0),
                    new Vector(-104.824994, 39.7783548181819, 0),
                    new Vector(-104.825093, 39.7674648181819, 0),
                    new Vector(-104.850752, 39.7658718181818, 0),
                    new Vector(-104.84204, 39.7456938181819, 0),
                    new Vector(-104.880209, 39.7428588181818, 0),
                    new Vector(-104.882135, 39.7328238181818, 0),
                    new Vector(-103.706969, 39.732256818182, 0),
                    new Vector(-103.706015, 39.564046818182, 0),
                    new Vector(-103.143758, 39.5613648181819, 0),
                    new Vector(-102.801893, 39.5653878181819, 0),
                    new Vector(-102.049448, 39.5686908181818, 0),
                    new Vector(-102.051536, 39.9989178181818, 0),
                    new Vector(-102.047549, 40.3426458181818, 0),
                    new Vector(-102.047621, 40.4310798181819, 0),
                    new Vector(-102.046028, 40.6973178181819, 0),
                    new Vector(-102.046991, 40.7431278181818, 0),
                    new Vector(-102.047738, 40.9980708181819, 0),
                    new Vector(-102.621254, 41.0002218181818, 0),
                    new Vector(-102.652277, 40.9981248181819, 0),
                    new Vector(-103.382951, 41.0003208181819, 0),
                    new Vector(-103.57232, 40.9996458181818, 0),
                    new Vector(-104.051705, 41.0032098181818, 0),
                    new Vector(-104.934488, 40.9942908181819, 0),
                    new Vector(-105.278801, 40.9963428181819, 0),
                    new Vector(-106.203479, 41.0000778181819, 0),
                    new Vector(-106.329119, 41.0012928181818, 0),
                    new Vector(-106.865438, 40.9984578181819, 0),
                    new Vector(-107.304053, 41.0001408181819, 0),
                    new Vector(-107.918672, 41.0033718181819, 0),
                    new Vector(-109.048316, 40.9984398181819, 0),
                    new Vector(-109.046156, 40.6652868181818, 0),
                    new Vector(-109.051268, 40.210507818182, 0),
                    new Vector(-109.052555, 39.6573858181818, 0),
                    new Vector(-108.897161, 39.6557658181819, 0),
                    new Vector(-108.894911, 39.6454338181818, 0),
                    new Vector(-108.548726, 39.6463428181818, 0),
                    new Vector(-108.547205, 39.6859788181818, 0),
                    new Vector(-107.93408, 39.6912888181819, 0),
                    new Vector(-107.928617, 39.8178918181819, 0),
                    new Vector(-107.432663, 39.8214468181819, 0),
                    new Vector(-107.427695, 39.9139038181819, 0),
                    new Vector(-107.320415, 39.9170988181818, 0),
                    new Vector(-107.316257, 39.999052818182, 0),
                    new Vector(-107.303252, 40.0019238181819, 0),
                    new Vector(-107.300471, 40.0865418181818, 0),
                    new Vector(-107.035016, 40.0876038181819, 0),
                    new Vector(-107.030138, 39.9152358181818, 0),
                    new Vector(-106.633373, 39.9180078181818, 0),
                    new Vector(-106.442393, 39.9175038181819, 0),
                    new Vector(-106.393793, 39.9180348181818, 0),
                    new Vector(-106.38167, 39.9076128181819, 0),
                    new Vector(-106.264193, 39.9103128181818, 0),
                    new Vector(-106.235501, 39.9032208181819, 0),
                    new Vector(-106.182167, 39.8493918181817, 0),
                    new Vector(-106.108673, 39.8253348181819, 0),
                    new Vector(-106.084148, 39.8076138181818, 0),
                    new Vector(-106.063016, 39.7675458181818, 0),
                    new Vector(-106.057211, 39.7228158181819, 0),
                    new Vector(-106.0286, 39.6871038181818, 0),
                    new Vector(-105.972089, 39.6827838181818, 0),
                    new Vector(-105.915002, 39.6884358181819, 0),
                    new Vector(-105.879119, 39.7477818181819, 0),
                    new Vector(-105.884771, 39.7916118181819, 0),
                    new Vector(-105.865943, 39.7972548181818, 0),
                    new Vector(-105.821744, 39.7897128181818, 0),
                    new Vector(-105.790208, 39.8035008181819, 0),
                    new Vector(-105.749654, 39.7967058181819, 0),
                    new Vector(-105.723356, 39.8080368181818, 0),
                    new Vector(-105.686591, 39.8455758181819, 0),
                    new Vector(-105.634085, 39.8395998181818, 0),
                    new Vector(-105.589661, 39.8174508181818, 0),
                    new Vector(-105.568223, 39.8199708181818, 0),
                    new Vector(-105.568466, 39.8031768181819, 0),
                    new Vector(-105.555146, 39.7899918181818, 0),
                    new Vector(-105.472085, 39.7504548181818, 0),
                    new Vector(-105.390887, 39.7439298181818, 0)
                })
            }
        };
    }
}