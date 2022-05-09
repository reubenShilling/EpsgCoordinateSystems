using SharpKml.Base;
using SharpKml.Dom;
using System.Collections.Generic;
using DotSpatial.Projections;

namespace EpsgCoordinateSystems.Categories
{
    internal class NAD83_Virginia_North_ftUS : IEpsgCoordinateSystem
    {
        private const int _srid = 2283;
        public ProjectionInfo ProjectionInfo => ProjectionInfo.FromEpsgCode(_srid);
        public string Name => "Virginia North";
        public string Description => $"{Name}  |  NAD83-{Units}  |  (EPSG: {Srid})";
        public string Units => "US feet";
        public int Srid => _srid;

        public string OgcWkt =>
            "PROJCS[NAD83 / Virginia North (ftUS),GEOGCS[NAD83,DATUM[North_American_Datum_1983,SPHEROID[GRS 1980,6378137,298.257222101,AUTHORITY[EPSG,7019]],AUTHORITY[EPSG,6269]],PRIMEM[Greenwich,0,AUTHORITY[EPSG,8901]],UNIT[degree,0.01745329251994328,AUTHORITY[EPSG,9122]],AUTHORITY[EPSG,4269]],UNIT[US survey foot,0.3048006096012192,AUTHORITY[EPSG,9003]],PROJECTION[Lambert_Conformal_Conic_2SP],PARAMETER[standard_parallel_1,39.2],PARAMETER[standard_parallel_2,38.03333333333333],PARAMETER[latitude_of_origin,37.66666666666666],PARAMETER[central_meridian,-78.5],PARAMETER[false_easting,11482916.667],PARAMETER[false_northing,6561666.667],AUTHORITY[EPSG,2283],AXIS[X,EAST],AXIS[Y,NORTH]]";

        public string EsriWkt =>
            "PROJCS[NAD83 / Virginia North (ftUS),GEOGCS[GCS_North_American_1983,DATUM[D_North_American_1983,SPHEROID[GRS_1980,6378137,298.257222101]],PRIMEM[Greenwich,0],UNIT[Degree,0.017453292519943295]],PROJECTION[Lambert_Conformal_Conic],PARAMETER[standard_parallel_1,39.2],PARAMETER[standard_parallel_2,38.03333333333333],PARAMETER[latitude_of_origin,37.66666666666666],PARAMETER[central_meridian,-78.5],PARAMETER[false_easting,11482916.667],PARAMETER[false_northing,6561666.667],UNIT[Foot_US,0.30480060960121924]]";

