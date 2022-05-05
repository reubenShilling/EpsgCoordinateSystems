using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Colorado_Central_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 2232;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Colorado Central";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Colorado Central (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,39.75],PARAMETER[standard_parallel_2,38.45],PARAMETER[latitude_of_origin,37.83333333333334],PARAMETER[central_meridian,-105.5],PARAMETER[false_easting,3000000],PARAMETER[false_northing,1000000],AUTHORITY[EPSG,2232],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Colorado Central (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,39.75],PARAMETER[standard_parallel_2,38.45],PARAMETER[latitude_of_origin,37.83333333333334],PARAMETER[central_meridian,-105.5],PARAMETER[false_easting,3000000],PARAMETER[false_northing,1000000],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-104.930771, 38.5177788181818, 0),
                    new Vector(-104.048006, 38.515150818182, 0),
                    new Vector(-103.49888, 38.5071498181818, 0),
                    new Vector(-103.49609, 38.5126308181818, 0),
                    new Vector(-103.174961, 38.5151328181819, 0),
                    new Vector(-103.174169, 38.6085258181819, 0),
                    new Vector(-102.047585, 38.6155008181819, 0),
                    new Vector(-102.047567, 38.6925588181819, 0),
                    new Vector(-102.04898, 39.0369978181819, 0),
                    new Vector(-102.047873, 39.1267548181818, 0),
                    new Vector(-102.0488, 39.5627958181818, 0),
                    new Vector(-102.049448, 39.5686908181818, 0),
                    new Vector(-102.801893, 39.5653878181819, 0),
                    new Vector(-103.143758, 39.5613648181819, 0),
                    new Vector(-103.706015, 39.564046818182, 0),
                    new Vector(-103.706969, 39.732256818182, 0),
                    new Vector(-104.882135, 39.7328238181818, 0),
                    new Vector(-104.880209, 39.7428588181818, 0),
                    new Vector(-104.84204, 39.7456938181819, 0),
                    new Vector(-104.850752, 39.7658718181818, 0),
                    new Vector(-104.825093, 39.7674648181819, 0),
                    new Vector(-104.824994, 39.7783548181819, 0),
                    new Vector(-104.810189, 39.7819188181817, 0),
                    new Vector(-104.808119, 39.801934818182, 0),
                    new Vector(-104.843516, 39.8032668181819, 0),
                    new Vector(-104.844785, 39.7918908181819, 0),
                    new Vector(-104.86148, 39.7900818181818, 0),
                    new Vector(-104.862038, 39.8018628181819, 0),
                    new Vector(-104.88488, 39.8039688181819, 0),
                    new Vector(-104.892917, 39.783790818182, 0),
                    new Vector(-104.921033, 39.7830258181819, 0),
                    new Vector(-104.93456, 39.7903698181818, 0),
                    new Vector(-105.046556, 39.7899738181819, 0),
                    new Vector(-105.047015, 39.9088278181819, 0),
                    new Vector(-105.384803, 39.9083598181819, 0),
                    new Vector(-105.390887, 39.7439298181818, 0),
                    new Vector(-105.472085, 39.7504548181818, 0),
                    new Vector(-105.555146, 39.7899918181818, 0),
                    new Vector(-105.568466, 39.8031768181819, 0),
                    new Vector(-105.568223, 39.8199708181818, 0),
                    new Vector(-105.589661, 39.8174508181818, 0),
                    new Vector(-105.634085, 39.8395998181818, 0),
                    new Vector(-105.686591, 39.8455758181819, 0),
                    new Vector(-105.723356, 39.8080368181818, 0),
                    new Vector(-105.749654, 39.7967058181819, 0),
                    new Vector(-105.790208, 39.8035008181819, 0),
                    new Vector(-105.821744, 39.7897128181818, 0),
                    new Vector(-105.865943, 39.7972548181818, 0),
                    new Vector(-105.884771, 39.7916118181819, 0),
                    new Vector(-105.879119, 39.7477818181819, 0),
                    new Vector(-105.915002, 39.6884358181819, 0),
                    new Vector(-105.972089, 39.6827838181818, 0),
                    new Vector(-106.0286, 39.6871038181818, 0),
                    new Vector(-106.057211, 39.7228158181819, 0),
                    new Vector(-106.063016, 39.7675458181818, 0),
                    new Vector(-106.084148, 39.8076138181818, 0),
                    new Vector(-106.108673, 39.8253348181819, 0),
                    new Vector(-106.182167, 39.8493918181817, 0),
                    new Vector(-106.235501, 39.9032208181819, 0),
                    new Vector(-106.264193, 39.9103128181818, 0),
                    new Vector(-106.38167, 39.9076128181819, 0),
                    new Vector(-106.393793, 39.9180348181818, 0),
                    new Vector(-106.442393, 39.9175038181819, 0),
                    new Vector(-106.633373, 39.9180078181818, 0),
                    new Vector(-107.030138, 39.9152358181818, 0),
                    new Vector(-107.035016, 40.0876038181819, 0),
                    new Vector(-107.300471, 40.0865418181818, 0),
                    new Vector(-107.303252, 40.0019238181819, 0),
                    new Vector(-107.316257, 39.999052818182, 0),
                    new Vector(-107.320415, 39.9170988181818, 0),
                    new Vector(-107.427695, 39.9139038181819, 0),
                    new Vector(-107.432663, 39.8214468181819, 0),
                    new Vector(-107.928617, 39.8178918181819, 0),
                    new Vector(-107.93408, 39.6912888181819, 0),
                    new Vector(-108.547205, 39.6859788181818, 0),
                    new Vector(-108.548726, 39.6463428181818, 0),
                    new Vector(-108.894911, 39.6454338181818, 0),
                    new Vector(-108.897161, 39.6557658181819, 0),
                    new Vector(-109.052555, 39.6573858181818, 0),
                    new Vector(-109.053518, 39.5181738181819, 0),
                    new Vector(-109.051421, 39.3609618181819, 0),
                    new Vector(-109.053941, 38.4946578181819, 0),
                    new Vector(-108.379274, 38.5001298181818, 0),
                    new Vector(-108.372254, 38.670004818182, 0),
                    new Vector(-107.497355, 38.6629488181819, 0),
                    new Vector(-107.498354, 38.3014008181819, 0),
                    new Vector(-107.634254, 38.3033178181819, 0),
                    new Vector(-107.581442, 38.2332798181818, 0),
                    new Vector(-107.563172, 38.1469878181819, 0),
                    new Vector(-106.998035, 38.1477618181819, 0),
                    new Vector(-106.994273, 38.4189678181818, 0),
                    new Vector(-106.237535, 38.423647818182, 0),
                    new Vector(-106.239146, 38.4303888181819, 0),
                    new Vector(-106.07441, 38.4298218181819, 0),
                    new Vector(-106.064582, 38.4515118181819, 0),
                    new Vector(-106.050416, 38.4601968181818, 0),
                    new Vector(-106.02104, 38.4512958181818, 0),
                    new Vector(-105.949607, 38.3890158181817, 0),
                    new Vector(-105.898235, 38.3559228181819, 0),
                    new Vector(-105.839438, 38.2953978181819, 0),
                    new Vector(-105.772199, 38.2496688181819, 0),
                    new Vector(-105.040571, 38.2566168181818, 0),
                    new Vector(-104.931572, 38.2583448181818, 0),
                    new Vector(-104.930771, 38.5177788181818, 0)
                })
            }
        };
    }
}