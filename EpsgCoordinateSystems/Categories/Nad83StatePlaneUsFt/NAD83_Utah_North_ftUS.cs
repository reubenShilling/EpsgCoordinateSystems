using System.Collections.Generic;
using DotSpatial.Projections;
using SharpKml.Base;
using SharpKml.Dom;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories.Nad83StatePlaneUsFt
{
    internal class NAD83_Utah_North_ftUS : INad83UsFtCrs
    {
        private const int _srid = 3560;
        private readonly BoundingBox _boundingBox = new BoundingBox();

        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Utah North";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public Category Category => Category.StatePlaneNad83;

        public string OgcWkt =>
            "PROJCS[\"NAD83 / Utah North (ftUS)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Lambert_Conformal_Conic_2SP\"],PARAMETER[\"standard_parallel_1\",41.78333333333333],PARAMETER[\"standard_parallel_2\",40.71666666666667],PARAMETER[\"latitude_of_origin\",40.33333333333334],PARAMETER[\"central_meridian\",-111.5],PARAMETER[\"false_easting\",1640416.6667],PARAMETER[\"false_northing\",3280833.333300001],AUTHORITY[\"EPSG\",\"3560\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt =>
            "PROJCS[\"NAD83 / Utah North (ftUS)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Lambert_Conformal_Conic\"],PARAMETER[\"standard_parallel_1\",41.78333333333333],PARAMETER[\"standard_parallel_2\",40.71666666666667],PARAMETER[\"latitude_of_origin\",40.33333333333334],PARAMETER[\"central_meridian\",-111.5],PARAMETER[\"false_easting\",1640416.6667],PARAMETER[\"false_northing\",3280833.333300001],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(40.8044538181819, -109.97258),
                    new Vector(40.7777328181818, -109.893065),
                    new Vector(40.7727648181819, -109.836986),
                    new Vector(40.7833038181819, -109.798169),
                    new Vector(40.7814048181818, -109.772789),
                    new Vector(40.808377818182, -109.743251),
                    new Vector(40.8025008181819, -109.672619),
                    new Vector(40.8181878181819, -109.558931),
                    new Vector(40.8286548181819, -109.52798),
                    new Vector(40.8243978181818, -109.517459),
                    new Vector(40.8007638181818, -109.510196),
                    new Vector(40.7587338181819, -109.507343),
                    new Vector(40.7469438181819, -109.469651),
                    new Vector(40.7993328181819, -109.386734),
                    new Vector(40.8609738181819, -109.382549),
                    new Vector(40.857949818182, -109.190246),
                    new Vector(40.7910708181819, -109.190921),
                    new Vector(40.7897028181819, -109.153913),
                    new Vector(40.6886778181818, -109.146839),
                    new Vector(40.6886058181819, -109.109129),
                    new Vector(40.6612998181818, -109.109129),
                    new Vector(40.6652868181818, -109.046156),
                    new Vector(40.9984398181819, -109.048316),
                    new Vector(40.9976028181819, -110.002163),
                    new Vector(40.9978908181819, -110.063183),
                    new Vector(40.9965858181819, -111.051023),
                    new Vector(41.2584228181818, -111.051653),
                    new Vector(41.5785888181818, -111.051077),
                    new Vector(41.9961978181819, -111.048701),
                    new Vector(42.0001758181818, -111.494579),
                    new Vector(42.0022998181818, -112.100513),
                    new Vector(41.9990508181818, -112.147106),
                    new Vector(42.0011478181819, -112.989569),
                    new Vector(41.9953878181819, -114.039077),
                    new Vector(40.9976838181818, -114.038159),
                    new Vector(40.9990788181818, -112.837325),
                    new Vector(41.0783148181818, -112.495874),
                    new Vector(41.0773608181819, -112.494722),
                    new Vector(40.7706588181818, -112.253549),
                    new Vector(40.9183128181818, -112.005563),
                    new Vector(40.9180158181818, -111.952013),
                    new Vector(40.8563928181819, -111.955784),
                    new Vector(40.8239838181818, -111.928892),
                    new Vector(40.8311748181819, -111.82559),
                    new Vector(40.8523608181819, -111.755282),
                    new Vector(40.8635928181819, -111.741071),
                    new Vector(40.8476628181818, -111.707573),
                    new Vector(40.852234818182, -111.686549),
                    new Vector(40.8476448181818, -111.663761),
                    new Vector(40.8306618181819, -111.659576),
                    new Vector(40.8145878181819, -111.634025),
                    new Vector(40.8014208181819, -111.644744),
                    new Vector(40.7731608181819, -111.64262),
                    new Vector(40.7629098181819, -111.625772),
                    new Vector(40.7330838181818, -111.618914),
                    new Vector(40.7036718181818, -111.589574),
                    new Vector(40.6630728181819, -111.596297),
                    new Vector(40.6120158181818, -111.549839),
                    new Vector(40.6064808181818, -111.474455),
                    new Vector(40.6481598181819, -111.461513),
                    new Vector(40.6606338181819, -111.435053),
                    new Vector(40.6753128181818, -111.427826),
                    new Vector(40.6827198181818, -111.389594),
                    new Vector(40.6348488181819, -111.365465),
                    new Vector(40.6216098181818, -111.313139),
                    new Vector(40.5942678181818, -111.271046),
                    new Vector(40.5550998181819, -111.149951),
                    new Vector(40.5997398181818, -111.103205),
                    new Vector(40.6001628181818, -111.083153),
                    new Vector(40.5860148181818, -111.062507),
                    new Vector(40.5802728181819, -111.036902),
                    new Vector(40.5921168181819, -110.97041),
                    new Vector(40.6014498181819, -110.956271),
                    new Vector(40.6747548181818, -110.930603),
                    new Vector(40.6808838181819, -110.897285),
                    new Vector(40.709089818182, -110.897897),
                    new Vector(40.7315628181819, -110.8832),
                    new Vector(40.7216988181818, -110.839091),
                    new Vector(40.7132568181819, -110.833745),
                    new Vector(40.7125368181819, -110.800382),
                    new Vector(40.7420928181818, -110.754041),
                    new Vector(40.7491758181819, -110.704172),
                    new Vector(40.743712818182, -110.658452),
                    new Vector(40.7688678181819, -110.625188),
                    new Vector(40.7611908181819, -110.608241),
                    new Vector(40.7618298181819, -110.566823),
                    new Vector(40.7747808181818, -110.544368),
                    new Vector(40.7682828181818, -110.506028),
                    new Vector(40.7768148181818, -110.48639),
                    new Vector(40.7825478181819, -110.429888),
                    new Vector(40.7922768181818, -110.415596),
                    new Vector(40.7883798181818, -110.375816),
                    new Vector(40.7925378181818, -110.359598),
                    new Vector(40.8230028181818, -110.333615),
                    new Vector(40.8318408181819, -110.251193),
                    new Vector(40.8097908181818, -110.086502),
                    new Vector(40.8195918181818, -110.041097),
                    new Vector(40.8130308181819, -109.996079),
                    new Vector(40.8044538181819, -109.97258)
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