        public List<LinearRing> Wgs84Boundaries => new List<LinearRing>
        {
            new LinearRing
            {
                Coordinates = new CoordinateCollection(new[]
                {
                    new Vector(38.1271518181818, -78.207035),
                    new Vector(38.126818818182, -78.18538100000001),
                    new Vector(38.142937818182, -78.138716),
                    new Vector(38.1398328181819, -78.123479),
                    new Vector(38.1499308181818, -78.100151),
                    new Vector(38.1324708181819, -78.05202800000001),
                    new Vector(38.1412008181818, -78.02283199999989),
                    new Vector(38.138572818182, -78.001169),
                    new Vector(38.1209958181819, -77.979992),
                    new Vector(38.1210858181819, -77.958347),
                    new Vector(38.1108978181818, -77.8851769999999),
                    new Vector(38.0987388181819, -77.86112900000001),
                    new Vector(38.1051108181819, -77.853551),
                    new Vector(38.1015288181818, -77.83657700000001),
                    new Vector(38.0780208181819, -77.811323),
                    new Vector(38.0717298181818, -77.78733800000001),
                    new Vector(38.0644758181818, -77.787887),
                    new Vector(38.0477808181818, -77.749835),
                    new Vector(38.0246868181818, -77.74799899999989),
                    new Vector(38.0306088181819, -77.732834),
                    new Vector(38.0156778181818, -77.716436),
                    new Vector(38.0111868181818, -77.689544),
                    new Vector(38.0107548181818, -77.67670099999999),
                    new Vector(37.9967328181819, -77.663813),
                    new Vector(37.9958418181819, -77.64687499999999),
                    new Vector(37.9532628181819, -77.61760700000001),
                    new Vector(37.9573668181819, -77.603027),
                    new Vector(37.9505718181819, -77.587259),
                    new Vector(37.9623618181818, -77.57501000000001),
                    new Vector(37.9338138181819, -77.548721),
                    new Vector(37.9229418181819, -77.55221299999999),
                    new Vector(37.9143378181818, -77.5387939999999),
                    new Vector(37.9179648181819, -77.52595100000001),
                    new Vector(37.8817218181818, -77.483966),
                    new Vector(37.8912168181819, -77.440811),
                    new Vector(37.8644688181819, -77.42101099999999),
                    new Vector(37.8477018181818, -77.43326),
                    new Vector(37.8205038181819, -77.42105599999999),
                    new Vector(37.8109818181819, -77.42805799999999),
                    new Vector(37.8023598181819, -77.4175819999999),
                    new Vector(37.804168818182, -77.40651200000001),
                    new Vector(37.7783298181819, -77.404217),
                    new Vector(37.7765028181819, -77.38790899999999),
                    new Vector(37.7959698181818, -77.365166),
                    new Vector(37.7882568181818, -77.35586000000001),
                    new Vector(37.7909658181818, -77.34654500000001),
                    new Vector(37.8013788181818, -77.34418700000001),
                    new Vector(37.8339498181819, -77.294012),
                    new Vector(37.8538758181819, -77.28404),
                    new Vector(37.8760248181819, -77.247248),
                    new Vector(37.9118268181819, -77.2436299999999),
                    new Vector(37.9022328181819, -77.210987),
                    new Vector(37.8877338181819, -77.21278700000001),
                    new Vector(37.8894888181819, -77.19296),
                    new Vector(37.8967338181819, -77.187686),
                    new Vector(37.9057698181819, -77.17890199999989),
                    new Vector(37.9361628181818, -77.18459900000001),
                    new Vector(37.9637658181818, -77.16871399999999),
                    new Vector(37.9700658181819, -77.152343),
                    new Vector(37.9717488181819, -77.107973),
                    new Vector(37.9658088181819, -77.096912),
                    new Vector(37.9707138181818, -77.074106),
                    new Vector(38.0065338181819, -77.081504),
                    new Vector(38.0230218181819, -77.133398),
                    new Vector(38.0366118181819, -77.129249),
                    new Vector(38.0734398181819, -77.16882200000001),
                    new Vector(38.1196008181819, -77.145206),
                    new Vector(38.1254058181819, -77.1170989999999),
                    new Vector(38.1449088181818, -77.1205099999999),
                    new Vector(38.1616218181819, -77.101106),
                    new Vector(38.1488778181819, -77.086544),
                    new Vector(38.1556278181819, -77.07245899999999),
                    new Vector(38.1433248181818, -77.05555699999999),
                    new Vector(38.1088728181818, -77.05342400000001),
                    new Vector(38.0961198181819, -77.037719),
                    new Vector(38.0942388181819, -77.02018700000001),
                    new Vector(38.1054978181818, -77.00198),
                    new Vector(38.0882088181818, -76.98280099999999),
                    new Vector(38.0786598181818, -76.94976200000001),
                    new Vector(38.0965698181819, -76.92776600000001),
                    new Vector(38.1090168181818, -76.878545),
                    new Vector(38.0597418181819, -76.819334),
                    new Vector(38.0551068181819, -76.801253),
                    new Vector(38.0276748181818, -76.762373),
                    new Vector(38.0004858181819, -76.763228),
                    new Vector(37.9966248181818, -76.719461),
                    new Vector(37.9829178181819, -76.702091),
                    new Vector(37.9830888181818, -76.65946700000001),
                    new Vector(37.9688868181818, -76.63919),
                    new Vector(37.9995768181818, -76.619561),
                    new Vector(38.0030058181819, -76.594982),
                    new Vector(38.0242098181818, -76.581293),
                    new Vector(38.0254608181819, -76.557722),
                    new Vector(38.0742498181818, -76.54871300000001),
                    new Vector(38.1203658181818, -76.595279),
                    new Vector(38.2026168181819, -76.936154),
                    new Vector(38.280412818182, -76.9990549999999),
                    new Vector(38.375470818182, -77.05423399999999),
                    new Vector(38.3314968181818, -77.240399),
                    new Vector(38.3441058181818, -77.32152499999999),
                    new Vector(38.3627898181818, -77.289179),
                    new Vector(38.4369588181818, -77.338193),
                    new Vector(38.5020288181819, -77.303327),
                    new Vector(38.6508528181818, -77.227304),
                    new Vector(38.6608968181819, -77.19445399999999),
                    new Vector(38.6228268181818, -77.19696500000001),
                    new Vector(38.6482428181819, -77.12969),
                    new Vector(38.677924818182, -77.124821),
                    new Vector(38.7041058181819, -77.092844),
                    new Vector(38.7154008181819, -77.081585),
                    new Vector(38.7121428181818, -77.056817),
                    new Vector(38.7189018181818, -77.04617),
                    new Vector(38.7882108181819, -77.04514399999999),
                    new Vector(38.8140138181819, -77.034947),
                    new Vector(38.8294758181818, -77.044892),
                    new Vector(38.8385118181818, -77.040104),
                    new Vector(38.8625238181819, -77.03877199999999),
                    new Vector(38.8862028181818, -77.067581),
                    new Vector(38.9156958181819, -77.078642),
                    new Vector(38.9321658181818, -77.122328),
                    new Vector(38.9648808181818, -77.1517489999999),
                    new Vector(38.9759868181819, -77.243432),
                    new Vector(39.0276558181818, -77.25569),
                    new Vector(39.0626838181819, -77.32430600000001),
                    new Vector(39.0686058181818, -77.34623000000001),
                    new Vector(39.0668778181818, -77.43274700000001),
                    new Vector(39.0809448181819, -77.4593959999999),
                    new Vector(39.1040658181819, -77.478962),
                    new Vector(39.1167558181819, -77.51275699999999),
                    new Vector(39.1575438181818, -77.5163299999999),
                    new Vector(39.1770468181819, -77.478341),
                    new Vector(39.2187348181818, -77.461709),
                    new Vector(39.2291658181819, -77.46466100000001),
                    new Vector(39.2500278181818, -77.493776),
                    new Vector(39.2690268181819, -77.541899),
                    new Vector(39.2984838181818, -77.568674),
                    new Vector(39.2998068181819, -77.61623899999999),
                    new Vector(39.3187788181818, -77.67930200000001),
                    new Vector(39.3177978181819, -77.72746100000001),
                    new Vector(39.2846328181819, -77.759456),
                    new Vector(39.2465628181818, -77.76824000000001),
                    new Vector(39.1966218181818, -77.805446),
                    new Vector(39.1417308181819, -77.8200439999999),
                    new Vector(39.1321818181819, -77.830682),
                    new Vector(39.2656248181819, -78.033326),
                    new Vector(39.3911298181819, -78.229508),
                    new Vector(39.4234758181819, -78.2768839999999),
                    new Vector(39.4570098181819, -78.347543),
                    new Vector(39.3808338181819, -78.35022499999999),
                    new Vector(39.3616908181818, -78.365471),
                    new Vector(39.3509538181819, -78.343925),
                    new Vector(39.3414588181819, -78.340847),
                    new Vector(39.2575338181818, -78.413549),
                    new Vector(39.2449608181819, -78.399131),
                    new Vector(39.2121558181819, -78.42307099999989),
                    new Vector(39.1976388181819, -78.42406099999999),
                    new Vector(39.1706028181817, -78.402362),
                    new Vector(39.1486248181819, -78.430577),
                    new Vector(39.1190328181818, -78.44798299999999),
                    new Vector(39.1119588181818, -78.485252),
                    new Vector(39.0936618181819, -78.50159600000001),
                    new Vector(39.0571218181819, -78.53665100000001),
                    new Vector(39.0351258181819, -78.564182),
                    new Vector(39.0234708181819, -78.54919699999989),
                    new Vector(39.0139218181818, -78.553211),
                    new Vector(38.9673018181818, -78.598697),
                    new Vector(38.979712818182, -78.63084499999999),
                    new Vector(38.9505528181818, -78.646973),
                    new Vector(38.9216808181818, -78.680228),
                    new Vector(38.9049948181818, -78.718982),
                    new Vector(38.9303298181817, -78.724148),
                    new Vector(38.9292948181819, -78.73773799999999),
                    new Vector(38.9115018181818, -78.749258),
                    new Vector(38.880199818182, -78.793052),
                    new Vector(38.8337238181818, -78.815867),
                    new Vector(38.7633888181818, -78.866564),
                    new Vector(38.8467648181818, -78.987452),
                    new Vector(38.7999378181819, -79.033748),
                    new Vector(38.7906048181819, -79.054799),
                    new Vector(38.7620388181818, -79.05655400000001),
                    new Vector(38.7072738181818, -79.08723500000001),
                    new Vector(38.6592048181819, -79.088549),
                    new Vector(38.6637768181818, -79.121066),
                    new Vector(38.6582418181819, -79.12742900000001),
                    new Vector(38.4805188181819, -79.231667),
                    new Vector(38.4372918181818, -79.27236499999999),
                    new Vector(38.4126228181819, -79.316996),
                    new Vector(38.4621678181818, -79.486349),
                    new Vector(38.5537788181819, -79.53651499999999),
                    new Vector(38.5923528181819, -79.642409),
                    new Vector(38.5501698181819, -79.6694269999999),
                    new Vector(38.520775818182, -79.66562),
                    new Vector(38.5003458181818, -79.692656),
                    new Vector(38.4302538181818, -79.684088),
                    new Vector(38.3947038181818, -79.7200339999999),
                    new Vector(38.3518458181819, -79.732823),
                    new Vector(38.353969818182, -79.763999),
                    new Vector(38.3143068181819, -79.80032300000001),
                    new Vector(38.2988448181819, -79.8027799999999),
                    new Vector(38.2850928181818, -79.786508),
                    new Vector(38.268640818182, -79.7936179999999),
                    new Vector(38.2502538181819, -79.831157),
                    new Vector(38.1792618181818, -79.916162),
                    new Vector(38.1626028181819, -79.91033899999999),
                    new Vector(38.1213108181819, -79.935323),
                    new Vector(38.1033108181819, -79.92829399999999),
                    new Vector(38.0673648181818, -79.957517),
                    new Vector(38.0386188181819, -79.96648999999999),
                    new Vector(37.9898388181819, -80.000501),
                    new Vector(37.9556298181819, -80.054807),
                    new Vector(37.9461168181818, -80.03228900000001),
                    new Vector(37.9621098181819, -80.004227),
                    new Vector(37.9563048181819, -79.933379),
                    new Vector(37.8977958181818, -79.88827999999999),
                    new Vector(37.8850608181818, -79.819034),
                    new Vector(37.8889128181819, -79.75849100000001),
                    new Vector(37.842643818182, -79.686536),
                    new Vector(37.8773658181818, -79.646162),
                    new Vector(37.9350468181818, -79.613978),
                    new Vector(37.9878948181818, -79.54539800000001),
                    new Vector(38.0259558181818, -79.518407),
                    new Vector(38.0453418181818, -79.524788),
                    new Vector(38.0854908181819, -79.48260500000001),
                    new Vector(37.9136988181819, -79.178099),
                    new Vector(37.8896058181818, -79.149551),
                    new Vector(37.9021338181819, -79.127672),
                    new Vector(37.9007028181818, -79.099052),
                    new Vector(37.9125018181818, -79.0625569999999),
                    new Vector(37.8892638181818, -79.03523300000001),
                    new Vector(37.8871398181819, -78.990278),
                    new Vector(37.9324818181818, -78.95093900000001),
                    new Vector(37.9332198181818, -78.92701700000001),
                    new Vector(37.9521558181818, -78.89645299999999),
                    new Vector(37.9906668181818, -78.898343),
                    new Vector(38.0302668181819, -78.88332200000001),
                    new Vector(38.0425338181818, -78.83913200000001),
                    new Vector(38.0812518181819, -78.77903000000001),
                    new Vector(38.1333528181819, -78.782855),
                    new Vector(38.1775878181819, -78.75728599999999),
                    new Vector(38.2071078181819, -78.75194),
                    new Vector(38.2350528181819, -78.72427399999999),
                    new Vector(38.2509648181819, -78.66887),
                    new Vector(38.2741848181818, -78.6580969999999),
                    new Vector(38.184121818182, -78.370358),
                    new Vector(38.1271518181818, -78.207035)
                })
            }
        };
    }
}