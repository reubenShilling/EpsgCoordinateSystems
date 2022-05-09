using System.Collections.Generic;
using SharpKml.Base;
using SharpKml.Dom;
using DotSpatial.Projections;
using SharpKml.Engine;

namespace EpsgCoordinateSystems.Categories
{
    public class NAD83_Nevada_West_ftUS : INad83UsFtCrs
    {
        private const int _srid = 3423;
        private readonly BoundingBox _boundingBox = new BoundingBox();

public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Nevada West";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt => "PROJCS[\"NAD83 / Nevada West (ft US)\",GEOGCS[\"NAD83\",DATUM[\"North_American_Datum_1983\",SPHEROID[\"GRS 1980\",6378137,298.257222101,AUTHORITY[\"EPSG\",\"7019\"]],AUTHORITY[\"EPSG\",\"6269\"]],PRIMEM[\"Greenwich\",0,AUTHORITY[\"EPSG\",\"8901\"]],UNIT[\"degree\",0.01745329251994328,AUTHORITY[\"EPSG\",\"9122\"]],AUTHORITY[\"EPSG\",\"4269\"]],UNIT[\"US survey foot\",0.3048006096012192,AUTHORITY[\"EPSG\",\"9003\"]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",34.75],PARAMETER[\"central_meridian\",-118.5833333333333],PARAMETER[\"scale_factor\",0.9999],PARAMETER[\"false_easting\",2624666.6667],PARAMETER[\"false_northing\",13123333.3333],AUTHORITY[\"EPSG\",\"3423\"],AXIS[\"X\",EAST],AXIS[\"Y\",NORTH]]";

        public string EsriWkt => "PROJCS[\"NAD83 / Nevada West (ft US)\",GEOGCS[\"GCS_North_American_1983\",DATUM[\"D_North_American_1983\",SPHEROID[\"GRS_1980\",6378137,298.257222101]],PRIMEM[\"Greenwich\",0],UNIT[\"Degree\",0.017453292519943295]],PROJECTION[\"Transverse_Mercator\"],PARAMETER[\"latitude_of_origin\",34.75],PARAMETER[\"central_meridian\",-118.5833333333333],PARAMETER[\"scale_factor\",0.9999],PARAMETER[\"false_easting\",2624666.6667],PARAMETER[\"false_northing\",13123333.3333],UNIT[\"Foot_US\",0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(39.0634938181819, -119.995151),
                    new Vector(38.9941128181818, -119.995259),
                    new Vector(38.9222568181819, -119.889347),
                    new Vector(38.7029088181818, -119.575679),
                    new Vector(38.5271118181818, -119.318828),
                    new Vector(38.4118038181819, -119.152454),
                    new Vector(37.8866718181819, -118.417424),
                    new Vector(37.4572998181819, -117.838679),
                    new Vector(36.9595908181819, -117.16043),
                    new Vector(37.9922328181819, -117.155084),
                    new Vector(38.0415618181818, -117.208355),
                    new Vector(38.0428758181819, -117.232322),
                    new Vector(38.0605518181819, -117.232376),
                    new Vector(38.4572808181817, -117.681458),
                    new Vector(38.8972368181819, -118.18283),
                    new Vector(38.9997018181818, -118.18094),
                    new Vector(39.0753918181817, -117.849056),
                    new Vector(39.0931578181818, -117.765671),
                    new Vector(39.1275018181818, -117.781457),
                    new Vector(39.1624578181818, -117.772934),
                    new Vector(39.1765788181818, -117.760613),
                    new Vector(39.1862718181819, -117.731633),
                    new Vector(39.2317578181818, -117.706559),
                    new Vector(39.3280938181818, -117.741389),
                    new Vector(39.366172818182, -117.741191),
                    new Vector(39.3739488181819, -117.730553),
                    new Vector(39.3704838181819, -117.700763),
                    new Vector(39.3792228181819, -117.677633),
                    new Vector(39.4028388181819, -117.670712),
                    new Vector(39.4166358181819, -117.632732),
                    new Vector(39.4316208181819, -117.6269),
                    new Vector(39.4632828181819, -117.641471),
                    new Vector(39.4925598181818, -117.585113),
                    new Vector(39.5216208181819, -117.575798),
                    new Vector(39.5180928181818, -117.5549),
                    new Vector(39.5250948181819, -117.508433),
                    new Vector(39.5165628181819, -117.485105),
                    new Vector(39.5579178181818, -117.458546),
                    new Vector(39.5891748181818, -117.464117),
                    new Vector(39.6200628181819, -117.446999),
                    new Vector(39.6404028181819, -117.465044),
                    new Vector(39.6889308181819, -117.45698),
                    new Vector(39.7423908181818, -117.466304),
                    new Vector(39.7740348181819, -117.488642),
                    new Vector(39.8334618181819, -117.481271),
                    new Vector(39.8648088181818, -117.462299),
                    new Vector(39.9037968181818, -117.463154),
                    new Vector(39.9427578181819, -117.473603),
                    new Vector(39.9766698181818, -117.494834),
                    new Vector(39.9982698181818, -117.534605),
                    new Vector(40.5291528181819, -117.294233),
                    new Vector(40.6426338181819, -117.24323),
                    new Vector(40.6428768181819, -117.010625),
                    new Vector(40.9935168181818, -117.007025),
                    new Vector(41.994793818182, -116.992319),
                    new Vector(41.994793818182, -117.01886),
                    new Vector(41.9966388181819, -118.185323),
                    new Vector(41.9891328181818, -119.310953),
                    new Vector(41.9888538181818, -119.351678),
                    new Vector(41.9892048181819, -119.993468),
                    new Vector(41.1775668181818, -119.99633),
                    new Vector(39.7206108181819, -119.996168),
                    new Vector(39.4435008181818, -119.996006),
                    new Vector(39.3115428181817, -119.995304),
                    new Vector(39.1587048181819, -119.995529),
                    new Vector(39.1061268181817, -119.994548),
                    new Vector(39.0634938181819, -119.995151)
                })
            }
        };

        public BoundingBox BoundingBox => CalculateBoundingBox();

        private BoundingBox CalculateBoundingBox()
        {
            foreach (var linearRing in Wgs84Boundaries)
            {
                _boundingBox.Expand(linearRing.CalculateBounds());
            }

            return _boundingBox;
        }
    }
}