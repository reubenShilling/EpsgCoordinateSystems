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
                    new Vector(38.5177788181818, -104.930771),
                    new Vector(38.515150818182, -104.048006),
                    new Vector(38.5071498181818, -103.49888),
                    new Vector(38.5126308181818, -103.49609),
                    new Vector(38.5151328181819, -103.174961),
                    new Vector(38.6085258181819, -103.174169),
                    new Vector(38.6155008181819, -102.047585),
                    new Vector(38.6925588181819, -102.047567),
                    new Vector(39.0369978181819, -102.04898),
                    new Vector(39.1267548181818, -102.047873),
                    new Vector(39.5627958181818, -102.0488),
                    new Vector(39.5686908181818, -102.049448),
                    new Vector(39.5653878181819, -102.801893),
                    new Vector(39.5613648181819, -103.143758),
                    new Vector(39.564046818182, -103.706015),
                    new Vector(39.732256818182, -103.706969),
                    new Vector(39.7328238181818, -104.882135),
                    new Vector(39.7428588181818, -104.880209),
                    new Vector(39.7456938181819, -104.84204),
                    new Vector(39.7658718181818, -104.850752),
                    new Vector(39.7674648181819, -104.825093),
                    new Vector(39.7783548181819, -104.824994),
                    new Vector(39.7819188181817, -104.810189),
                    new Vector(39.801934818182, -104.808119),
                    new Vector(39.8032668181819, -104.843516),
                    new Vector(39.7918908181819, -104.844785),
                    new Vector(39.7900818181818, -104.86148),
                    new Vector(39.8018628181819, -104.862038),
                    new Vector(39.8039688181819, -104.88488),
                    new Vector(39.783790818182, -104.892917),
                    new Vector(39.7830258181819, -104.921033),
                    new Vector(39.7903698181818, -104.93456),
                    new Vector(39.7899738181819, -105.046556),
                    new Vector(39.9088278181819, -105.047015),
                    new Vector(39.9083598181819, -105.384803),
                    new Vector(39.7439298181818, -105.390887),
                    new Vector(39.7504548181818, -105.472085),
                    new Vector(39.7899918181818, -105.555146),
                    new Vector(39.8031768181819, -105.568466),
                    new Vector(39.8199708181818, -105.568223),
                    new Vector(39.8174508181818, -105.589661),
                    new Vector(39.8395998181818, -105.634085),
                    new Vector(39.8455758181819, -105.686591),
                    new Vector(39.8080368181818, -105.723356),
                    new Vector(39.7967058181819, -105.749654),
                    new Vector(39.8035008181819, -105.790208),
                    new Vector(39.7897128181818, -105.821744),
                    new Vector(39.7972548181818, -105.865943),
                    new Vector(39.7916118181819, -105.884771),
                    new Vector(39.7477818181819, -105.879119),
                    new Vector(39.6884358181819, -105.915002),
                    new Vector(39.6827838181818, -105.972089),
                    new Vector(39.6871038181818, -106.0286),
                    new Vector(39.7228158181819, -106.057211),
                    new Vector(39.7675458181818, -106.063016),
                    new Vector(39.8076138181818, -106.084148),
                    new Vector(39.8253348181819, -106.108673),
                    new Vector(39.8493918181817, -106.182167),
                    new Vector(39.9032208181819, -106.235501),
                    new Vector(39.9103128181818, -106.264193),
                    new Vector(39.9076128181819, -106.38167),
                    new Vector(39.9180348181818, -106.393793),
                    new Vector(39.9175038181819, -106.442393),
                    new Vector(39.9180078181818, -106.633373),
                    new Vector(39.9152358181818, -107.030138),
                    new Vector(40.0876038181819, -107.035016),
                    new Vector(40.0865418181818, -107.300471),
                    new Vector(40.0019238181819, -107.303252),
                    new Vector(39.999052818182, -107.316257),
                    new Vector(39.9170988181818, -107.320415),
                    new Vector(39.9139038181819, -107.427695),
                    new Vector(39.8214468181819, -107.432663),
                    new Vector(39.8178918181819, -107.928617),
                    new Vector(39.6912888181819, -107.93408),
                    new Vector(39.6859788181818, -108.547205),
                    new Vector(39.6463428181818, -108.548726),
                    new Vector(39.6454338181818, -108.894911),
                    new Vector(39.6557658181819, -108.897161),
                    new Vector(39.6573858181818, -109.052555),
                    new Vector(39.5181738181819, -109.053518),
                    new Vector(39.3609618181819, -109.051421),
                    new Vector(38.4946578181819, -109.053941),
                    new Vector(38.5001298181818, -108.379274),
                    new Vector(38.670004818182, -108.372254),
                    new Vector(38.6629488181819, -107.497355),
                    new Vector(38.3014008181819, -107.498354),
                    new Vector(38.3033178181819, -107.634254),
                    new Vector(38.2332798181818, -107.581442),
                    new Vector(38.1469878181819, -107.563172),
                    new Vector(38.1477618181819, -106.998035),
                    new Vector(38.4189678181818, -106.994273),
                    new Vector(38.423647818182, -106.237535),
                    new Vector(38.4303888181819, -106.239146),
                    new Vector(38.4298218181819, -106.07441),
                    new Vector(38.4515118181819, -106.064582),
                    new Vector(38.4601968181818, -106.050416),
                    new Vector(38.4512958181818, -106.02104),
                    new Vector(38.3890158181817, -105.949607),
                    new Vector(38.3559228181819, -105.898235),
                    new Vector(38.2953978181819, -105.839438),
                    new Vector(38.2496688181819, -105.772199),
                    new Vector(38.2566168181818, -105.040571),
                    new Vector(38.2583448181818, -104.931572),
                    new Vector(38.5177788181818, -104.930771)
                })
            }
        };
    }
}