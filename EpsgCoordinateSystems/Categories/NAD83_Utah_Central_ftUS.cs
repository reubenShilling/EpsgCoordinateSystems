using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Utah_Central_ftUS : Nad83StatePlaneUsFtCoordinateSystem
    {
        private const int _srid = 3566;
        public override ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public override string Name => "Utah Central";
        public override string Units => "US feet";
        public override int Srid => _srid;

        public override string OgcWkt =>
            "PROJCS[NAD83 / Utah Central (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,40.65],PARAMETER[standard_parallel_2,39.01666666666667],PARAMETER[latitude_of_origin,38.33333333333334],PARAMETER[central_meridian,-111.5],PARAMETER[false_easting,1640416.6667],PARAMETER[false_northing,6561666.666700001],AUTHORITY[EPSG,3566],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public override string EsriWkt =>
            "PROJCS[NAD83 / Utah Central (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,40.65],PARAMETER[standard_parallel_2,39.01666666666667],PARAMETER[latitude_of_origin,38.33333333333334],PARAMETER[central_meridian,-111.5],PARAMETER[false_easting,1640416.6667],PARAMETER[false_northing,6561666.666700001],UNIT[Foot_US,0.30480060960121924]]";

        public override List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(-109.053518, 39.5181738181819, 0),
                    new Vector(-109.052555, 39.6573858181818, 0),
                    new Vector(-109.051268, 40.210507818182, 0),
                    new Vector(-109.046156, 40.6652868181818, 0),
                    new Vector(-109.109129, 40.6612998181818, 0),
                    new Vector(-109.109129, 40.6886058181819, 0),
                    new Vector(-109.146839, 40.6886778181818, 0),
                    new Vector(-109.153913, 40.7897028181819, 0),
                    new Vector(-109.190921, 40.7910708181819, 0),
                    new Vector(-109.190246, 40.857949818182, 0),
                    new Vector(-109.382549, 40.8609738181819, 0),
                    new Vector(-109.386734, 40.7993328181819, 0),
                    new Vector(-109.469651, 40.7469438181819, 0),
                    new Vector(-109.507343, 40.7587338181819, 0),
                    new Vector(-109.510196, 40.8007638181818, 0),
                    new Vector(-109.517459, 40.8243978181818, 0),
                    new Vector(-109.52798, 40.8286548181819, 0),
                    new Vector(-109.558931, 40.8181878181819, 0),
                    new Vector(-109.672619, 40.8025008181819, 0),
                    new Vector(-109.743251, 40.808377818182, 0),
                    new Vector(-109.772789, 40.7814048181818, 0),
                    new Vector(-109.798169, 40.7833038181819, 0),
                    new Vector(-109.836986, 40.7727648181819, 0),
                    new Vector(-109.893065, 40.7777328181818, 0),
                    new Vector(-109.97258, 40.8044538181819, 0),
                    new Vector(-109.996079, 40.8130308181819, 0),
                    new Vector(-110.041097, 40.8195918181818, 0),
                    new Vector(-110.086502, 40.8097908181818, 0),
                    new Vector(-110.251193, 40.8318408181819, 0),
                    new Vector(-110.333615, 40.8230028181818, 0),
                    new Vector(-110.359598, 40.7925378181818, 0),
                    new Vector(-110.375816, 40.7883798181818, 0),
                    new Vector(-110.415596, 40.7922768181818, 0),
                    new Vector(-110.429888, 40.7825478181819, 0),
                    new Vector(-110.48639, 40.7768148181818, 0),
                    new Vector(-110.506028, 40.7682828181818, 0),
                    new Vector(-110.544368, 40.7747808181818, 0),
                    new Vector(-110.566823, 40.7618298181819, 0),
                    new Vector(-110.608241, 40.7611908181819, 0),
                    new Vector(-110.625188, 40.7688678181819, 0),
                    new Vector(-110.658452, 40.743712818182, 0),
                    new Vector(-110.704172, 40.7491758181819, 0),
                    new Vector(-110.754041, 40.7420928181818, 0),
                    new Vector(-110.800382, 40.7125368181819, 0),
                    new Vector(-110.833745, 40.7132568181819, 0),
                    new Vector(-110.839091, 40.7216988181818, 0),
                    new Vector(-110.8832, 40.7315628181819, 0),
                    new Vector(-110.897897, 40.709089818182, 0),
                    new Vector(-110.897285, 40.6808838181819, 0),
                    new Vector(-110.930603, 40.6747548181818, 0),
                    new Vector(-110.956271, 40.6014498181819, 0),
                    new Vector(-110.97041, 40.5921168181819, 0),
                    new Vector(-111.036902, 40.5802728181819, 0),
                    new Vector(-111.062507, 40.5860148181818, 0),
                    new Vector(-111.083153, 40.6001628181818, 0),
                    new Vector(-111.103205, 40.5997398181818, 0),
                    new Vector(-111.149951, 40.5550998181819, 0),
                    new Vector(-111.271046, 40.5942678181818, 0),
                    new Vector(-111.313139, 40.6216098181818, 0),
                    new Vector(-111.365465, 40.6348488181819, 0),
                    new Vector(-111.389594, 40.6827198181818, 0),
                    new Vector(-111.427826, 40.6753128181818, 0),
                    new Vector(-111.435053, 40.6606338181819, 0),
                    new Vector(-111.461513, 40.6481598181819, 0),
                    new Vector(-111.474455, 40.6064808181818, 0),
                    new Vector(-111.549839, 40.6120158181818, 0),
                    new Vector(-111.596297, 40.6630728181819, 0),
                    new Vector(-111.589574, 40.7036718181818, 0),
                    new Vector(-111.618914, 40.7330838181818, 0),
                    new Vector(-111.625772, 40.7629098181819, 0),
                    new Vector(-111.64262, 40.7731608181819, 0),
                    new Vector(-111.644744, 40.8014208181819, 0),
                    new Vector(-111.634025, 40.8145878181819, 0),
                    new Vector(-111.659576, 40.8306618181819, 0),
                    new Vector(-111.663761, 40.8476448181818, 0),
                    new Vector(-111.686549, 40.852234818182, 0),
                    new Vector(-111.707573, 40.8476628181818, 0),
                    new Vector(-111.741071, 40.8635928181819, 0),
                    new Vector(-111.755282, 40.8523608181819, 0),
                    new Vector(-111.82559, 40.8311748181819, 0),
                    new Vector(-111.928892, 40.8239838181818, 0),
                    new Vector(-111.955784, 40.8563928181819, 0),
                    new Vector(-111.952013, 40.9180158181818, 0),
                    new Vector(-112.005563, 40.9183128181818, 0),
                    new Vector(-112.253549, 40.7706588181818, 0),
                    new Vector(-112.494722, 41.0773608181819, 0),
                    new Vector(-112.495874, 41.0783148181818, 0),
                    new Vector(-112.837325, 40.9990788181818, 0),
                    new Vector(-114.038159, 40.9976838181818, 0),
                    new Vector(-114.038105, 40.1110488181818, 0),
                    new Vector(-114.039842, 39.9087828181819, 0),
                    new Vector(-114.040112, 39.5386848181819, 0),
                    new Vector(-114.044261, 38.6789958181819, 0),
                    new Vector(-114.045089, 38.5710948181818, 0),
                    new Vector(-113.563562, 38.5790238181818, 0),
                    new Vector(-113.127449, 38.5715538181819, 0),
                    new Vector(-113.127773, 38.5765578181819, 0),
                    new Vector(-112.517546, 38.5731288181818, 0),
                    new Vector(-112.513973, 38.5067538181819, 0),
                    new Vector(-112.066376, 38.5082568181819, 0),
                    new Vector(-112.067159, 38.4964938181819, 0),
                    new Vector(-111.768692, 38.4955218181818, 0),
                    new Vector(-111.740027, 38.5092828181819, 0),
                    new Vector(-111.304274, 38.5071498181818, 0),
                    new Vector(-111.303662, 38.4998508181819, 0),
                    new Vector(-110.039702, 38.4980148181818, 0),
                    new Vector(-109.053941, 38.4946578181819, 0),
                    new Vector(-109.051421, 39.3609618181819, 0),
                    new Vector(-109.053518, 39.5181738181819, 0)
                })
            }
        };
    }
}